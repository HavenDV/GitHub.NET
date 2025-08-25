#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set fork PR contributor approval permissions for an organization<br/>
        /// Sets the fork PR contributor approval policy for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetForkPrContributorApprovalPermissionsOrganizationAsync(
            string org,
            global::GitHub.ActionsForkPrContributorApproval request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set fork PR contributor approval permissions for an organization<br/>
        /// Sets the fork PR contributor approval policy for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="approvalPolicy">
        /// The policy that controls when fork PR workflows require approval from a maintainer.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetForkPrContributorApprovalPermissionsOrganizationAsync(
            string org,
            global::GitHub.ActionsForkPrContributorApprovalApprovalPolicy approvalPolicy,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}