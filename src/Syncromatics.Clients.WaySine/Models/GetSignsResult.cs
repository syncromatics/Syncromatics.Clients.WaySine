using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

[assembly: InternalsVisibleTo("RestEase.RestClient.FactoryAssemblyName")]
namespace Syncromatics.Clients.WaySine.Models
{
    internal class GetSignsResult
    {
        [JsonProperty("GetSignsJsonResult")]
        public ICollection<SignStatus> Signs { get; set; }
    }
}
