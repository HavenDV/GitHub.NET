#nullable enable

namespace GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Delete a code security configuration for an enterprise<br/>
        /// Deletes a code security configuration from an enterprise.<br/>
        /// Repositories attached to the configuration will retain their settings but will no longer be associated with<br/>
        /// the configuration.<br/>
        /// The authenticated user must be an administrator for the enterprise to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CodeSecurityDeleteConfigurationForEnterpriseAsync(
            string enterprise,
            int configurationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}