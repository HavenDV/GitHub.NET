
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowUsageBillable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UBUNTU")]
        public global::GitHub.WorkflowUsageBillableUBUNTU? UBUNTU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MACOS")]
        public global::GitHub.WorkflowUsageBillableMACOS? MACOS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("WINDOWS")]
        public global::GitHub.WorkflowUsageBillableWINDOWS? WINDOWS { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillable" /> class.
        /// </summary>
        /// <param name="uBUNTU"></param>
        /// <param name="mACOS"></param>
        /// <param name="wINDOWS"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WorkflowUsageBillable(
            global::GitHub.WorkflowUsageBillableUBUNTU? uBUNTU,
            global::GitHub.WorkflowUsageBillableMACOS? mACOS,
            global::GitHub.WorkflowUsageBillableWINDOWS? wINDOWS)
        {
            this.UBUNTU = uBUNTU;
            this.MACOS = mACOS;
            this.WINDOWS = wINDOWS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillable" /> class.
        /// </summary>
        public WorkflowUsageBillable()
        {
        }
    }
}