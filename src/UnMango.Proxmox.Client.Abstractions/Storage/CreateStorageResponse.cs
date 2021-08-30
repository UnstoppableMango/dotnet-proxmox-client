using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Storage
{
    [PublicAPI]
    public record CreateStorageResponse(
        string Storage,
        StorageType Type,
        object? Config);
}
