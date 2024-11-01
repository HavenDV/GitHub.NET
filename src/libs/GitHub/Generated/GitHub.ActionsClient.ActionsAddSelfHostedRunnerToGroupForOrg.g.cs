
#nullable enable

namespace GitHub
{
    public partial class ActionsClient
    {
        partial void PrepareActionsAddSelfHostedRunnerToGroupForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int runnerGroupId,
            ref int runnerId);
        partial void PrepareActionsAddSelfHostedRunnerToGroupForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int runnerGroupId,
            int runnerId);
        partial void ProcessActionsAddSelfHostedRunnerToGroupForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Add a self-hosted runner to a group for an organization<br/>
        /// Adds a self-hosted runner to a runner group configured in an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsAddSelfHostedRunnerToGroupForOrgAsync(
            string org,
            int runnerGroupId,
            int runnerId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsAddSelfHostedRunnerToGroupForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                runnerGroupId: ref runnerGroupId,
                runnerId: ref runnerId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/runner-groups/{runnerGroupId}/runners/{runnerId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsAddSelfHostedRunnerToGroupForOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                runnerGroupId: runnerGroupId,
                runnerId: runnerId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsAddSelfHostedRunnerToGroupForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}