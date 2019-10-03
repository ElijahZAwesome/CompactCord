using System;
using System.Collections.Generic;
using CompactCord;
using CompactCord.PublicVariables;
using CompactCord.PublicMethods;

namespace CompactCord.Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //var instance = CompactCord.Websockets.Connection.ConnectToDiscord();
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>()
                {
                    new KeyValuePair<string, object>("v", Constants.GATEWAYVERSION),
                    new KeyValuePair<string, object>("encoding", Constants.GATEWAYENCODING)
                };

            //string connectURI = DiscordSockets.ConstructURI(Constants.GATEWAYURL, parameters);
            string connectURI = Constants.GATEWAYURL;
            var instance = new Websockets.WebsocketClient(connectURI);
            instance.Initialize();
        }
    }
}
