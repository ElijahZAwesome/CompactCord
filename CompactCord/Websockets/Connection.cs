using System.Collections.Generic;
using Noemax.WebSockets;
using CompactCord.PublicVariables;
using CompactCord.PublicMethods;

namespace CompactCord
{
    namespace Websockets
    {
        public static class Connection
        {

            public static WebSocketClient ConnectToDiscord()
            {

                List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>()
                {
                    new KeyValuePair<string, object>("v", Constants.GATEWAYVERSION),
                    new KeyValuePair<string, object>("encoding", Constants.GATEWAYENCODING)
                };

                string connectURI = DiscordSockets.ConstructURI(Constants.GATEWAYURL, parameters);
                var client = new WebSocketClient<Websockets.ClientService>(connectURI);

                client.Open();
                return client;
            }

        }
    }
}
