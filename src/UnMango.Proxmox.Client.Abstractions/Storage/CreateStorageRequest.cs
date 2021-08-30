using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Storage
{
    /// <summary>
    /// Request to create a new storage.
    /// </summary>
    /// <param name="Storage">The storage identifier.</param>
    /// <param name="Type">Storage type.</param>
    [PublicAPI]
    public record CreateStorageRequest(string Storage, StorageType Type)
    {
        /// <summary>
        /// Auth Supported.
        /// </summary>
        public string? AuthSupported { get; init; }

        /// <summary>
        /// Base volume. This volume is automatically activated.
        /// </summary>
        public string? Base { get; init; }

        /// <summary>
        /// Block Size.
        /// </summary>
        public string? BlockSize { get; init; }

        /// <summary>
        /// Set bandwitdh/io limits various operations.
        /// </summary>
        /// <remarks>
        /// [clone=&lt;LIMIT&gt;] [,default=&lt;LIMIT&gt;] [,migration=&lt;LIMIT&gt;] [,move=&lt;LIMIT&gt;] [,restore=&lt;LIMIT&gt;]
        /// </remarks>
        public string? BwLimit { get; init; }

        /// <summary>
        /// Host group for ComStar views.
        /// </summary>
        public string? ComStarHg { get; init; }

        /// <summary>
        /// Target group for ComStar views.
        /// </summary>
        public string? ComStarTg { get; init; }

        /// <summary>
        /// Allowed content types.
        /// </summary>
        /// <remarks>
        /// The value 'rootdir' is used for Containers, and value 'images' for VMs.
        /// </remarks>
        public string? Content { get; init; }

        /// <summary>
        /// Proxmox Backup Server datastore name.
        /// </summary>
        public string? DataStore { get; init; }

        /// <summary>
        /// Flag to disable the storage.
        /// </summary>
        public bool? Disable { get; init; }

        /// <summary>
        /// CIFS domain.
        /// </summary>
        public string? Domain { get; init; }

        /// <summary>
        /// Encryption key. Use 'autogen' to generate one automatically without passphrase.
        /// </summary>
        public string? EncryptionKey { get; init; }

        /// <summary>
        /// NFS export path.
        /// </summary>
        public string? Export { get; init; }

        /// <summary>
        /// Certificate SHA 256 fingerprint.
        /// </summary>
        /// <remarks>
        /// ([A-Fa-f0-9]{2}:){31}[A-Fa-f0-9]{2}
        /// </remarks>
        public string? Fingerprint { get; init; }

        /// <summary>
        /// Default image format.
        /// </summary>
        public string? Format { get; init; }

        /// <summary>
        /// Mount CephFS through FUSE.
        /// </summary>
        public bool? Fuse { get; init; }

        /// <summary>
        /// Assume the given path is an externally managed mountpoint and consider the storage offline if it is not mounted.
        /// Using a boolean (yes/no) value serves as a shortcut to using the target path in this field.
        /// </summary>
        public string? IsMountPoint { get; init; }

        /// <summary>
        /// ISCSI provider.
        /// </summary>
        public string? IscsiProvider { get; init; }

        /// <summary>
        /// Always access rbd through krbd kernel module.
        /// </summary>
        public bool? Krbd { get; init; }

        /// <summary>
        /// Target portal group for Linux LIO targets.
        /// </summary>
        public string? LioTpg { get; init; }

        /// <summary>
        /// Base64-encoded, PEM-formatted public RSA key. Used to encrypt a copy of the
        /// encryption-key which will be added to each encrypted backup.
        /// </summary>
        public string? MasterPubKey { get; init; }

        /// <summary>
        /// Deprecated: use 'prune-backups' instead. Maximal number of backup files per VM. Use '0' for unlimited.
        /// </summary>
        public int? MaxFiles { get; init; }

        /// <summary>
        /// Create the directory if it doesn't exist.
        /// </summary>
        public bool? Mkdir { get; init; }

        /// <summary>
        /// IP addresses of monitors (for external clusters).
        /// </summary>
        public string? MonHost { get; init; }

        /// <summary>
        /// Mount point.
        /// </summary>
        public string? MountPoint { get; init; }

        /// <summary>
        /// RBD Namespace.
        /// </summary>
        public string? Namespace { get; init; }

        /// <summary>
        /// Set the NOCOW flag on files. Disables data checksumming and causes data errors to be unrecoverable from while allowing direct I/O.
        /// Only use this if data does not need to be any more safe than on a single ext4 formatted disk with no underlying raid system.
        /// </summary>
        public bool? NoCow { get; init; }

        /// <summary>
        /// List of cluster node names.
        /// </summary>
        public string? Nodes { get; init; }

        /// <summary>
        /// Disable write caching on the target.
        /// </summary>
        public bool? NoWriteCache { get; init; }

        /// <summary>
        /// NFS mount options (see 'man nfs')
        /// </summary>
        public string? Options { get; init; }

        /// <summary>
        /// Password for accessing the share/datastore.
        /// </summary>
        public string? Password { get; init; }

        /// <summary>
        /// File system path.
        /// </summary>
        public string? Path { get; init; }

        /// <summary>
        /// Pool.
        /// </summary>
        public string? Pool { get; init; }

        /// <summary>
        /// For non default port.
        /// </summary>
        public int? Port { get; init; }

        /// <summary>
        /// iSCSI portal (IP or DNS name with optional port).
        /// </summary>
        public string? Portal { get; init; }

        /// <summary>
        /// The retention options with shorted intervals are processed first with --key-last being the very first one.
        /// Each option covers a specific period of time. We say that backup within this period are covered by this option.
        /// The next option does not take care of already covered backups and only considers older backup.
        /// </summary>
        /// <remarks>
        /// [keep-all=&lt;1|0&gt;] [,keep-daily=&lt;N&gt;] [,keep-hourly=&lt;N&gt;] [,keep-last=&lt;N&gt;] [,keep-monthly=&lt;N&gt;] [,keep-weekly=&lt;N&gt;] [,keep-yearly=&lt;N&gt;]
        /// </remarks>
        public string? PruneBackups { get; init; }

        /// <summary>
        /// Zero-out dat when removing LVs.
        /// </summary>
        public bool? SafeRemove { get; init; }

        /// <summary>
        /// Wipe throughput (cstream -t parameter value).
        /// </summary>
        public string? SafeRemoveThroughput { get; init; }

        /// <summary>
        /// Server IP or DNS name.
        /// </summary>
        public string? Server { get; init; }

        /// <summary>
        /// Backup volfile server IP or DNS name.
        /// </summary>
        public string? Server2 { get; init; }

        /// <summary>
        /// CIFS share.
        /// </summary>
        public string? Share { get; init; }

        /// <summary>
        /// Mark storage as shared.
        /// </summary>
        public bool? Shared { get; init; }

        /// <summary>
        /// SMB protocol version.
        /// </summary>
        public SmbVersion? SmbVersion { get; init; }

        /// <summary>
        /// Use sparse volumes.
        /// </summary>
        public bool? SParse { get; init; }

        /// <summary>
        /// Subdir to mount.
        /// </summary>
        public string? SubDir { get; init; }

        /// <summary>
        /// Only use logical volumes tagged with 'pve-vm-ID'.
        /// </summary>
        public bool? TaggedOnly { get; init; }

        /// <summary>
        /// iSCSI target.
        /// </summary>
        public string? Target { get; init; }

        /// <summary>
        /// LVM thin pool LV name.
        /// </summary>
        public string? ThinPool { get; init; }

        /// <summary>
        /// Cluster transport. tcp or rdma.
        /// </summary>
        public GlusterTransport? Transport { get; init; }

        /// <summary>
        /// RBD Id.
        /// </summary>
        public string? Username { get; init; }

        /// <summary>
        /// Volume group name.
        /// </summary>
        public string? VgName { get; init; }

        /// <summary>
        /// GlusterFS Volume.
        /// </summary>
        public string? Volume { get; init; }
    }
}
