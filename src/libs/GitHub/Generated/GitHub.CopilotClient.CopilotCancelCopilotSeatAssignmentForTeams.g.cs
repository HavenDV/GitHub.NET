
#nullable enable

namespace GitHub
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotCancelCopilotSeatAssignmentForTeamsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::GitHub.CopilotCancelCopilotSeatAssignmentForTeamsRequest request);
        partial void PrepareCopilotCancelCopilotSeatAssignmentForTeamsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.CopilotCancelCopilotSeatAssignmentForTeamsRequest request);
        partial void ProcessCopilotCancelCopilotSeatAssignmentForTeamsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotCancelCopilotSeatAssignmentForTeamsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove teams from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Cancels the Copilot seat assignment for all members of each team specified.<br/>
        /// This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.<br/>
        /// For more information about Copilot pricing, see "[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)".<br/>
        /// For more information about disabling access to Copilot Business or Enterprise, see "[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)".<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CopilotCancelCopilotSeatAssignmentForTeamsResponse> CopilotCancelCopilotSeatAssignmentForTeamsAsync(
            string org,
            global::GitHub.CopilotCancelCopilotSeatAssignmentForTeamsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCopilotCancelCopilotSeatAssignmentForTeamsArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/copilot/billing/selected_teams",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
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
            PrepareCopilotCancelCopilotSeatAssignmentForTeamsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCopilotCancelCopilotSeatAssignmentForTeamsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCopilotCancelCopilotSeatAssignmentForTeamsResponseContent(
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
                global::GitHub.CopilotCancelCopilotSeatAssignmentForTeamsResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Remove teams from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Cancels the Copilot seat assignment for all members of each team specified.<br/>
        /// This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.<br/>
        /// For more information about Copilot pricing, see "[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)".<br/>
        /// For more information about disabling access to Copilot Business or Enterprise, see "[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)".<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedTeams">
        /// The names of teams from which to revoke access to GitHub Copilot.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CopilotCancelCopilotSeatAssignmentForTeamsResponse> CopilotCancelCopilotSeatAssignmentForTeamsAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedTeams,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.CopilotCancelCopilotSeatAssignmentForTeamsRequest
            {
                SelectedTeams = selectedTeams,
            };

            return await CopilotCancelCopilotSeatAssignmentForTeamsAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}