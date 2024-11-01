
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateDeploymentBranchPolicyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string environmentName,
            global::GitHub.DeploymentBranchPolicyNamePatternWithType request);
        partial void PrepareReposCreateDeploymentBranchPolicyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string environmentName,
            global::GitHub.DeploymentBranchPolicyNamePatternWithType request);
        partial void ProcessReposCreateDeploymentBranchPolicyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateDeploymentBranchPolicyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a deployment branch policy<br/>
        /// Creates a deployment branch or tag policy for an environment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.DeploymentBranchPolicy> ReposCreateDeploymentBranchPolicyAsync(
            string owner,
            string repo,
            string environmentName,
            global::GitHub.DeploymentBranchPolicyNamePatternWithType request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposCreateDeploymentBranchPolicyArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                environmentName: ref environmentName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/environments/{environmentName}/deployment-branch-policies",
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
            PrepareReposCreateDeploymentBranchPolicyRequest(
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
            ProcessReposCreateDeploymentBranchPolicyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposCreateDeploymentBranchPolicyResponseContent(
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
                global::GitHub.DeploymentBranchPolicy.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a deployment branch policy<br/>
        /// Creates a deployment branch or tag policy for an environment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="name">
        /// The name pattern that branches or tags must match in order to deploy to the environment.<br/>
        /// Wildcard characters will not match `/`. For example, to match branches that begin with `release/` and contain an additional single slash, use `release/*/*`.<br/>
        /// For more information about pattern matching syntax, see the [Ruby File.fnmatch documentation](https://ruby-doc.org/core-2.5.1/File.html#method-c-fnmatch).<br/>
        /// Example: release/*
        /// </param>
        /// <param name="type">
        /// Whether this rule targets a branch or tag<br/>
        /// Example: branch
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.DeploymentBranchPolicy> ReposCreateDeploymentBranchPolicyAsync(
            string owner,
            string repo,
            string environmentName,
            string name,
            global::GitHub.DeploymentBranchPolicyNamePatternWithTypeType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.DeploymentBranchPolicyNamePatternWithType
            {
                Name = name,
                Type = type,
            };

            return await ReposCreateDeploymentBranchPolicyAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}