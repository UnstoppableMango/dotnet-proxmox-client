using JetBrains.Annotations;
using UnMango.Proxmox.Client.Abstractions.Storage;

namespace UnMango.Proxmox.Client.Abstractions.Request.Storage
{
    /// <summary>
    /// Request to create a new storage.
    /// </summary>
    /// <param name="Storage"></param>
    /// <param name="Type"></param>
    [PublicAPI]
    public record CreateStorageRequest(
        string Storage,
        StorageType Type,
        string? AuthSupported = null,
        string? Base = null,
        string? BlockSize = null,
        string? BwLimit = null,
        string? ComStarHg = null,
        string? ComStarTg = null,
        string? Content = null,
        string? DataStore = null,
        bool? Disable = null,
        string? Domain = null,
        string? EncryptionKey = null,
        string? Export = null,
        string? Fingerprint = null,
        string? Format = null,
        bool? Fuse = null,
        string? IsMountPoint = null,
        string? IscsiProvider = null,
        bool? Krbd = null,
        string? LioTpg = null,
        string? MasterPubKey = null,
        int? MaxFiles = null,
        bool? Mkdir = null,
        string? MonHost = null,
        string? MountPoint = null,
        string? Namespace = null,
        bool? NoCow = null,
        string? Nodes = null,
        bool? NoWriteCache = null,
        string? Options = null,
        string? Password = null,
        string? Path = null,
        string? Pool = null,
        int? Port = null,
        string? Portal = null,
        string? PruneBackups = null,
        bool? SafeRemove = null,
        string? SafeRemoveThroughput = null,
        string? Server = null,
        string? Server2 = null,
        string? Share = null,
        bool? Shared = null,
        SmbVersion? SmbVersion = null,
        bool? SParse = null,
        string? SubDir = null,
        bool? TaggedOnly = null,
        string? Target = null,
        string? ThinPool = null,
        GlusterTransport? Transport = null,
        string? Username = null,
        string? VgName = null,
        string? Volume = null);
}
