
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowJobWaitingWorkflowJobStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookWorkflowJobWaitingWorkflowJobStepConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookWorkflowJobWaitingWorkflowJobStepConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookWorkflowJobWaitingWorkflowJobStepStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookWorkflowJobWaitingWorkflowJobStepStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobWaitingWorkflowJobStep" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookWorkflowJobWaitingWorkflowJobStep(
            string? completedAt,
            global::GitHub.WebhookWorkflowJobWaitingWorkflowJobStepConclusion? conclusion,
            string name,
            int number,
            string? startedAt,
            global::GitHub.WebhookWorkflowJobWaitingWorkflowJobStepStatus status)
        {
            this.CompletedAt = completedAt ?? throw new global::System.ArgumentNullException(nameof(completedAt));
            this.Conclusion = conclusion;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Number = number;
            this.StartedAt = startedAt ?? throw new global::System.ArgumentNullException(nameof(startedAt));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobWaitingWorkflowJobStep" /> class.
        /// </summary>
        public WebhookWorkflowJobWaitingWorkflowJobStep()
        {
        }
    }
}