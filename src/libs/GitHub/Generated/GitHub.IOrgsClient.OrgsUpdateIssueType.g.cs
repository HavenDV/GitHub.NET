#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update issue type for an organization<br/>
        /// Updates an issue type for an organization.<br/>
        /// You can find out more about issue types in [Managing issue types in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/configuring-issues/managing-issue-types-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="issueTypeId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.IssueType> OrgsUpdateIssueTypeAsync(
            string org,
            int issueTypeId,
            global::GitHub.OrganizationUpdateIssueType request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update issue type for an organization<br/>
        /// Updates an issue type for an organization.<br/>
        /// You can find out more about issue types in [Managing issue types in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/configuring-issues/managing-issue-types-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="issueTypeId"></param>
        /// <param name="name">
        /// Name of the issue type.
        /// </param>
        /// <param name="isEnabled">
        /// Whether or not the issue type is enabled at the organization level.
        /// </param>
        /// <param name="description">
        /// Description of the issue type.
        /// </param>
        /// <param name="color">
        /// Color for the issue type.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.IssueType> OrgsUpdateIssueTypeAsync(
            string org,
            int issueTypeId,
            string name,
            bool isEnabled,
            string? description = default,
            global::GitHub.OrganizationUpdateIssueTypeColor? color = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}