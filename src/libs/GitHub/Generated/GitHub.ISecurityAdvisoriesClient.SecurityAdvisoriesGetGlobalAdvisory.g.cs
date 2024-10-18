#nullable enable

namespace GitHub
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// Get a global security advisory<br/>
        /// Gets a global security advisory using its GitHub Security Advisory (GHSA) identifier.
        /// </summary>
        /// <param name="ghsaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.GlobalAdvisory> SecurityAdvisoriesGetGlobalAdvisoryAsync(
            string ghsaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}