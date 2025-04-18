
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2StatusUpdateEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStartDate? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_date")]
        public global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesTargetDate? TargetDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2StatusUpdateEditedChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="status"></param>
        /// <param name="startDate"></param>
        /// <param name="targetDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookProjectsV2StatusUpdateEditedChanges(
            global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesBody? body,
            global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatus? status,
            global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStartDate? startDate,
            global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesTargetDate? targetDate)
        {
            this.Body = body;
            this.Status = status;
            this.StartDate = startDate;
            this.TargetDate = targetDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2StatusUpdateEditedChanges" /> class.
        /// </summary>
        public WebhookProjectsV2StatusUpdateEditedChanges()
        {
        }
    }
}