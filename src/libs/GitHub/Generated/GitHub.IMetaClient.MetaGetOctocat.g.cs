#nullable enable

namespace GitHub
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get Octocat<br/>
        /// Get the octocat as ASCII art
        /// </summary>
        /// <param name="s"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetaGetOctocatAsync(
            string? s = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}