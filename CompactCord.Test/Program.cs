using System;
using System.Collections.Generic;
using CompactCord;

namespace CompactCord.Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var instance = CompactCord.Websockets.Connection.ConnectToDiscord();
        }
    }
}
