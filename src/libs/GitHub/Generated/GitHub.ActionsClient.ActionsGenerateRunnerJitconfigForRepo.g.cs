
#nullable enable

namespace GitHub
{
    public partial class ActionsClient
    {
        partial void PrepareActionsGenerateRunnerJitconfigForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::GitHub.ActionsGenerateRunnerJitconfigForRepoRequest request);
        partial void PrepareActionsGenerateRunnerJitconfigForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::GitHub.ActionsGenerateRunnerJitconfigForRepoRequest request);
        partial void ProcessActionsGenerateRunnerJitconfigForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsGenerateRunnerJitconfigForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create configuration for a just-in-time runner for a repository<br/>
        /// Generates a configuration that can be passed to the runner application at startup.<br/>
        /// The authenticated user must have admin access to the repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ActionsGenerateRunnerJitconfigForRepoResponse> ActionsGenerateRunnerJitconfigForRepoAsync(
            string owner,
            string repo,
            global::GitHub.ActionsGenerateRunnerJitconfigForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsGenerateRunnerJitconfigForRepoArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/actions/runners/generate-jitconfig",
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
            PrepareActionsGenerateRunnerJitconfigForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsGenerateRunnerJitconfigForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessActionsGenerateRunnerJitconfigForRepoResponseContent(
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
                global::GitHub.ActionsGenerateRunnerJitconfigForRepoResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create configuration for a just-in-time runner for a repository<br/>
        /// Generates a configuration that can be passed to the runner application at startup.<br/>
        /// The authenticated user must have admin access to the repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name">
        /// The name of the new runner.
        /// </param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group to register the runner to.
        /// </param>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner. **Minimum items**: 1. **Maximum items**: 100.
        /// </param>
        /// <param name="workFolder">
        /// The working directory to be used for job execution, relative to the runner install directory.<br/>
        /// Default Value: _work
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ActionsGenerateRunnerJitconfigForRepoResponse> ActionsGenerateRunnerJitconfigForRepoAsync(
            string owner,
            string repo,
            string name,
            int runnerGroupId,
            global::System.Collections.Generic.IList<string> labels,
            string? workFolder = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.ActionsGenerateRunnerJitconfigForRepoRequest
            {
                Name = name,
                RunnerGroupId = runnerGroupId,
                Labels = labels,
                WorkFolder = workFolder,
            };

            return await ActionsGenerateRunnerJitconfigForRepoAsync(
                owner: owner,
                repo: repo,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}