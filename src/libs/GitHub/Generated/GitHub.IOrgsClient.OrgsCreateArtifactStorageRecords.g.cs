#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create artifact metadata storage records<br/>
        /// Create metadata storage records for artifacts associated with an organization.<br/>
        /// This endpoint will create a new artifact storage record on behalf of any artifact matching the provided digest and<br/>
        /// associated with a repository owned by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OrgsCreateArtifactStorageRecordsResponse> OrgsCreateArtifactStorageRecordsAsync(
            string org,
            global::GitHub.OrgsCreateArtifactStorageRecordsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create artifact metadata storage records<br/>
        /// Create metadata storage records for artifacts associated with an organization.<br/>
        /// This endpoint will create a new artifact storage record on behalf of any artifact matching the provided digest and<br/>
        /// associated with a repository owned by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: libfoo-1.2.3
        /// </param>
        /// <param name="digest">
        /// The digest of the artifact (algorithm:hex-encoded-digest).<br/>
        /// Example: sha256:0ecbaa601dba202129058746c7d8e3f282d0efb5fff0...
        /// </param>
        /// <param name="artifactUrl">
        /// The URL where the artifact is stored.<br/>
        /// Example: https://reg.example.com/artifactory/bar/libfoo-1.2.3
        /// </param>
        /// <param name="path">
        /// The path of the artifact.<br/>
        /// Example: com/github/bar/libfoo-1.2.3
        /// </param>
        /// <param name="registryUrl">
        /// The base URL of the artifact registry.<br/>
        /// Example: https://reg.example.com/artifactory/
        /// </param>
        /// <param name="repository">
        /// The repository name within the registry.<br/>
        /// Example: bar
        /// </param>
        /// <param name="status">
        /// The status of the artifact (e.g., active, inactive).<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OrgsCreateArtifactStorageRecordsResponse> OrgsCreateArtifactStorageRecordsAsync(
            string org,
            string name,
            string digest,
            string registryUrl,
            string? artifactUrl = default,
            string? path = default,
            string? repository = default,
            global::GitHub.OrgsCreateArtifactStorageRecordsRequestStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}