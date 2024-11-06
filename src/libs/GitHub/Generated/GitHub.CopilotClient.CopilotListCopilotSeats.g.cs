
#nullable enable

namespace GitHub
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotListCopilotSeatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int? page,
            ref int? perPage);
        partial void PrepareCopilotListCopilotSeatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int? page,
            int? perPage);
        partial void ProcessCopilotListCopilotSeatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotListCopilotSeatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List all Copilot seat assignments for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Lists all Copilot seats for which an organization with a Copilot Business or Copilot Enterprise subscription is currently being billed.<br/>
        /// Only organization owners can view assigned seats.<br/>
        /// Each seat object contains information about the assigned user's most recent Copilot activity. Users must have telemetry enabled in their IDE for Copilot in the IDE activity to be reflected in `last_activity_at`.<br/>
        /// For more information about activity data, see "[Reviewing user activity data for Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/reviewing-activity-related-to-github-copilot-in-your-organization/reviewing-user-activity-data-for-copilot-in-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CopilotListCopilotSeatsResponse> CopilotListCopilotSeatsAsync(
            string org,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCopilotListCopilotSeatsArguments(
                httpClient: HttpClient,
                org: ref org,
                page: ref page,
                perPage: ref perPage);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/copilot/billing/seats",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCopilotListCopilotSeatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                page: page,
                perPage: perPage);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCopilotListCopilotSeatsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCopilotListCopilotSeatsResponseContent(
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
                global::GitHub.CopilotListCopilotSeatsResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}