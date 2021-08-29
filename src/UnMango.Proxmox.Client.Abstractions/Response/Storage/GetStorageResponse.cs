using JetBrains.Annotations;
using UnMango.Proxmox.Client.Storage;

namespace UnMango.Proxmox.Client.Response.Storage
{
    [PublicAPI]
    public record GetStorageResponseBase(
        string Content,
        string Digest,
        string Storage,
        StorageType Type);

    [PublicAPI]
    public record GetStorageResponseDir(
        string Content,
        string Digest,
        string Nodes,
        string Path,
        string PruneBackups,
        int Shared,
        string Storage) : GetStorageResponseBase(Content, Digest, Storage, StorageType.Dir);

    [PublicAPI]
    public record GetStorageResponseLvmThin(
        string Content,
        string Digest,
        string Storage,
        string ThinPool,
        string VgName) : GetStorageResponseBase(Content, Digest, Storage, StorageType.LvmThin);

    [PublicAPI]
    public record GetStorageResponseNfs(
        string Content,
        string Digest,
        string Export,
        string Path,
        string Server,
        int Shared,
        string Storage) : GetStorageResponseBase(Content, Digest, Storage, StorageType.Nfs);

    [PublicAPI]
    public record GetStorageResponseZfsPool(
        string Content,
        string Digest,
        string MountPoint,
        string Nodes,
        string Pool,
        int Sparse,
        string Storage) : GetStorageResponseBase(Content, Digest, Storage, StorageType.ZfsPool);
}
