#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get a release asset<br/>
        /// To download the asset's binary content:<br/>
        /// - If within a browser, fetch the location specified in the `browser_download_url` key provided in the response.<br/>
        /// - Alternatively, set the `Accept` header of the request to <br/>
        ///   [`application/octet-stream`](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types). <br/>
        ///   The API will either redirect the client to the location, or stream it directly if possible.<br/>
        ///   API clients should handle both a `200` or `302` response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ReleaseAsset> ReposGetReleaseAssetAsync(
            string owner,
            string repo,
            int assetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}