using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Response
{
    [PublicAPI]
    public record VersionResponse(
        string Release,
        string RepoId,
        string Version);
}
