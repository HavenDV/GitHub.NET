
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateOrUpdateEnvironmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string environmentName,
            global::GitHub.ReposCreateOrUpdateEnvironmentRequest request);
        partial void PrepareReposCreateOrUpdateEnvironmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string environmentName,
            global::GitHub.ReposCreateOrUpdateEnvironmentRequest request);
        partial void ProcessReposCreateOrUpdateEnvironmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateOrUpdateEnvironmentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update an environment<br/>
        /// Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see "[Environments](/actions/reference/environments#environment-protection-rules)."<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; To create or update name patterns that branches must match in order to deploy to this environment, see "[Deployment branch policies](/rest/deployments/branch-policies)."<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; To create or update secrets for an environment, see "[GitHub Actions secrets](/rest/actions/secrets)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.Environment> ReposCreateOrUpdateEnvironmentAsync(
            string owner,
            string repo,
            string environmentName,
            global::GitHub.ReposCreateOrUpdateEnvironmentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposCreateOrUpdateEnvironmentArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                environmentName: ref environmentName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/environments/{environmentName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareReposCreateOrUpdateEnvironmentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposCreateOrUpdateEnvironmentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposCreateOrUpdateEnvironmentResponseContent(
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
                global::GitHub.Environment.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update an environment<br/>
        /// Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see "[Environments](/actions/reference/environments#environment-protection-rules)."<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; To create or update name patterns that branches must match in order to deploy to this environment, see "[Deployment branch policies](/rest/deployments/branch-policies)."<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; To create or update secrets for an environment, see "[GitHub Actions secrets](/rest/actions/secrets)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="waitTimer">
        /// The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).<br/>
        /// Example: 30
        /// </param>
        /// <param name="preventSelfReview">
        /// Whether or not a user who created the job is prevented from approving their own job.<br/>
        /// Example: false
        /// </param>
        /// <param name="reviewers">
        /// The people or teams that may review jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
        /// </param>
        /// <param name="deploymentBranchPolicy">
        /// The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.Environment> ReposCreateOrUpdateEnvironmentAsync(
            string owner,
            string repo,
            string environmentName,
            int? waitTimer = default,
            bool? preventSelfReview = default,
            global::System.Collections.Generic.IList<global::GitHub.ReposCreateOrUpdateEnvironmentRequestReviewer>? reviewers = default,
            global::GitHub.DeploymentBranchPolicySettings? deploymentBranchPolicy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.ReposCreateOrUpdateEnvironmentRequest
            {
                WaitTimer = waitTimer,
                PreventSelfReview = preventSelfReview,
                Reviewers = reviewers,
                DeploymentBranchPolicy = deploymentBranchPolicy,
            };

            return await ReposCreateOrUpdateEnvironmentAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}