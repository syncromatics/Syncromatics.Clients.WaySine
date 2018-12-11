using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncromatics.Clients.WaySine.Models;
using RestEase;

namespace Syncromatics.Clients.WaySine
{
    public class WayStatusClient : IWayStatusClient
    {
        private readonly IWayStatusApi _api;
        private const string UrlSuffix = "WayStatus/Api/Services.svc/GetSigns";

        public WayStatusClient(ClientSettings clientSettings)
        {
            if (clientSettings == null)
            {
                throw new ArgumentNullException(nameof(clientSettings));
            }

            var serverRootUrl = clientSettings.ServerRootUrl;
            if (serverRootUrl.EndsWith(UrlSuffix, StringComparison.CurrentCultureIgnoreCase))
            {
                serverRootUrl = serverRootUrl.Substring(0, serverRootUrl.Length - UrlSuffix.Length);
            }

            _api = RestClient.For<IWayStatusApi>(serverRootUrl);
        }

        public async Task<ICollection<Sign>> GetAllSignsAsync()
        {
            var result = await _api.GetAllSigns();
            return result;
        }

        public async Task<Sign> GetSignAsync(int signId)
        {
            var result = await _api.GetSign(signId);
            return result?.FirstOrDefault();
        }
    }
}
