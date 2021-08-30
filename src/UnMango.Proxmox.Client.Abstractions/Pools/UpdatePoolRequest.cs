using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Pools
{
    /// <summary>
    /// Request to update pool data.
    /// </summary>
    /// <param name="PoolId"></param>
    [PublicAPI]
    public record UpdatePoolRequest(string PoolId)
    {
        public string? Comment { get; init; }

        /// <summary>
        /// Remove vms/storage (instead of adding it).
        /// </summary>
        public bool? Delete { get; init; }

        /// <summary>
        /// List of storage IDs.
        /// </summary>
        public string? Storage { get; init; }

        /// <summary>
        /// List of virtual machines.
        /// </summary>
        public string? Vms { get; init; }
    }
}
