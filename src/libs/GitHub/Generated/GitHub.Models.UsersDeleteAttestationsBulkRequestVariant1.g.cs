
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersDeleteAttestationsBulkRequestVariant1
    {
        /// <summary>
        /// List of subject digests associated with the artifact attestations to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_digests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SubjectDigests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersDeleteAttestationsBulkRequestVariant1" /> class.
        /// </summary>
        /// <param name="subjectDigests">
        /// List of subject digests associated with the artifact attestations to delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersDeleteAttestationsBulkRequestVariant1(
            global::System.Collections.Generic.IList<string> subjectDigests)
        {
            this.SubjectDigests = subjectDigests ?? throw new global::System.ArgumentNullException(nameof(subjectDigests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersDeleteAttestationsBulkRequestVariant1" /> class.
        /// </summary>
        public UsersDeleteAttestationsBulkRequestVariant1()
        {
        }
    }
}