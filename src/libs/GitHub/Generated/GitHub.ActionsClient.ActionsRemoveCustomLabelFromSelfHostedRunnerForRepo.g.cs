
#nullable enable

namespace GitHub
{
    public partial class ActionsClient
    {
        partial void PrepareActionsRemoveCustomLabelFromSelfHostedRunnerForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int runnerId,
            ref string name);
        partial void PrepareActionsRemoveCustomLabelFromSelfHostedRunnerForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int runnerId,
            string name);
        partial void ProcessActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove a custom label from a self-hosted runner for a repository<br/>
        /// Remove a custom label from a self-hosted runner configured<br/>
        /// in a repository. Returns the remaining labels from the runner.<br/>
        /// This endpoint returns a `404 Not Found` status if the custom label is not<br/>
        /// present on the runner.<br/>
        /// Authenticated users must have admin access to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponse> ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsRemoveCustomLabelFromSelfHostedRunnerForRepoArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                runnerId: ref runnerId,
                name: ref name);

            var __pathBuilder = new global::GitHub.PathBuilder(
                path: $"/repos/{owner}/{repo}/actions/runners/{runnerId}/labels/{name}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsRemoveCustomLabelFromSelfHostedRunnerForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                runnerId: runnerId,
                name: name);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
            // Validation failed, or the endpoint has been spammed.
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::GitHub.ValidationErrorSimple? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::GitHub.ValidationErrorSimple.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::GitHub.ValidationErrorSimple.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::GitHub.ApiException<global::GitHub.ValidationErrorSimple>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
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
                ProcessActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::GitHub.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::GitHub.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}