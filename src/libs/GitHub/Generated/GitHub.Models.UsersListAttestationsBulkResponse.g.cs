
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersListAttestationsBulkResponse
    {
        /// <summary>
        /// Mapping of subject digest to bundles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attestations_subject_digests")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::GitHub.UsersListAttestationsBulkResponseAttestationsSubjectDigest>?>? AttestationsSubjectDigests { get; set; }

        /// <summary>
        /// Information about the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_info")]
        public global::GitHub.UsersListAttestationsBulkResponsePageInfo? PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsBulkResponse" /> class.
        /// </summary>
        /// <param name="attestationsSubjectDigests">
        /// Mapping of subject digest to bundles.
        /// </param>
        /// <param name="pageInfo">
        /// Information about the current page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersListAttestationsBulkResponse(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::GitHub.UsersListAttestationsBulkResponseAttestationsSubjectDigest>?>? attestationsSubjectDigests,
            global::GitHub.UsersListAttestationsBulkResponsePageInfo? pageInfo)
        {
            this.AttestationsSubjectDigests = attestationsSubjectDigests;
            this.PageInfo = pageInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsBulkResponse" /> class.
        /// </summary>
        public UsersListAttestationsBulkResponse()
        {
        }
    }
}