using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Abstractions.Response
{
    [PublicAPI]
    public record VersionResponse(
        string Release,
        string RepoId,
        string Version);
}
