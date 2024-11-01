
#nullable enable

namespace GitHub
{
    public partial class SecretScanningClient
    {
        partial void PrepareSecretScanningListAlertsForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref global::GitHub.SecretScanningListAlertsForOrgState? state,
            ref string? secretType,
            ref string? resolution,
            ref global::GitHub.SecretScanningListAlertsForOrgSort? sort,
            ref global::GitHub.SecretScanningListAlertsForOrgDirection? direction,
            ref int? page,
            ref int? perPage,
            ref string? before,
            ref string? after,
            ref string? validity,
            ref bool? isPubliclyLeaked,
            ref bool? isMultiRepo);
        partial void PrepareSecretScanningListAlertsForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.SecretScanningListAlertsForOrgState? state,
            string? secretType,
            string? resolution,
            global::GitHub.SecretScanningListAlertsForOrgSort? sort,
            global::GitHub.SecretScanningListAlertsForOrgDirection? direction,
            int? page,
            int? perPage,
            string? before,
            string? after,
            string? validity,
            bool? isPubliclyLeaked,
            bool? isMultiRepo);
        partial void ProcessSecretScanningListAlertsForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecretScanningListAlertsForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List secret scanning alerts for an organization<br/>
        /// Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="isPubliclyLeaked">
        /// Default Value: false
        /// </param>
        /// <param name="isMultiRepo">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.OrganizationSecretScanningAlert>> SecretScanningListAlertsForOrgAsync(
            string org,
            global::GitHub.SecretScanningListAlertsForOrgState? state = default,
            string? secretType = default,
            string? resolution = default,
            global::GitHub.SecretScanningListAlertsForOrgSort? sort = default,
            global::GitHub.SecretScanningListAlertsForOrgDirection? direction = default,
            int? page = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? validity = default,
            bool? isPubliclyLeaked = default,
            bool? isMultiRepo = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSecretScanningListAlertsForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                state: ref state,
                secretType: ref secretType,
                resolution: ref resolution,
                sort: ref sort,
                direction: ref direction,
                page: ref page,
                perPage: ref perPage,
                before: ref before,
                after: ref after,
                validity: ref validity,
                isPubliclyLeaked: ref isPubliclyLeaked,
                isMultiRepo: ref isMultiRepo);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/secret-scanning/alerts",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("state", state?.ToValueString()) 
                .AddOptionalParameter("secret_type", secretType) 
                .AddOptionalParameter("resolution", resolution) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("validity", validity) 
                .AddOptionalParameter("is_publicly_leaked", isPubliclyLeaked?.ToString()) 
                .AddOptionalParameter("is_multi_repo", isMultiRepo?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSecretScanningListAlertsForOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                state: state,
                secretType: secretType,
                resolution: resolution,
                sort: sort,
                direction: direction,
                page: page,
                perPage: perPage,
                before: before,
                after: after,
                validity: validity,
                isPubliclyLeaked: isPubliclyLeaked,
                isMultiRepo: isMultiRepo);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSecretScanningListAlertsForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessSecretScanningListAlertsForOrgResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.OrganizationSecretScanningAlert>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.OrganizationSecretScanningAlert> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}