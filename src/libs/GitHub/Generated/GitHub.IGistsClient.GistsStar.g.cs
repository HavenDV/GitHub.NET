#nullable enable

namespace GitHub
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Star a gist<br/>
        /// Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> GistsStarAsync(
            string gistId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}