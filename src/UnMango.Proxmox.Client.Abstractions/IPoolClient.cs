using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnMango.Proxmox.Client.Request.Pools;
using UnMango.Proxmox.Client.Response.Pools;

namespace UnMango.Proxmox.Client
{
    /// <summary>
    /// Client for interacting with the Proxmox Pools REST API.
    /// </summary>
    [PublicAPI]
    public interface IPoolClient
    {
        /// <summary>
        /// Create a new pool.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task CreateAsync(CreatePoolRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get pool configuration.
        /// </summary>
        /// <param name="poolId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GetPoolResponse> GetAsync(string poolId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Pool index.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// List all pools where you have Pool.Audit permissions on /pool/&lt;pool&gt;.
        /// </remarks>
        IAsyncEnumerable<string> GetAll(CancellationToken cancellationToken = default);

        /// <summary>
        /// Pool index.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// List all pools where you have Pool.Audit permissions on /pool/&lt;pool&gt;.
        /// </remarks>
        Task<IEnumerable<string>> GetAllAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Update pool data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// You also need the right to modify permissions on any object you add/delete.
        /// Check: ["perm","/pool/{poolid}",["Pool.Allocate"]]
        /// </remarks>
        Task UpdateAsync(UpdatePoolRequest request, CancellationToken cancellationToken = default);
    }
}
