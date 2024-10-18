#nullable enable

namespace GitHub
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Check if a gist is starred
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.GistsCheckIsStarredResponse> GistsCheckIsStarredAsync(
            string gistId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}