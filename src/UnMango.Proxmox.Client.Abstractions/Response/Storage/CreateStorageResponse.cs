using JetBrains.Annotations;
using UnMango.Proxmox.Client.Storage;

namespace UnMango.Proxmox.Client.Response.Storage
{
    [PublicAPI]
    public record CreateStorageResponse(
        string Storage,
        StorageType Type,
        object? Config);
}
