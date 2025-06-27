
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersListAttestationsBulkResponseAttestationsSubjectDigest
    {
        /// <summary>
        /// The bundle of the attestation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle")]
        public global::GitHub.UsersListAttestationsBulkResponseAttestationsSubjectDigestBundle? Bundle { get; set; }

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
        /// Initializes a new instance of the <see cref="UsersListAttestationsBulkResponseAttestationsSubjectDigest" /> class.
        /// </summary>
        /// <param name="bundle">
        /// The bundle of the attestation.
        /// </param>
        /// <param name="repositoryId"></param>
        /// <param name="bundleUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersListAttestationsBulkResponseAttestationsSubjectDigest(
            global::GitHub.UsersListAttestationsBulkResponseAttestationsSubjectDigestBundle? bundle,
            int? repositoryId,
            string? bundleUrl)
        {
            this.Bundle = bundle;
            this.RepositoryId = repositoryId;
            this.BundleUrl = bundleUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsBulkResponseAttestationsSubjectDigest" /> class.
        /// </summary>
        public UsersListAttestationsBulkResponseAttestationsSubjectDigest()
        {
        }
    }
}