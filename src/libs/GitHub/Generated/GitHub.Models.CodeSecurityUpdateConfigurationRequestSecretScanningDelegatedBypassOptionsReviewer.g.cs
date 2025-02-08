
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewer
    {
        /// <summary>
        /// The ID of the team or role selected as a bypass reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewerId { get; set; }

        /// <summary>
        /// The type of the bypass reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType ReviewerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewer" /> class.
        /// </summary>
        /// <param name="reviewerId">
        /// The ID of the team or role selected as a bypass reviewer
        /// </param>
        /// <param name="reviewerType">
        /// The type of the bypass reviewer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewer(
            int reviewerId,
            global::GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType reviewerType)
        {
            this.ReviewerId = reviewerId;
            this.ReviewerType = reviewerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewer" /> class.
        /// </summary>
        public CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewer()
        {
        }
    }
}