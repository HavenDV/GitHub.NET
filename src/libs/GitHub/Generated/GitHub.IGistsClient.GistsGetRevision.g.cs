#nullable enable

namespace GitHub
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Get a gist revision<br/>
        /// Gets a specified gist revision.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.base64+json`**: Returns the base64-encoded contents. This can be useful if your gist contains any invalid UTF-8 sequences.
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="sha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.GistSimple> GistsGetRevisionAsync(
            string gistId,
            string sha,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}