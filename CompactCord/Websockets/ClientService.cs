using System;
using System.Diagnostics;
using System.Threading;
using Noemax.WebSockets;

namespace CompactCord.Websockets
{
    class ClientService : WebSocketService
    {
        // number of client connections to create
        private const int MaxConnectionNumber = 1;
        // interval in received messages to print out statistics
        private const int PrintOutInterval = 10000;
        private static Stopwatch stopwatch = new Stopwatch();
        private static int repliesReceived = 0;


        // handles text messages relayed by the server
        public override void OnMessage(WebSocketChannel channel, string text)
        {
            int count = Interlocked.Increment(ref repliesReceived);
            // report statistics 
            if (count % PrintOutInterval == 0)
            {
                Console.WriteLine(count + " messages in " +
                      stopwatch.ElapsedMilliseconds + "ms");
            }

            // since the client will broadcast the message through all client 
            // channels and since the service will broadcast each received 
            // message back to all connected channels, the number of messages returned is
            // expected to be MaxConnectionNumber * MaxConnectionNumber
            if (count == MaxConnectionNumber * MaxConnectionNumber)
            {
                Console.WriteLine("Received all replies.");
                Console.WriteLine("Press any key to exit.");
            }
        }
    }
}
