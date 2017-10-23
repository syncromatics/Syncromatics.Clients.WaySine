using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RestEase;
using Syncromatics.Clients.WaySine.Models;

[assembly: InternalsVisibleTo(RestEase.RestClient.FactoryAssemblyName)]
namespace Syncromatics.Clients.WaySine
{
    [Header("User-Agent", "Syncromatics.Clients.WaySine")]
    internal interface IWayManagerApi
    {
        [Get("WayManager/Services/SignMonitor.svc/Ajax/GetSigns")]
        Task<GetSignsResult> GetAllSigns();

        [Get("WayManager/Services/SignMonitor.svc/Ajax/GetSigns")]
        Task<GetSignsResult> GetSign([Query] int id);
    }
}
