using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnMango.Proxmox.Client.Storage;

namespace UnMango.Proxmox.Client
{
    /// <summary>
    /// Client for interacting with the Proxmox storage REST API.
    /// </summary>
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
        /// Delete storage configuration.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task DeleteAsync(string storage, CancellationToken cancellationToken = default);

        /// <summary>
        /// Read storage configuration.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GetStorageResponseBase> GetAsync(string storage, CancellationToken cancellationToken = default);

        /// <summary>
        /// Storage index.
        /// </summary>
        /// <param name="type">Only list storage of a specific type.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// Only list entries where you have 'Datastore.Audit' or 'Datastore.AllocateSpace' permissions on '/storage/&lt;storage&gt;'
        /// </remarks>
        IAsyncEnumerable<GetStorageResponseBase> GetAll(StorageType? type = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Storage index.
        /// </summary>
        /// <param name="type">Only list storage of a specific type.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// Only list entries where you have 'Datastore.Audit' or 'Datastore.AllocateSpace' permissions on '/storage/&lt;storage&gt;'
        /// </remarks>
        Task<IEnumerable<GetStorageResponseBase>> GetAllAsync(
            StorageType? type = null,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Update storage configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<UpdateStorageResponse> UpdateAsync(UpdateStorageRequest request, CancellationToken cancellationToken = default);
    }
}
