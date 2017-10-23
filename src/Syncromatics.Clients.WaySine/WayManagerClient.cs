using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncromatics.Clients.WaySine.Models;
using RestEase;

namespace Syncromatics.Clients.WaySine
{
    public class WayManagerClient : IWayManagerClient
    {
        private readonly IWayManagerApi _api;

        public WayManagerClient(ClientSettings clientSettings)
        {
            if (clientSettings == null)
            {
                throw new ArgumentNullException(nameof(clientSettings));
            }
            _api = RestClient.For<IWayManagerApi>(clientSettings.ServerRootUrl);
        }

        public async Task<ICollection<SignStatus>> GetAllSignsAsync()
        {
            var result = await _api.GetAllSigns();
            return result?.Signs;
        }

        public async Task<SignStatus> GetSignAsync(int signId)
        {
            var result = await _api.GetSign(signId);
            return result?.Signs?.FirstOrDefault();
        }
    }
}
