
#nullable enable

namespace GitHub
{
    public partial class CodeSecurityClient
    {
        partial void PrepareCodeSecuritySetConfigurationAsDefaultArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int configurationId,
            global::GitHub.CodeSecuritySetConfigurationAsDefaultRequest request);
        partial void PrepareCodeSecuritySetConfigurationAsDefaultRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int configurationId,
            global::GitHub.CodeSecuritySetConfigurationAsDefaultRequest request);
        partial void ProcessCodeSecuritySetConfigurationAsDefaultResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeSecuritySetConfigurationAsDefaultResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Set a code security configuration as a default for an organization<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your organization.<br/>
        /// This configuration will be applied to the matching repository type (all, none, public, private and internal) by default when they are created.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CodeSecuritySetConfigurationAsDefaultResponse> CodeSecuritySetConfigurationAsDefaultAsync(
            string org,
            int configurationId,
            global::GitHub.CodeSecuritySetConfigurationAsDefaultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCodeSecuritySetConfigurationAsDefaultArguments(
                httpClient: HttpClient,
                org: ref org,
                configurationId: ref configurationId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/code-security/configurations/{configurationId}/defaults",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareCodeSecuritySetConfigurationAsDefaultRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                configurationId: configurationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodeSecuritySetConfigurationAsDefaultResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCodeSecuritySetConfigurationAsDefaultResponseContent(
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
                global::GitHub.CodeSecuritySetConfigurationAsDefaultResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set a code security configuration as a default for an organization<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your organization.<br/>
        /// This configuration will be applied to the matching repository type (all, none, public, private and internal) by default when they are created.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="defaultForNewRepos">
        /// Specify which types of repository this security configuration should be applied to by default.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CodeSecuritySetConfigurationAsDefaultResponse> CodeSecuritySetConfigurationAsDefaultAsync(
            string org,
            int configurationId,
            global::GitHub.CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos? defaultForNewRepos = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.CodeSecuritySetConfigurationAsDefaultRequest
            {
                DefaultForNewRepos = defaultForNewRepos,
            };

            return await CodeSecuritySetConfigurationAsDefaultAsync(
                org: org,
                configurationId: configurationId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}