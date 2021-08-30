using System.Collections.Generic;
using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Pools
{
    [PublicAPI]
    public record GetPoolResponse(IEnumerable<object> Members)
    {
        public string? Comment { get; init; }
    }
}
