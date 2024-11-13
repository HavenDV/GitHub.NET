
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentReviewRequestedReviewer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer")]
        public global::GitHub.WebhookDeploymentReviewRequestedReviewerReviewer? Reviewer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentReviewRequestedReviewerTypeJsonConverter))]
        public global::GitHub.WebhookDeploymentReviewRequestedReviewerType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRequestedReviewer" /> class.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookDeploymentReviewRequestedReviewer(
            global::GitHub.WebhookDeploymentReviewRequestedReviewerReviewer? reviewer,
            global::GitHub.WebhookDeploymentReviewRequestedReviewerType? type)
        {
            this.Reviewer = reviewer;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRequestedReviewer" /> class.
        /// </summary>
        public WebhookDeploymentReviewRequestedReviewer()
        {
        }
    }
}