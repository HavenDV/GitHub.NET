#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete attestations by subject digest<br/>
        /// Delete an artifact attestation by subject digest.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="subjectDigest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteAttestationsBySubjectDigestAsync(
            string org,
            string subjectDigest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}