using System.Collections.Generic;
using System.Threading.Tasks;
using Syncromatics.Clients.WaySine.Models;

namespace Syncromatics.Clients.WaySine
{
    /// <summary>
    /// Client to interact with the WaySine WayStatus API
    /// </summary>
    public interface IWayStatusClient
    {
        /// <summary>
        /// Get status information for every available sign.
        /// </summary>
        /// <returns>A collection of all sign status updates available.</returns>
        Task<ICollection<Sign>> GetAllSignsAsync();

        /// <summary>
        /// Get status information for a particular sign.
        /// </summary>
        /// <param name="id">The ID of the sign for which to query.</param>
        /// <returns>Sign status for the given <paramref name="signId"/></returns>
        Task<Sign> GetSignAsync(int signId);
    }
}