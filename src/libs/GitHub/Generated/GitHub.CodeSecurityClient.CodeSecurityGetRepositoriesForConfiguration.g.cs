
#nullable enable

namespace GitHub
{
    public partial class CodeSecurityClient
    {
        partial void PrepareCodeSecurityGetRepositoriesForConfigurationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int configurationId,
            ref int? perPage,
            ref string? before,
            ref string? after,
            ref string? status);
        partial void PrepareCodeSecurityGetRepositoriesForConfigurationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int configurationId,
            int? perPage,
            string? before,
            string? after,
            string? status);
        partial void ProcessCodeSecurityGetRepositoriesForConfigurationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeSecurityGetRepositoriesForConfigurationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get repositories associated with a code security configuration<br/>
        /// Lists the repositories associated with a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="status">
        /// Default Value: all
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CodeSecurityConfigurationRepositories>> CodeSecurityGetRepositoriesForConfigurationAsync(
            string org,
            int configurationId,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCodeSecurityGetRepositoriesForConfigurationArguments(
                httpClient: HttpClient,
                org: ref org,
                configurationId: ref configurationId,
                perPage: ref perPage,
                before: ref before,
                after: ref after,
                status: ref status);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/code-security/configurations/{configurationId}/repositories",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("status", status) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCodeSecurityGetRepositoriesForConfigurationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                configurationId: configurationId,
                perPage: perPage,
                before: before,
                after: after,
                status: status);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodeSecurityGetRepositoriesForConfigurationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCodeSecurityGetRepositoriesForConfigurationResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.CodeSecurityConfigurationRepositories>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.CodeSecurityConfigurationRepositories> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}