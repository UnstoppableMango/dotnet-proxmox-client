using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Storage
{
    [PublicAPI]
    public record UpdateStorageRequest(string Storage)
    {
        public string? BlockSize { get; init; }

        public string? BwLimit { get; init; }

        public string? ComStarHg { get; init; }

        public string? ComStarTg { get; init; }

        public string? Content { get; init; }

        public string? Delete { get; init; }

        public string? Digest { get; init; }

        public bool? Disable { get; init; }

        public string? Domain { get; init; }

        public string? EncryptionKey { get; init; }

        public string? FingerPrint { get; init; }

        public string? Format { get; init; }

        public bool? Fuse { get; init; }

        public string? IsMountPoint { get; init; }

        public bool? Krbd { get; init; }

        public string? LioTpg { get; init; }

        public string? MasterPubKey { get; init; }

        public int? MaxFiles { get; init; }

        public bool? Mkdir { get; init; }

        public string? MonHost { get; init; }

        public string? MountPoint { get; init; }

        public string? Namespace { get; init; }

        public bool? NoCow { get; init; }

        public string? Nodes { get; init; }

        public bool? NoWriteCache { get; init; }

        public string? Options { get; init; }

        public string? Password { get; init; }

        public string? Pool { get; init; }

        public int? Port { get; init; }

        public string? PruneBackups { get; init; }

        public bool? SafeRemove { get; init; }

        public string? SafeRemoveThroughput { get; init; }

        public string? Server { get; init; }

        public string? Server2 { get; init; }

        public bool? Shared { get; init; }

        public SmbVersion? SmbVersion { get; init; }

        public bool? Sparse { get; init; }

        public string? SubDir { get; init; }

        public bool? TaggedOnly { get; init; }

        public GlusterTransport? Transport { get; init; }

        public string? Username { get; init; }
    }
}
