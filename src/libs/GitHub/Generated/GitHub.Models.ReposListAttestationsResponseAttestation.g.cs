
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposListAttestationsResponseAttestation
    {
        /// <summary>
        /// The attestation's Sigstore Bundle.<br/>
        /// Refer to the [Sigstore Bundle Specification](https://github.com/sigstore/protobuf-specs/blob/main/protos/sigstore_bundle.proto) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle")]
        public global::GitHub.ReposListAttestationsResponseAttestationBundle? Bundle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_url")]
        public string? BundleUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListAttestationsResponseAttestation" /> class.
        /// </summary>
        /// <param name="bundle">
        /// The attestation's Sigstore Bundle.<br/>
        /// Refer to the [Sigstore Bundle Specification](https://github.com/sigstore/protobuf-specs/blob/main/protos/sigstore_bundle.proto) for more information.
        /// </param>
        /// <param name="repositoryId"></param>
        /// <param name="bundleUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposListAttestationsResponseAttestation(
            global::GitHub.ReposListAttestationsResponseAttestationBundle? bundle,
            int? repositoryId,
            string? bundleUrl)
        {
            this.Bundle = bundle;
            this.RepositoryId = repositoryId;
            this.BundleUrl = bundleUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListAttestationsResponseAttestation" /> class.
        /// </summary>
        public ReposListAttestationsResponseAttestation()
        {
        }
    }
}