#nullable enable

namespace GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Set a code security configuration as a default for an enterprise<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your enterprise.<br/>
        /// This configuration will be applied by default to the matching repository type when created, but only for organizations within the enterprise that do not already have a default code security configuration set.<br/>
        /// The authenticated user must be an administrator for the enterprise to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse> CodeSecuritySetConfigurationAsDefaultForEnterpriseAsync(
            string enterprise,
            int configurationId,
            global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set a code security configuration as a default for an enterprise<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your enterprise.<br/>
        /// This configuration will be applied by default to the matching repository type when created, but only for organizations within the enterprise that do not already have a default code security configuration set.<br/>
        /// The authenticated user must be an administrator for the enterprise to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="defaultForNewRepos">
        /// Specify which types of repository this security configuration should be applied to by default.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse> CodeSecuritySetConfigurationAsDefaultForEnterpriseAsync(
            string enterprise,
            int configurationId,
            global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos? defaultForNewRepos = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}