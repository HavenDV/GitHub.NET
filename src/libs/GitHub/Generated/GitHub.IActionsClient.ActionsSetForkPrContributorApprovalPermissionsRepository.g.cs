#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set fork PR contributor approval permissions for a repository<br/>
        /// Sets the fork PR contributor approval policy for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetForkPrContributorApprovalPermissionsRepositoryAsync(
            string owner,
            string repo,
            global::GitHub.ActionsForkPrContributorApproval request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set fork PR contributor approval permissions for a repository<br/>
        /// Sets the fork PR contributor approval policy for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="approvalPolicy">
        /// The policy that controls when fork PR workflows require approval from a maintainer.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetForkPrContributorApprovalPermissionsRepositoryAsync(
            string owner,
            string repo,
            global::GitHub.ActionsForkPrContributorApprovalApprovalPolicy approvalPolicy,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}