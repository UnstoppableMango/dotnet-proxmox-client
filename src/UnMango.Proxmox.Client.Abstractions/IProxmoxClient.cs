using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace UnMango.Proxmox.Client
{
    [PublicAPI]
    public interface IProxmoxClient
    {
        /// <summary>
        /// API version details. The result also includes the global datacenter configuration.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<VersionResponse> GetVersionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a client for making storage related requests.
        /// </summary>
        IStorageClient Storage { get; }
    }
}
