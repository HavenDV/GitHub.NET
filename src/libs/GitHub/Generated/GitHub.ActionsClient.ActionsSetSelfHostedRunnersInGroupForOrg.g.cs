
#nullable enable

namespace GitHub
{
    public partial class ActionsClient
    {
        partial void PrepareActionsSetSelfHostedRunnersInGroupForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int runnerGroupId,
            global::GitHub.ActionsSetSelfHostedRunnersInGroupForOrgRequest request);
        partial void PrepareActionsSetSelfHostedRunnersInGroupForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int runnerGroupId,
            global::GitHub.ActionsSetSelfHostedRunnersInGroupForOrgRequest request);
        partial void ProcessActionsSetSelfHostedRunnersInGroupForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set self-hosted runners in a group for an organization<br/>
        /// Replaces the list of self-hosted runners that are part of an organization runner group.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetSelfHostedRunnersInGroupForOrgAsync(
            string org,
            int runnerGroupId,
            global::GitHub.ActionsSetSelfHostedRunnersInGroupForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsSetSelfHostedRunnersInGroupForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                runnerGroupId: ref runnerGroupId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/runner-groups/{runnerGroupId}/runners",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsSetSelfHostedRunnersInGroupForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                runnerGroupId: runnerGroupId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsSetSelfHostedRunnersInGroupForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set self-hosted runners in a group for an organization<br/>
        /// Replaces the list of self-hosted runners that are part of an organization runner group.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="runners">
        /// List of runner IDs to add to the runner group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetSelfHostedRunnersInGroupForOrgAsync(
            string org,
            int runnerGroupId,
            global::System.Collections.Generic.IList<int> runners,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::GitHub.ActionsSetSelfHostedRunnersInGroupForOrgRequest
            {
                Runners = runners,
            };

            await ActionsSetSelfHostedRunnersInGroupForOrgAsync(
                org: org,
                runnerGroupId: runnerGroupId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}