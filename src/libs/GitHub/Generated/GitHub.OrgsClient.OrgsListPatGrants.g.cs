using System.Linq;

#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListPatGrantsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int perPage,
            ref int page,
            ref global::GitHub.OrgsListPatGrantsSort? sort,
            ref global::GitHub.OrgsListPatGrantsDirection? direction,
            global::System.Collections.Generic.IList<string>? owner,
            ref string? repository,
            ref string? permission,
            global::System.DateTime lastUsedBefore,
            global::System.DateTime lastUsedAfter);
        partial void PrepareOrgsListPatGrantsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int perPage,
            int page,
            global::GitHub.OrgsListPatGrantsSort? sort,
            global::GitHub.OrgsListPatGrantsDirection? direction,
            global::System.Collections.Generic.IList<string>? owner,
            string? repository,
            string? permission,
            global::System.DateTime lastUsedBefore,
            global::System.DateTime lastUsedAfter);
        partial void ProcessOrgsListPatGrantsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListPatGrantsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List fine-grained personal access tokens with access to organization resources<br/>
        /// Lists approved fine-grained personal access tokens owned by organization members that can access organization resources.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="owner">
        /// Example: owner[]=octocat1,owner[]=octocat2
        /// </param>
        /// <param name="repository">
        /// Example: Hello-World
        /// </param>
        /// <param name="permission">
        /// Example: issues_read
        /// </param>
        /// <param name="lastUsedBefore"></param>
        /// <param name="lastUsedAfter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.BasicError> OrgsListPatGrantsAsync(
            string org,
            int perPage = 30,
            int page = 1,
            global::GitHub.OrgsListPatGrantsSort? sort = global::GitHub.OrgsListPatGrantsSort.CreatedAt,
            global::GitHub.OrgsListPatGrantsDirection? direction = global::GitHub.OrgsListPatGrantsDirection.Desc,
            global::System.Collections.Generic.IList<string>? owner = default,
            string? repository = default,
            string? permission = default,
            global::System.DateTime lastUsedBefore = default,
            global::System.DateTime lastUsedAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOrgsListPatGrantsArguments(
                httpClient: _httpClient,
                org: ref org,
                perPage: ref perPage,
                page: ref page,
                sort: ref sort,
                direction: ref direction,
                owner: owner,
                repository: ref repository,
                permission: ref permission,
                lastUsedBefore: lastUsedBefore,
                lastUsedAfter: lastUsedAfter);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/personal-access-tokens?per_page={perPage}&page={page}&sort={(global::System.Uri.EscapeDataString(sort?.ToValueString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(direction?.ToValueString() ?? string.Empty))}&{string.Join("&", owner?.Select(static x => $"owner={x}") ?? global::System.Array.Empty<string>())}&repository={repository}&permission={permission}&last_used_before={lastUsedBefore:yyyy-MM-ddTHH:mm:ssZ}&last_used_after={lastUsedAfter:yyyy-MM-ddTHH:mm:ssZ}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsListPatGrantsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                perPage: perPage,
                page: page,
                sort: sort,
                direction: direction,
                owner: owner,
                repository: repository,
                permission: permission,
                lastUsedBefore: lastUsedBefore,
                lastUsedAfter: lastUsedAfter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsListPatGrantsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsListPatGrantsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.BasicError) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}