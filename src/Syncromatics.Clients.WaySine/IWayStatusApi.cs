using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RestEase;
using Syncromatics.Clients.WaySine.Models;

[assembly: InternalsVisibleTo(RestEase.RestClient.FactoryAssemblyName)]
namespace Syncromatics.Clients.WaySine
{
    [Header("User-Agent", "Syncromatics.Clients.WaySine")]
    internal interface IWayStatusApi
    {
        [Get("WayStatus/Api/Services.svc/GetSigns")]
        Task<ICollection<Sign>> GetAllSigns();

        [Get("WayStatus/Api/Services.svc/GetSigns")]
        Task<ICollection<Sign>> GetSign([Query] int id);
    }
}