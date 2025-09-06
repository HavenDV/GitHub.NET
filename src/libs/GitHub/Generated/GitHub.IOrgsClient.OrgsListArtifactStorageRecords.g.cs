#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List artifact storage records<br/>
        /// List a collection of artifact storage records with a given subject digest that are associated with repositories owned by an organization.<br/>
        /// The collection of storage records returned by this endpoint is filtered according to the authenticated user's permissions; if the authenticated user cannot read a repository, the attestations associated with that repository will not be included in the response. In addition, when using a fine-grained access token the `content:read` permission is required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="subjectDigest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OrgsListArtifactStorageRecordsResponse> OrgsListArtifactStorageRecordsAsync(
            string org,
            string subjectDigest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}