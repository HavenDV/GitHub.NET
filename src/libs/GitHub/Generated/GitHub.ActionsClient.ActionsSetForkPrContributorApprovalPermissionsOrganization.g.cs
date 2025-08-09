
#nullable enable

namespace GitHub
{
    public partial class ActionsClient
    {
        partial void PrepareActionsSetForkPrContributorApprovalPermissionsOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::GitHub.ActionsForkPrContributorApproval request);
        partial void PrepareActionsSetForkPrContributorApprovalPermissionsOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.ActionsForkPrContributorApproval request);
        partial void ProcessActionsSetForkPrContributorApprovalPermissionsOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set fork PR contributor approval permissions for an organization<br/>
        /// Sets the fork PR contributor approval policy for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetForkPrContributorApprovalPermissionsOrganizationAsync(
            string org,
            global::GitHub.ActionsForkPrContributorApproval request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsSetForkPrContributorApprovalPermissionsOrganizationArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new global::GitHub.PathBuilder(
                path: $"/orgs/{org}/actions/permissions/fork-pr-contributor-approval",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareActionsSetForkPrContributorApprovalPermissionsOrganizationRequest(
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
            ProcessActionsSetForkPrContributorApprovalPermissionsOrganizationResponse(
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
                global::GitHub.ValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::GitHub.ValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::GitHub.ValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::GitHub.ApiException<global::GitHub.ValidationError>(
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
        /// Set fork PR contributor approval permissions for an organization<br/>
        /// Sets the fork PR contributor approval policy for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="approvalPolicy">
        /// The policy that controls when fork PR workflows require approval from a maintainer.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetForkPrContributorApprovalPermissionsOrganizationAsync(
            string org,
            global::GitHub.ActionsForkPrContributorApprovalApprovalPolicy approvalPolicy,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.ActionsForkPrContributorApproval
            {
                ApprovalPolicy = approvalPolicy,
            };

            await ActionsSetForkPrContributorApprovalPermissionsOrganizationAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}