
#nullable enable

namespace GitHub
{
    public partial class SearchClient
    {
        partial void PrepareSearchCodeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string q,
            ref global::GitHub.SearchCodeSort? sort,
            ref global::GitHub.SearchCodeOrder? order,
            ref int? perPage,
            ref int? page);
        partial void PrepareSearchCodeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string q,
            global::GitHub.SearchCodeSort? sort,
            global::GitHub.SearchCodeOrder? order,
            int? perPage,
            int? page);
        partial void ProcessSearchCodeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchCodeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search code<br/>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:<br/>
        /// `q=addClass+in:file+language:js+repo:jquery/jquery`<br/>
        /// This query searches for the keyword `addClass` within a file's contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.<br/>
        /// Considerations for code search:<br/>
        /// Due to the complexity of searching code, there are a few restrictions on how searches are performed:<br/>
        /// *   Only the _default branch_ is considered. In most cases, this will be the `master` branch.<br/>
        /// *   Only files smaller than 384 KB are searchable.<br/>
        /// *   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazing<br/>
        /// language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.<br/>
        /// This endpoint requires you to authenticate and limits you to 10 requests per minute.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.SearchCodeResponse> SearchCodeAsync(
            string q,
            global::GitHub.SearchCodeSort? sort = default,
            global::GitHub.SearchCodeOrder? order = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSearchCodeArguments(
                httpClient: HttpClient,
                q: ref q,
                sort: ref sort,
                order: ref order,
                perPage: ref perPage,
                page: ref page);

            var __pathBuilder = new PathBuilder(
                path: "/search/code",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("q", q) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("order", order?.ToValueString()) 
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
            PrepareSearchCodeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                q: q,
                sort: sort,
                order: order,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSearchCodeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessSearchCodeResponseContent(
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
                global::GitHub.SearchCodeResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}