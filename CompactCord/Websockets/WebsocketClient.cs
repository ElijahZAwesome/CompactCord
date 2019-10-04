using System;
using System.Text;
using System.Net.Sockets;
using System.IO;
using CompactCord.PublicMethods;
using CompactCord.PublicVariables;
using System.Net;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Utilities.Zlib;
using System.IO.Compression;

/// <summary>
/// Guess i'm making my own client now...
/// </summary>
namespace CompactCord.Websockets
{
    public class WebsocketClient
    {
        private TcpClient TCPClient;
        private NetworkStream NetStream;
        private StreamWriter Writer;
        public string SocketRaw;
        public string SocketTrimmed;
        public string Endpoint;
        public int Port;

        public WebsocketClient(string URI, int port = -1)
        {

            //ServicePointManager.CertificatePolicy = new TrustAllCertificatePolicy();
            SocketRaw = URI;
            if (port == -1)
            {
                if(URI.StartsWith("wss://"))
                {
                    SocketTrimmed = Strings.StripPrefix(URI, "wss://");
                    this.Port = 443;
                } else
                {
                    SocketTrimmed = Strings.StripPrefix(URI, "ws://");
                    this.Port = 80;
                }
            } else
            {
                SocketTrimmed = URI;
                this.Port = port;
            }

            IPHostEntry endpoints = Dns.GetHostEntry(SocketTrimmed);

            Endpoint = endpoints.AddressList[0].ToString();

        }

        private string GetHeader()
        {
            string header = $@"
    GET / HTTP/1.1
    Host: {SocketTrimmed}
    Upgrade: websocket
    Connection: Upgrade
    Sec-WebSocket-Key: {Strings.Base64Encode(Strings.RandomString(20))}
    Content-Encoding: identity
    {Constants.USERAGENT}


            ";
            return header;
        }

        [Obsolete]
        public void Initialize()
        {
            TCPClient = new TcpClient();
            TCPClient.Connect(Endpoint, Port);
            NetStream = TCPClient.GetStream();
            Org.BouncyCastle.Security.SecureRandom sr = new Org.BouncyCastle.Security.SecureRandom();
            TlsProtocolHandler handler = new TlsProtocolHandler(NetStream, sr);
            handler.Connect(new TrustAllCertificatePolicy());
            Writer = new StreamWriter(NetStream);
            Writer.Write(GetHeader());
            Writer.Flush();
            byte[] buffer = new byte[1024];
            int bytesRead = NetStream.Read(buffer, 0, buffer.Length);
            byte[] decompressBuffer = new byte[1024];
            Zlib.DecompressData(buffer, out decompressBuffer);
            string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            string responseDecompressed = Encoding.ASCII.GetString(decompressBuffer, 0, bytesRead);
            Console.WriteLine("=== RESPONSE ===");
            Console.WriteLine(response);
            Console.WriteLine("=== DECOMPRESSED ===");
            Console.WriteLine(responseDecompressed);
            Bytes.ByteArrayToFile("out.raw", buffer);
            byte frameByte = Convert.ToByte("10000001", 2);
        }

    }
}
