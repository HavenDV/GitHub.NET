
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Workflow Usage
    /// </summary>
    public sealed partial class WorkflowUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WorkflowUsageBillable Billable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}