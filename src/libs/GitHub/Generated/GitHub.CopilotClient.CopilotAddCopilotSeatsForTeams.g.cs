
#nullable enable

namespace GitHub
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotAddCopilotSeatsForTeamsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::GitHub.CopilotAddCopilotSeatsForTeamsRequest request);
        partial void PrepareCopilotAddCopilotSeatsForTeamsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.CopilotAddCopilotSeatsForTeamsRequest request);
        partial void ProcessCopilotAddCopilotSeatsForTeamsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotAddCopilotSeatsForTeamsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add teams to the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Purchases a GitHub Copilot seat for all users within each specified team.<br/>
        /// The organization will be billed accordingly. For more information about Copilot pricing, see "[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)".<br/>
        /// Only organization owners can add Copilot seats for their organization members.<br/>
        /// In order for an admin to use this endpoint, the organization must have a Copilot Business or Enterprise subscription and a configured suggestion matching policy.<br/>
        /// For more information about setting up a Copilot subscription, see "[Setting up a Copilot subscription for your organization](https://docs.github.com/billing/managing-billing-for-github-copilot/managing-your-github-copilot-subscription-for-your-organization-or-enterprise)".<br/>
        /// For more information about setting a suggestion matching policy, see "[Configuring suggestion matching policies for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-policies-for-github-copilot-in-your-organization#configuring-suggestion-matching-policies-for-github-copilot-in-your-organization)".<br/>
        /// The response will contain the total number of new seats that were created and existing seats that were refreshed.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CopilotAddCopilotSeatsForTeamsResponse> CopilotAddCopilotSeatsForTeamsAsync(
            string org,
            global::GitHub.CopilotAddCopilotSeatsForTeamsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCopilotAddCopilotSeatsForTeamsArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/copilot/billing/selected_teams",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCopilotAddCopilotSeatsForTeamsRequest(
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
            ProcessCopilotAddCopilotSeatsForTeamsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCopilotAddCopilotSeatsForTeamsResponseContent(
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
                global::GitHub.CopilotAddCopilotSeatsForTeamsResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add teams to the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Purchases a GitHub Copilot seat for all users within each specified team.<br/>
        /// The organization will be billed accordingly. For more information about Copilot pricing, see "[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)".<br/>
        /// Only organization owners can add Copilot seats for their organization members.<br/>
        /// In order for an admin to use this endpoint, the organization must have a Copilot Business or Enterprise subscription and a configured suggestion matching policy.<br/>
        /// For more information about setting up a Copilot subscription, see "[Setting up a Copilot subscription for your organization](https://docs.github.com/billing/managing-billing-for-github-copilot/managing-your-github-copilot-subscription-for-your-organization-or-enterprise)".<br/>
        /// For more information about setting a suggestion matching policy, see "[Configuring suggestion matching policies for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-policies-for-github-copilot-in-your-organization#configuring-suggestion-matching-policies-for-github-copilot-in-your-organization)".<br/>
        /// The response will contain the total number of new seats that were created and existing seats that were refreshed.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedTeams">
        /// List of team names within the organization to which to grant access to GitHub Copilot.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CopilotAddCopilotSeatsForTeamsResponse> CopilotAddCopilotSeatsForTeamsAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedTeams,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.CopilotAddCopilotSeatsForTeamsRequest
            {
                SelectedTeams = selectedTeams,
            };

            return await CopilotAddCopilotSeatsForTeamsAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}