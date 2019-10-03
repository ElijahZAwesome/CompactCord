using System;
using System.Text;
using System.Net.Sockets;
using System.IO;
using CompactCord.PublicMethods;
using CompactCord.PublicVariables;
using System.Net;

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
    Sec-WebSocket-Key: dGhlIHNhbXBsZSBub25jZQ==
    {Constants.USERAGENT}


            ";
            return header;
        }

        public void Initialize()
        {
            TCPClient = new TcpClient(Endpoint, Port);
            NetStream = TCPClient.GetStream();
            Writer = new StreamWriter(NetStream);
            Writer.Write(GetHeader());
            Writer.Flush();
            byte[] buffer = new byte[1024];
            int bytesRead = NetStream.Read(buffer, 0, buffer.Length);
            string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine(response);
            byte frameByte = Convert.ToByte("10000001", 2);
        }

    }
}
