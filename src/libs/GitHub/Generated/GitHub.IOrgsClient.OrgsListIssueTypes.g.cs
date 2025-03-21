#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List issue types for an organization<br/>
        /// Lists all issue types for an organization. OAuth app tokens and personal access tokens (classic) need the read:org scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.IssueType>> OrgsListIssueTypesAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}