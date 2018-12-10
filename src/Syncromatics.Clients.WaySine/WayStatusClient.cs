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

        public WayStatusClient(ClientSettings clientSettings)
        {
            if (clientSettings == null)
            {
                throw new ArgumentNullException(nameof(clientSettings));
            }
            _api = RestClient.For<IWayStatusApi>(clientSettings.ServerRootUrl);
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
