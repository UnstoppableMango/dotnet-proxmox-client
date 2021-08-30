using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Nodes
{
    [PublicAPI]
    public enum NodeStatus
    {
        Unknown,
        Online,
        Offline,
    }
}
