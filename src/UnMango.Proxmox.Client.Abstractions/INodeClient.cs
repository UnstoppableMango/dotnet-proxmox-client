using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnMango.Proxmox.Client.Nodes;

namespace UnMango.Proxmox.Client
{
    [PublicAPI]
    public interface INodeClient
    {
        /// <summary>
        /// Cluster node index.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        IAsyncEnumerable<GetNodeResponse> GetAll(CancellationToken cancellationToken = default);

        /// <summary>
        /// Node index.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        IAsyncEnumerable<NodeIndexResponse> GetAll(string node, CancellationToken cancellationToken = default);

        /// <summary>
        /// Directory index for apt.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        IAsyncEnumerable<GetAptResponse> GetAllApt(string node, CancellationToken cancellationToken = default);

        /// <summary>
        /// Directory index for apt.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<GetAptResponse>> GetAllAptAsync(string node, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cluster node index.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<GetNodeResponse>> GetAllAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Node index.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<NodeIndexResponse>> GetAllAsync(string node, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get package changelogs.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<string> GetAptChangelogAsync(string node, string name, CancellationToken cancellationToken = default);
    }
}
