
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposDeleteFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string path,
            global::GitHub.ReposDeleteFileRequest request);
        partial void PrepareReposDeleteFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string path,
            global::GitHub.ReposDeleteFileRequest request);
        partial void ProcessReposDeleteFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposDeleteFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete a file<br/>
        /// Deletes a file in a repository.<br/>
        /// You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.<br/>
        /// The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user's information is used.<br/>
        /// You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you'll receive a `422` status code.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If you use this endpoint and the "[Create or update file contents](https://docs.github.com/rest/repos/contents/#create-or-update-file-contents)" endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.FileCommit> ReposDeleteFileAsync(
            string owner,
            string repo,
            string path,
            global::GitHub.ReposDeleteFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposDeleteFileArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                path: ref path,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/contents/{path}",
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
            PrepareReposDeleteFileRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                path: path,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposDeleteFileResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposDeleteFileResponseContent(
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
                global::GitHub.FileCommit.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Delete a file<br/>
        /// Deletes a file in a repository.<br/>
        /// You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.<br/>
        /// The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user's information is used.<br/>
        /// You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you'll receive a `422` status code.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If you use this endpoint and the "[Create or update file contents](https://docs.github.com/rest/repos/contents/#create-or-update-file-contents)" endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="message">
        /// The commit message.
        /// </param>
        /// <param name="sha">
        /// The blob SHA of the file being deleted.
        /// </param>
        /// <param name="branch">
        /// The branch name. Default: the repository’s default branch
        /// </param>
        /// <param name="committer">
        /// object containing information about the committer.
        /// </param>
        /// <param name="author">
        /// object containing information about the author.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.FileCommit> ReposDeleteFileAsync(
            string owner,
            string repo,
            string path,
            string message,
            string sha,
            string? branch = default,
            global::GitHub.ReposDeleteFileRequestCommitter? committer = default,
            global::GitHub.ReposDeleteFileRequestAuthor? author = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.ReposDeleteFileRequest
            {
                Message = message,
                Sha = sha,
                Branch = branch,
                Committer = committer,
                Author = author,
            };

            return await ReposDeleteFileAsync(
                owner: owner,
                repo: repo,
                path: path,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}