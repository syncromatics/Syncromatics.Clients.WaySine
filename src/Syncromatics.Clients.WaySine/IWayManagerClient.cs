using System.Collections.Generic;
using System.Threading.Tasks;
using Syncromatics.Clients.WaySine.Models;

namespace Syncromatics.Clients.WaySine
{
    /// <summary>
    /// Client to interact with the WaySine WayManager API.
    /// </summary>
    public interface IWayManagerClient
    {
        /// <summary>
        /// Get status information for every available sign.
        /// </summary>
        /// <returns>A collection of all sign status updates available.</returns>
        Task<ICollection<SignStatus>> GetAllSignsAsync();

        /// <summary>
        /// Get status information for a particular sign.
        /// </summary>
        /// <param name="id">The ID of the sign for which to query.</param>
        /// <returns>Sign status for the given <paramref name="signId"/></returns>
        Task<SignStatus> GetSignAsync(int signId);
    }
}
