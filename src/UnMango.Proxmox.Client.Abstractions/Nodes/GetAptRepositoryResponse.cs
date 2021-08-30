using System.Collections.Generic;
using JetBrains.Annotations;

namespace UnMango.Proxmox.Client.Nodes
{
    [PublicAPI]
    public record GetAptRepositoryResponse(
        string Digest,
        IEnumerable<ErrorResponse> Errors,
        IEnumerable<object> Files,
        IEnumerable<object> Infos,
        IEnumerable<object> StandardRepos);

    [PublicAPI]
    public record ErrorResponse(string Error, string Path);

    [PublicAPI]
    public record FilesResponse(IEnumerable<int> Digest, FileType FileType, string Path);

    [PublicAPI]
    public enum FileType
    {
        List,
        Sources,
    }

    [PublicAPI]
    public record OptionsResponse(string Key, IEnumerable<string> Values);

    [PublicAPI]
    public record RepositoriesResponse(
        bool Enabled,
        FileType FileType,
        IEnumerable<string> Suites)
    {
        public string? Comment { get; init; }

        public IEnumerable<string>? Components { get; init; }
        
        public IEnumerable<OptionsResponse>? Options { get; init; }
    }
}
