#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteAttestationsBulkAsync(
            string org,
            global::GitHub.OneOf<global::GitHub.OrgsDeleteAttestationsBulkRequestVariant1, global::GitHub.OrgsDeleteAttestationsBulkRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteAttestationsBulkAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}