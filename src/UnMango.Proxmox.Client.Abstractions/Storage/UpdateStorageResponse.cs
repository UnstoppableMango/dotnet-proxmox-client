using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Storage
{
    [PublicAPI]
    public record UpdateStorageResponse(
        string Storage,
        StorageType Type,
        object? Config = null);
}
