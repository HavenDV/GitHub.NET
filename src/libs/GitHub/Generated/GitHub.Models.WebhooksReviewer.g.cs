
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksReviewer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer")]
        public global::GitHub.WebhooksReviewerReviewer? Reviewer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksReviewerTypeJsonConverter))]
        public global::GitHub.WebhooksReviewerType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksReviewer" /> class.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhooksReviewer(
            global::GitHub.WebhooksReviewerReviewer? reviewer,
            global::GitHub.WebhooksReviewerType? type)
        {
            this.Reviewer = reviewer;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksReviewer" /> class.
        /// </summary>
        public WebhooksReviewer()
        {
        }
    }
}