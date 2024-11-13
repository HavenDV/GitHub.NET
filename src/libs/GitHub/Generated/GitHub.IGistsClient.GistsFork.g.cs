#nullable enable

namespace GitHub
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Fork a gist
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BaseGist> GistsForkAsync(
            string gistId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}