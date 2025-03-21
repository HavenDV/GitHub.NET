#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete issue type for an organization<br/>
        /// Deletes an issue type for an organization.<br/>
        /// You can find out more about issue types in [Managing issue types in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/configuring-issues/managing-issue-types-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="issueTypeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteIssueTypeAsync(
            string org,
            int issueTypeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}