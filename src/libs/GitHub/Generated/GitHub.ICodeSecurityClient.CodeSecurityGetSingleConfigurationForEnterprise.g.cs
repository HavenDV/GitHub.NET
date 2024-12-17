#nullable enable

namespace GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Retrieve a code security configuration of an enterprise<br/>
        /// Gets a code security configuration available in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CodeSecurityConfiguration> CodeSecurityGetSingleConfigurationForEnterpriseAsync(
            string enterprise,
            int configurationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}