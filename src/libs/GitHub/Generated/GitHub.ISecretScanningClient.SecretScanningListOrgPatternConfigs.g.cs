#nullable enable

namespace GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// List organization pattern configurations<br/>
        /// Lists the secret scanning pattern configurations for an organization.<br/>
        /// Personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.SecretScanningPatternConfiguration> SecretScanningListOrgPatternConfigsAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}