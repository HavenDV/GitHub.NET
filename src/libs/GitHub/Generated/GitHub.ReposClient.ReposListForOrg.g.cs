
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposListForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref global::GitHub.ReposListForOrgType? type,
            ref global::GitHub.ReposListForOrgSort? sort,
            ref global::GitHub.ReposListForOrgDirection? direction,
            ref int perPage,
            ref int page);
        partial void PrepareReposListForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.ReposListForOrgType? type,
            global::GitHub.ReposListForOrgSort? sort,
            global::GitHub.ReposListForOrgDirection? direction,
            int perPage,
            int page);
        partial void ProcessReposListForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organization repositories<br/>
        /// Lists repositories for the specified organization.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.MinimalRepository>> ReposListForOrgAsync(
            string org,
            global::GitHub.ReposListForOrgType? type = global::GitHub.ReposListForOrgType.All,
            global::GitHub.ReposListForOrgSort? sort = global::GitHub.ReposListForOrgSort.Created,
            global::GitHub.ReposListForOrgDirection? direction = default,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposListForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                type: ref type,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/repos?type={(global::System.Uri.EscapeDataString(type?.ToValueString() ?? string.Empty))}&sort={(global::System.Uri.EscapeDataString(sort?.ToValueString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(direction?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposListForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                type: type,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposListForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposListForOrgResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.IListMinimalRepository) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}