#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete attestations by ID<br/>
        /// Delete an artifact attestation by unique ID that is associated with a repository owned by an org.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="attestationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteAttestationsByIdAsync(
            string org,
            int attestationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}