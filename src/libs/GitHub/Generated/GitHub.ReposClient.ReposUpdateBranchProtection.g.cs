
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposUpdateBranchProtectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string branch,
            global::GitHub.ReposUpdateBranchProtectionRequest request);
        partial void PrepareReposUpdateBranchProtectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string branch,
            global::GitHub.ReposUpdateBranchProtectionRequest request);
        partial void ProcessReposUpdateBranchProtectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdateBranchProtectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update branch protection<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Protecting a branch requires admin or owner permissions to the repository.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Passing new arrays of `users` and `teams` replaces their previous values.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The list of users, apps, and teams in total is limited to 100 items.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ProtectedBranch> ReposUpdateBranchProtectionAsync(
            string owner,
            string repo,
            string branch,
            global::GitHub.ReposUpdateBranchProtectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposUpdateBranchProtectionArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                branch: ref branch,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/branches/{branch}/protection",
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
            PrepareReposUpdateBranchProtectionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                branch: branch,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposUpdateBranchProtectionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposUpdateBranchProtectionResponseContent(
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
                global::GitHub.ProtectedBranch.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update branch protection<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Protecting a branch requires admin or owner permissions to the repository.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Passing new arrays of `users` and `teams` replaces their previous values.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The list of users, apps, and teams in total is limited to 100 items.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="requiredStatusChecks">
        /// Require status checks to pass before merging. Set to `null` to disable.
        /// </param>
        /// <param name="enforceAdmins">
        /// Enforce all configured restrictions for administrators. Set to `true` to enforce required status checks for repository administrators. Set to `null` to disable.
        /// </param>
        /// <param name="requiredPullRequestReviews">
        /// Require at least one approving review on a pull request, before merging. Set to `null` to disable.
        /// </param>
        /// <param name="restrictions">
        /// Restrict who can push to the protected branch. User, app, and team `restrictions` are only available for organization-owned repositories. Set to `null` to disable.
        /// </param>
        /// <param name="requiredLinearHistory">
        /// Enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch. Set to `true` to enforce a linear commit history. Set to `false` to disable a linear commit Git history. Your repository must allow squash merging or rebase merging before you can enable a linear commit history. Default: `false`. For more information, see "[Requiring a linear commit history](https://docs.github.com/github/administering-a-repository/requiring-a-linear-commit-history)" in the GitHub Help documentation.
        /// </param>
        /// <param name="allowForcePushes">
        /// Permits force pushes to the protected branch by anyone with write access to the repository. Set to `true` to allow force pushes. Set to `false` or `null` to block force pushes. Default: `false`. For more information, see "[Enabling force pushes to a protected branch](https://docs.github.com/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)" in the GitHub Help documentation."
        /// </param>
        /// <param name="allowDeletions">
        /// Allows deletion of the protected branch by anyone with write access to the repository. Set to `false` to prevent deletion of the protected branch. Default: `false`. For more information, see "[Enabling force pushes to a protected branch](https://docs.github.com/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)" in the GitHub Help documentation.
        /// </param>
        /// <param name="blockCreations">
        /// If set to `true`, the `restrictions` branch protection settings which limits who can push will also block pushes which create new branches, unless the push is initiated by a user, team, or app which has the ability to push. Set to `true` to restrict new branch creation. Default: `false`.
        /// </param>
        /// <param name="requiredConversationResolution">
        /// Requires all conversations on code to be resolved before a pull request can be merged into a branch that matches this rule. Set to `false` to disable. Default: `false`.
        /// </param>
        /// <param name="lockBranch">
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch. Default: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowForkSyncing">
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing. Default: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ProtectedBranch> ReposUpdateBranchProtectionAsync(
            string owner,
            string repo,
            string branch,
            global::GitHub.ReposUpdateBranchProtectionRequestRequiredStatusChecks? requiredStatusChecks,
            bool? enforceAdmins,
            global::GitHub.ReposUpdateBranchProtectionRequestRequiredPullRequestReviews? requiredPullRequestReviews,
            global::GitHub.ReposUpdateBranchProtectionRequestRestrictions? restrictions,
            bool? requiredLinearHistory = default,
            bool? allowForcePushes = default,
            bool? allowDeletions = default,
            bool? blockCreations = default,
            bool? requiredConversationResolution = default,
            bool? lockBranch = default,
            bool? allowForkSyncing = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.ReposUpdateBranchProtectionRequest
            {
                RequiredStatusChecks = requiredStatusChecks,
                EnforceAdmins = enforceAdmins,
                RequiredPullRequestReviews = requiredPullRequestReviews,
                Restrictions = restrictions,
                RequiredLinearHistory = requiredLinearHistory,
                AllowForcePushes = allowForcePushes,
                AllowDeletions = allowDeletions,
                BlockCreations = blockCreations,
                RequiredConversationResolution = requiredConversationResolution,
                LockBranch = lockBranch,
                AllowForkSyncing = allowForkSyncing,
            };

            return await ReposUpdateBranchProtectionAsync(
                owner: owner,
                repo: repo,
                branch: branch,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}