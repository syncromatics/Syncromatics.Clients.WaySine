using System;

namespace Syncromatics.Clients.WaySine
{
    // Specifies settings for connecting to the WaySine WayManager API.
    public class ClientSettings
    {
        /// <summary>
        /// The root URL to use to connect to the WayManager API.
        /// </summary>
        public string ServerRootUrl { get; set; }

        /// <summary>
        /// Creates a new ClientSettings instance.
        /// </summary>
        public ClientSettings()
        {
        }

        /// <summary>
        /// Creates a new ClientSettings instance.
        /// </summary>
        /// <param name="serverRootUrl">The root URL to use to connect to the WayManager API.</param>
        public ClientSettings(string serverRootUrl)
        {
            ServerRootUrl = serverRootUrl;
        }
    }
}
