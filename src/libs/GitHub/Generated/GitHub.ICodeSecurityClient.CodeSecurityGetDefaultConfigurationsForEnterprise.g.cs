#nullable enable

namespace GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Get default code security configurations for an enterprise<br/>
        /// Lists the default code security configurations for an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CodeSecurityDefaultConfiguration>> CodeSecurityGetDefaultConfigurationsForEnterpriseAsync(
            string enterprise,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}