
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCreateArtifactStorageRecordArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::GitHub.OrgsCreateArtifactStorageRecordRequest request);
        partial void PrepareOrgsCreateArtifactStorageRecordRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.OrgsCreateArtifactStorageRecordRequest request);
        partial void ProcessOrgsCreateArtifactStorageRecordResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsCreateArtifactStorageRecordResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create artifact metadata storage record<br/>
        /// Create metadata storage records for artifacts associated with an organization.<br/>
        /// This endpoint will create a new artifact storage record on behalf of any artifact matching the provided digest and<br/>
        /// associated with a repository owned by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.OrgsCreateArtifactStorageRecordResponse> OrgsCreateArtifactStorageRecordAsync(
            string org,
            global::GitHub.OrgsCreateArtifactStorageRecordRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrgsCreateArtifactStorageRecordArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new global::GitHub.PathBuilder(
                path: $"/orgs/{org}/artifacts/metadata/storage-record",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsCreateArtifactStorageRecordRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsCreateArtifactStorageRecordResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessOrgsCreateArtifactStorageRecordResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::GitHub.OrgsCreateArtifactStorageRecordResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::GitHub.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::GitHub.OrgsCreateArtifactStorageRecordResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::GitHub.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Create artifact metadata storage record<br/>
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
        public async global::System.Threading.Tasks.Task<global::GitHub.OrgsCreateArtifactStorageRecordResponse> OrgsCreateArtifactStorageRecordAsync(
            string org,
            string name,
            string digest,
            string registryUrl,
            string? artifactUrl = default,
            string? path = default,
            string? repository = default,
            global::GitHub.OrgsCreateArtifactStorageRecordRequestStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.OrgsCreateArtifactStorageRecordRequest
            {
                Name = name,
                Digest = digest,
                ArtifactUrl = artifactUrl,
                Path = path,
                RegistryUrl = registryUrl,
                Repository = repository,
                Status = status,
            };

            return await OrgsCreateArtifactStorageRecordAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}