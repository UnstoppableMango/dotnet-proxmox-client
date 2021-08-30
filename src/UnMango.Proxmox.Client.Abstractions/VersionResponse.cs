using JetBrains.Annotations;

namespace UnMango.Proxmox.Client
{
    [PublicAPI]
    public record VersionResponse(
        string Release,
        string RepoId,
        string Version);
}
