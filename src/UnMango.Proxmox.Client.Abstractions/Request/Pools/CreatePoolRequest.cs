using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Request.Pools
{
    [PublicAPI]
    public record CreatePoolRequest(string PoolId)
    {
        public string? Comment { get; init; }
    }
}
