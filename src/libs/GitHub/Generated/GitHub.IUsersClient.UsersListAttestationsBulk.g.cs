#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List attestations by bulk subject digests<br/>
        /// List a collection of artifact attestations associated with any entry in a list of subject digests owned by a user.<br/>
        /// The collection of attestations returned by this endpoint is filtered according to the authenticated user's permissions; if the authenticated user cannot read a repository, the attestations associated with that repository will not be included in the response. In addition, when using a fine-grained access token the `attestations:read` permission is required.<br/>
        /// **Please note:** in order to offer meaningful security benefits, an attestation's signature and timestamps **must** be cryptographically verified, and the identity of the attestation signer **must** be validated. Attestations can be verified using the [GitHub CLI `attestation verify` command](https://cli.github.com/manual/gh_attestation_verify). For more information, see [our guide on how to use artifact attestations to establish a build's provenance](https://docs.github.com/actions/security-guides/using-artifact-attestations-to-establish-provenance-for-builds).
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.UsersListAttestationsBulkResponse> UsersListAttestationsBulkAsync(
            string username,
            global::GitHub.UsersListAttestationsBulkRequest request,
            int? perPage = default,
            string? before = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// List attestations by bulk subject digests<br/>
        /// List a collection of artifact attestations associated with any entry in a list of subject digests owned by a user.<br/>
        /// The collection of attestations returned by this endpoint is filtered according to the authenticated user's permissions; if the authenticated user cannot read a repository, the attestations associated with that repository will not be included in the response. In addition, when using a fine-grained access token the `attestations:read` permission is required.<br/>
        /// **Please note:** in order to offer meaningful security benefits, an attestation's signature and timestamps **must** be cryptographically verified, and the identity of the attestation signer **must** be validated. Attestations can be verified using the [GitHub CLI `attestation verify` command](https://cli.github.com/manual/gh_attestation_verify). For more information, see [our guide on how to use artifact attestations to establish a build's provenance](https://docs.github.com/actions/security-guides/using-artifact-attestations-to-establish-provenance-for-builds).
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="username"></param>
        /// <param name="subjectDigests">
        /// List of subject digests to fetch attestations for.
        /// </param>
        /// <param name="predicateType">
        /// Optional filter for fetching attestations with a given predicate type.<br/>
        /// This option accepts `provenance`, `sbom`, or freeform text for custom predicate types.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.UsersListAttestationsBulkResponse> UsersListAttestationsBulkAsync(
            string username,
            global::System.Collections.Generic.IList<string> subjectDigests,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? predicateType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}