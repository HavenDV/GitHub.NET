
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Provides details of a particular machine spec.
    /// </summary>
    public sealed partial class ActionsHostedRunnerMachineSpec
    {
        /// <summary>
        /// The ID used for the `size` parameter when creating a new runner.<br/>
        /// Example: 8-core
        /// </summary>
        /// <example>8-core</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The number of cores.<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_cores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CpuCores { get; set; }

        /// <summary>
        /// The available RAM for the machine spec.<br/>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryGb { get; set; }

        /// <summary>
        /// The available SSD storage for the machine spec.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StorageGb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerMachineSpec" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID used for the `size` parameter when creating a new runner.<br/>
        /// Example: 8-core
        /// </param>
        /// <param name="cpuCores">
        /// The number of cores.<br/>
        /// Example: 8
        /// </param>
        /// <param name="memoryGb">
        /// The available RAM for the machine spec.<br/>
        /// Example: 32
        /// </param>
        /// <param name="storageGb">
        /// The available SSD storage for the machine spec.<br/>
        /// Example: 300
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsHostedRunnerMachineSpec(
            string id,
            int cpuCores,
            int memoryGb,
            int storageGb)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CpuCores = cpuCores;
            this.MemoryGb = memoryGb;
            this.StorageGb = storageGb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerMachineSpec" /> class.
        /// </summary>
        public ActionsHostedRunnerMachineSpec()
        {
        }
    }
}