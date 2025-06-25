
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsDeleteAttestationsBulkRequestVariant2
    {
        /// <summary>
        /// List of unique IDs associated with the artifact attestations to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attestation_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> AttestationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsDeleteAttestationsBulkRequestVariant2" /> class.
        /// </summary>
        /// <param name="attestationIds">
        /// List of unique IDs associated with the artifact attestations to delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsDeleteAttestationsBulkRequestVariant2(
            global::System.Collections.Generic.IList<int> attestationIds)
        {
            this.AttestationIds = attestationIds ?? throw new global::System.ArgumentNullException(nameof(attestationIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsDeleteAttestationsBulkRequestVariant2" /> class.
        /// </summary>
        public OrgsDeleteAttestationsBulkRequestVariant2()
        {
        }
    }
}