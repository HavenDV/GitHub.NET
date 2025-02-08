
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGetHostedRunnersMachineSpecsForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine_specs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.ActionsHostedRunnerMachineSpec> MachineSpecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetHostedRunnersMachineSpecsForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="machineSpecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsGetHostedRunnersMachineSpecsForOrgResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::GitHub.ActionsHostedRunnerMachineSpec> machineSpecs)
        {
            this.TotalCount = totalCount;
            this.MachineSpecs = machineSpecs ?? throw new global::System.ArgumentNullException(nameof(machineSpecs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetHostedRunnersMachineSpecsForOrgResponse" /> class.
        /// </summary>
        public ActionsGetHostedRunnersMachineSpecsForOrgResponse()
        {
        }
    }
}