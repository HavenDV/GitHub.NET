
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersListAttestationsBulkRequest
    {
        /// <summary>
        /// List of subject digests to fetch attestations for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_digests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SubjectDigests { get; set; }

        /// <summary>
        /// Optional filter for fetching attestations with a given predicate type.<br/>
        /// This option accepts `provenance`, `sbom`, or freeform text for custom predicate types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predicate_type")]
        public string? PredicateType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsBulkRequest" /> class.
        /// </summary>
        /// <param name="subjectDigests">
        /// List of subject digests to fetch attestations for.
        /// </param>
        /// <param name="predicateType">
        /// Optional filter for fetching attestations with a given predicate type.<br/>
        /// This option accepts `provenance`, `sbom`, or freeform text for custom predicate types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersListAttestationsBulkRequest(
            global::System.Collections.Generic.IList<string> subjectDigests,
            string? predicateType)
        {
            this.SubjectDigests = subjectDigests ?? throw new global::System.ArgumentNullException(nameof(subjectDigests));
            this.PredicateType = predicateType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsBulkRequest" /> class.
        /// </summary>
        public UsersListAttestationsBulkRequest()
        {
        }
    }
}