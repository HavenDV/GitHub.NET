
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListCustomPropertiesValuesForReposArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int perPage,
            ref int page,
            ref string? repositoryQuery);
        partial void PrepareOrgsListCustomPropertiesValuesForReposRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int perPage,
            int page,
            string? repositoryQuery);
        partial void ProcessOrgsListCustomPropertiesValuesForReposResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListCustomPropertiesValuesForReposResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List custom property values for organization repositories<br/>
        /// Lists organization repositories with all of their custom property values.<br/>
        /// Organization members can read these properties.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="repositoryQuery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.OrgRepoCustomPropertyValues>> OrgsListCustomPropertiesValuesForReposAsync(
            string org,
            int perPage = 30,
            int page = 1,
            string? repositoryQuery = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOrgsListCustomPropertiesValuesForReposArguments(
                httpClient: _httpClient,
                org: ref org,
                perPage: ref perPage,
                page: ref page,
                repositoryQuery: ref repositoryQuery);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/properties/values?per_page={perPage}&page={page}&repository_query={repositoryQuery}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsListCustomPropertiesValuesForReposRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                perPage: perPage,
                page: page,
                repositoryQuery: repositoryQuery);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsListCustomPropertiesValuesForReposResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsListCustomPropertiesValuesForReposResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.IListOrgRepoCustomPropertyValues) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}