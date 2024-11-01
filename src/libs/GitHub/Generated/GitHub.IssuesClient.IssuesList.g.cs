
#nullable enable

namespace GitHub
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::GitHub.IssuesListFilter? filter,
            ref global::GitHub.IssuesListState? state,
            ref string? labels,
            ref global::GitHub.IssuesListSort? sort,
            ref global::GitHub.IssuesListDirection? direction,
            ref global::System.DateTime? since,
            ref bool? collab,
            ref bool? orgs,
            ref bool? owned,
            ref bool? pulls,
            ref int? perPage,
            ref int? page);
        partial void PrepareIssuesListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::GitHub.IssuesListFilter? filter,
            global::GitHub.IssuesListState? state,
            string? labels,
            global::GitHub.IssuesListSort? sort,
            global::GitHub.IssuesListDirection? direction,
            global::System.DateTime? since,
            bool? collab,
            bool? orgs,
            bool? owned,
            bool? pulls,
            int? perPage,
            int? page);
        partial void ProcessIssuesListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List issues assigned to the authenticated user<br/>
        /// List issues assigned to the authenticated user across all visible repositories including owned repositories, member<br/>
        /// repositories, and organization repositories. You can use the `filter` query parameter to fetch issues that are not<br/>
        /// necessarily assigned to you.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; GitHub's REST API considers every pull request an issue, but not every issue is a pull request. For this reason, "Issues" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from "Issues" endpoints will be an _issue id_. To find out the pull request id, use the "[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)" endpoint.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="filter">
        /// Default Value: assigned
        /// </param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="labels"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="since"></param>
        /// <param name="collab"></param>
        /// <param name="orgs"></param>
        /// <param name="owned"></param>
        /// <param name="pulls"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Issue>> IssuesListAsync(
            global::GitHub.IssuesListFilter? filter = default,
            global::GitHub.IssuesListState? state = default,
            string? labels = default,
            global::GitHub.IssuesListSort? sort = default,
            global::GitHub.IssuesListDirection? direction = default,
            global::System.DateTime? since = default,
            bool? collab = default,
            bool? orgs = default,
            bool? owned = default,
            bool? pulls = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareIssuesListArguments(
                httpClient: HttpClient,
                filter: ref filter,
                state: ref state,
                labels: ref labels,
                sort: ref sort,
                direction: ref direction,
                since: ref since,
                collab: ref collab,
                orgs: ref orgs,
                owned: ref owned,
                pulls: ref pulls,
                perPage: ref perPage,
                page: ref page);

            var __pathBuilder = new PathBuilder(
                path: "/issues",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("filter", filter?.ToValueString()) 
                .AddOptionalParameter("state", state?.ToValueString()) 
                .AddOptionalParameter("labels", labels) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("collab", collab?.ToString()) 
                .AddOptionalParameter("orgs", orgs?.ToString()) 
                .AddOptionalParameter("owned", owned?.ToString()) 
                .AddOptionalParameter("pulls", pulls?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareIssuesListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                filter: filter,
                state: state,
                labels: labels,
                sort: sort,
                direction: direction,
                since: since,
                collab: collab,
                orgs: orgs,
                owned: owned,
                pulls: pulls,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessIssuesListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessIssuesListResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.Issue>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.Issue> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}