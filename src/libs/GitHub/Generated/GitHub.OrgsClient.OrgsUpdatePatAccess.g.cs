
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsUpdatePatAccessArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int patId,
            global::GitHub.OrgsUpdatePatAccessRequest request);
        partial void PrepareOrgsUpdatePatAccessRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int patId,
            global::GitHub.OrgsUpdatePatAccessRequest request);
        partial void ProcessOrgsUpdatePatAccessResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsUpdatePatAccessResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update the access a fine-grained personal access token has to organization resources<br/>
        /// Updates the access an organization member has to organization resources via a fine-grained personal access token. Limited to revoking the token's existing access. Limited to revoking a token's existing access.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.BasicError> OrgsUpdatePatAccessAsync(
            string org,
            int patId,
            global::GitHub.OrgsUpdatePatAccessRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrgsUpdatePatAccessArguments(
                httpClient: HttpClient,
                org: ref org,
                patId: ref patId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/personal-access-tokens/{patId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsUpdatePatAccessRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                patId: patId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsUpdatePatAccessResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsUpdatePatAccessResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::GitHub.BasicError.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update the access a fine-grained personal access token has to organization resources<br/>
        /// Updates the access an organization member has to organization resources via a fine-grained personal access token. Limited to revoking the token's existing access. Limited to revoking a token's existing access.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patId"></param>
        /// <param name="action">
        /// Action to apply to the fine-grained personal access token.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.BasicError> OrgsUpdatePatAccessAsync(
            string org,
            int patId,
            global::GitHub.OrgsUpdatePatAccessRequestAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.OrgsUpdatePatAccessRequest
            {
                Action = action,
            };

            return await OrgsUpdatePatAccessAsync(
                org: org,
                patId: patId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}