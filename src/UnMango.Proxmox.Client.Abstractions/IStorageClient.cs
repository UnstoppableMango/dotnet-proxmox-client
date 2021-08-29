using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnMango.Proxmox.Client.Abstractions.Request.Storage;
using UnMango.Proxmox.Client.Abstractions.Response.Storage;
using UnMango.Proxmox.Client.Abstractions.Storage;

namespace UnMango.Proxmox.Client.Abstractions
{
    /// <summary>
    /// Client for interacting with the Proxmox storage REST API.
    /// </summary>
    /// <remarks>
    /// Only list entries where you have 'Datastore.Audit' or 'Datastore.AllocateSpace' permissions on '/storage/&lt;storage&gt;'
    /// </remarks>
    [PublicAPI]
    public interface IStorageClient
    {
        /// <summary>
        /// Create a new storage.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<CreateStorageResponse> CreateAsync(CreateStorageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Read storage configuration.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<object> Get(string storage, CancellationToken cancellationToken = default);

        /// <summary>
        /// Storage index.
        /// </summary>
        /// <param name="type">Only list storage of a specific type.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        IAsyncEnumerable<string> GetAll(StorageType? type = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Storage index.
        /// </summary>
        /// <param name="type">Only list storage of a specific type.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<string>> GetAllAsync(StorageType? type = null, CancellationToken cancellationToken = default);
    }
}
