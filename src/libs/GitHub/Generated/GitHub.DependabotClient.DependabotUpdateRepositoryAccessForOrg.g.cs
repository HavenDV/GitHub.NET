
#nullable enable

namespace GitHub
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotUpdateRepositoryAccessForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::GitHub.DependabotUpdateRepositoryAccessForOrgRequest request);
        partial void PrepareDependabotUpdateRepositoryAccessForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.DependabotUpdateRepositoryAccessForOrgRequest request);
        partial void ProcessDependabotUpdateRepositoryAccessForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Updates Dependabot's repository access list for an organization<br/>
        /// Updates repositories according to the list of repositories that organization admins have given Dependabot access to when they've updated dependencies.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt;    This operation supports both server-to-server and user-to-server access.<br/>
        /// Unauthorized users will not see the existence of this endpoint.<br/>
        /// **Example request body:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "repository_ids_to_add": [123, 456],<br/>
        ///   "repository_ids_to_remove": [789]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task DependabotUpdateRepositoryAccessForOrgAsync(
            string org,
            global::GitHub.DependabotUpdateRepositoryAccessForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDependabotUpdateRepositoryAccessForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new global::GitHub.PathBuilder(
                path: $"/organizations/{org}/dependabot/repository-access",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareDependabotUpdateRepositoryAccessForOrgRequest(
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
            ProcessDependabotUpdateRepositoryAccessForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::GitHub.BasicError? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::GitHub.BasicError.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = await global::GitHub.BasicError.FromJsonStreamAsync(__contentStream_403, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::GitHub.ApiException<global::GitHub.BasicError>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Resource not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::GitHub.BasicError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::GitHub.BasicError.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = await global::GitHub.BasicError.FromJsonStreamAsync(__contentStream_404, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::GitHub.ApiException<global::GitHub.BasicError>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Updates Dependabot's repository access list for an organization<br/>
        /// Updates repositories according to the list of repositories that organization admins have given Dependabot access to when they've updated dependencies.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt;    This operation supports both server-to-server and user-to-server access.<br/>
        /// Unauthorized users will not see the existence of this endpoint.<br/>
        /// **Example request body:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "repository_ids_to_add": [123, 456],<br/>
        ///   "repository_ids_to_remove": [789]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryIdsToAdd">
        /// List of repository IDs to add.
        /// </param>
        /// <param name="repositoryIdsToRemove">
        /// List of repository IDs to remove.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DependabotUpdateRepositoryAccessForOrgAsync(
            string org,
            global::System.Collections.Generic.IList<int>? repositoryIdsToAdd = default,
            global::System.Collections.Generic.IList<int>? repositoryIdsToRemove = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.DependabotUpdateRepositoryAccessForOrgRequest
            {
                RepositoryIdsToAdd = repositoryIdsToAdd,
                RepositoryIdsToRemove = repositoryIdsToRemove,
            };

            await DependabotUpdateRepositoryAccessForOrgAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}