using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Nodes
{
    [PublicAPI]
    public record GetNodeResponse(string Node, NodeStatus Status)
    {
        /// <summary>
        /// CPU utilization.
        /// </summary>
        public int? Cpu { get; init; }

        /// <summary>
        /// Support level.
        /// </summary>
        public string? Level { get; init; }

        /// <summary>
        /// Number of available CPUs.
        /// </summary>
        public int? MaxCpu { get; init; }

        /// <summary>
        /// Number of available memory in bytes.
        /// </summary>
        public int? MaxMem { get; init; }

        /// <summary>
        /// Use memory in bytes.
        /// </summary>
        public int? Mem { get; init; }

        /// <summary>
        /// The SSL fingerprint for the node certificate.
        /// </summary>
        public string? SslFingerprint { get; init; }

        /// <summary>
        /// Node uptime in seconds.
        /// </summary>
        public int? Uptime { get; init; }
    }
}
