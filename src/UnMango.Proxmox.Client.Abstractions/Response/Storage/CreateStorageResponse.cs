using JetBrains.Annotations;
using UnMango.Proxmox.Client.Abstractions.Storage;

namespace UnMango.Proxmox.Client.Abstractions.Response.Storage
{
    [PublicAPI]
    public record CreateStorageResponse(
        string Storage,
        StorageType Type,
        object? Config);
}
