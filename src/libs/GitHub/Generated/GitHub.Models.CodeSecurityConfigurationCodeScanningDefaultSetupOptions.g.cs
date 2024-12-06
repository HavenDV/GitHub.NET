
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Feature options for code scanning default setup
    /// </summary>
    public sealed partial class CodeSecurityConfigurationCodeScanningDefaultSetupOptions
    {
        /// <summary>
        /// Whether to use labeled runners or standard GitHub runners.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerTypeJsonConverter))]
        public global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType? RunnerType { get; set; }

        /// <summary>
        /// The label of the runner to use for code scanning when runner_type is 'labeled'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_label")]
        public string? RunnerLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationCodeScanningDefaultSetupOptions" /> class.
        /// </summary>
        /// <param name="runnerType">
        /// Whether to use labeled runners or standard GitHub runners.
        /// </param>
        /// <param name="runnerLabel">
        /// The label of the runner to use for code scanning when runner_type is 'labeled'.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeSecurityConfigurationCodeScanningDefaultSetupOptions(
            global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType? runnerType,
            string? runnerLabel)
        {
            this.RunnerType = runnerType;
            this.RunnerLabel = runnerLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationCodeScanningDefaultSetupOptions" /> class.
        /// </summary>
        public CodeSecurityConfigurationCodeScanningDefaultSetupOptions()
        {
        }
    }
}