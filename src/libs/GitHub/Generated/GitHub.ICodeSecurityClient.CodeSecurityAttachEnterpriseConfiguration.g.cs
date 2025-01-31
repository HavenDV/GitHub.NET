#nullable enable

namespace GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Attach an enterprise configuration to repositories<br/>
        /// Attaches an enterprise code security configuration to repositories. If the repositories specified are already attached to a configuration, they will be re-attached to the provided configuration.<br/>
        /// If insufficient GHAS licenses are available to attach the configuration to a repository, only free features will be enabled.<br/>
        /// The authenticated user must be an administrator for the enterprise to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CodeSecurityAttachEnterpriseConfigurationAsync(
            string enterprise,
            int configurationId,
            global::GitHub.CodeSecurityAttachEnterpriseConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Attach an enterprise configuration to repositories<br/>
        /// Attaches an enterprise code security configuration to repositories. If the repositories specified are already attached to a configuration, they will be re-attached to the provided configuration.<br/>
        /// If insufficient GHAS licenses are available to attach the configuration to a repository, only free features will be enabled.<br/>
        /// The authenticated user must be an administrator for the enterprise to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="scope">
        /// The type of repositories to attach the configuration to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CodeSecurityAttachEnterpriseConfigurationAsync(
            string enterprise,
            int configurationId,
            global::GitHub.CodeSecurityAttachEnterpriseConfigurationRequestScope scope,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}