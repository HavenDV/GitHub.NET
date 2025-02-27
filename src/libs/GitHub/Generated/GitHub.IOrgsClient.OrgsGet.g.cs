#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get an organization<br/>
        /// Gets information about an organization.<br/>
        /// When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, outside collaborators, guest collaborators, repository collaborators, or everyone with access to any repository within the organization to enable [two-factor authentication](https://docs.github.com/articles/securing-your-account-with-two-factor-authentication-2fa/).<br/>
        /// To see the full details about an organization, the authenticated user must be an organization owner.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to see the full details about an organization.<br/>
        /// To see information about an organization's GitHub plan, GitHub Apps need the `Organization plan` permission.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OrganizationFull> OrgsGetAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}