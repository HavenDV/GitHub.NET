#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get fork PR contributor approval permissions for an organization<br/>
        /// Gets the fork PR contributor approval policy for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsForkPrContributorApproval> ActionsGetForkPrContributorApprovalPermissionsOrganizationAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}