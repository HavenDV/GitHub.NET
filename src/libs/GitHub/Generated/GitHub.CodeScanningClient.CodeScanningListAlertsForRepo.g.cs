
#nullable enable

namespace GitHub
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningListAlertsForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? toolName,
            ref string? toolGuid,
            ref int? page,
            ref int? perPage,
            ref string? @ref,
            ref int? pr,
            ref global::GitHub.CodeScanningListAlertsForRepoDirection? direction,
            ref string? before,
            ref string? after,
            ref global::GitHub.CodeScanningListAlertsForRepoSort? sort,
            ref global::GitHub.CodeScanningAlertStateQuery? state,
            ref global::GitHub.CodeScanningAlertSeverity? severity);
        partial void PrepareCodeScanningListAlertsForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? toolName,
            string? toolGuid,
            int? page,
            int? perPage,
            string? @ref,
            int? pr,
            global::GitHub.CodeScanningListAlertsForRepoDirection? direction,
            string? before,
            string? after,
            global::GitHub.CodeScanningListAlertsForRepoSort? sort,
            global::GitHub.CodeScanningAlertStateQuery? state,
            global::GitHub.CodeScanningAlertSeverity? severity);
        partial void ProcessCodeScanningListAlertsForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningListAlertsForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List code scanning alerts for a repository<br/>
        /// Lists code scanning alerts.<br/>
        /// The response includes a `most_recent_instance` object.<br/>
        /// This provides details of the most recent instance of this alert<br/>
        /// for the default branch (or for the specified Git reference if you used `ref` in the request).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="toolName">
        /// The name of the tool used to generate the code scanning analysis.
        /// </param>
        /// <param name="toolGuid">
        /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="ref">
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </param>
        /// <param name="pr"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        /// <param name="severity">
        /// Severity of a code scanning alert.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CodeScanningAlertItems>> CodeScanningListAlertsForRepoAsync(
            string owner,
            string repo,
            string? toolName = default,
            string? toolGuid = default,
            int? page = default,
            int? perPage = default,
            string? @ref = default,
            int? pr = default,
            global::GitHub.CodeScanningListAlertsForRepoDirection? direction = default,
            string? before = default,
            string? after = default,
            global::GitHub.CodeScanningListAlertsForRepoSort? sort = default,
            global::GitHub.CodeScanningAlertStateQuery? state = default,
            global::GitHub.CodeScanningAlertSeverity? severity = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCodeScanningListAlertsForRepoArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                toolName: ref toolName,
                toolGuid: ref toolGuid,
                page: ref page,
                perPage: ref perPage,
                @ref: ref @ref,
                pr: ref pr,
                direction: ref direction,
                before: ref before,
                after: ref after,
                sort: ref sort,
                state: ref state,
                severity: ref severity);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/code-scanning/alerts",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("tool_name", toolName) 
                .AddOptionalParameter("tool_guid", toolGuid) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("ref", @ref) 
                .AddOptionalParameter("pr", pr?.ToString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("state", state?.ToValueString()) 
                .AddOptionalParameter("severity", severity?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCodeScanningListAlertsForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                toolName: toolName,
                toolGuid: toolGuid,
                page: page,
                perPage: perPage,
                @ref: @ref,
                pr: pr,
                direction: direction,
                before: before,
                after: after,
                sort: sort,
                state: state,
                severity: severity);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodeScanningListAlertsForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCodeScanningListAlertsForRepoResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.CodeScanningAlertItems>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.CodeScanningAlertItems> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}