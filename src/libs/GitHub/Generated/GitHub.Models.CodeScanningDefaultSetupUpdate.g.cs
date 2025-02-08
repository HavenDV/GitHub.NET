
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetupUpdate
    {
        /// <summary>
        /// The desired state of code scanning default setup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningDefaultSetupUpdateStateJsonConverter))]
        public global::GitHub.CodeScanningDefaultSetupUpdateState? State { get; set; }

        /// <summary>
        /// Runner type to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningDefaultSetupUpdateRunnerTypeJsonConverter))]
        public global::GitHub.CodeScanningDefaultSetupUpdateRunnerType? RunnerType { get; set; }

        /// <summary>
        /// Runner label to be used if the runner type is labeled.<br/>
        /// Example: code-scanning
        /// </summary>
        /// <example>code-scanning</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_label")]
        public string? RunnerLabel { get; set; }

        /// <summary>
        /// CodeQL query suite to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_suite")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningDefaultSetupUpdateQuerySuiteJsonConverter))]
        public global::GitHub.CodeScanningDefaultSetupUpdateQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// CodeQL languages to be analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::GitHub.CodeScanningDefaultSetupUpdateLanguage>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetupUpdate" /> class.
        /// </summary>
        /// <param name="state">
        /// The desired state of code scanning default setup.
        /// </param>
        /// <param name="runnerType">
        /// Runner type to be used.
        /// </param>
        /// <param name="runnerLabel">
        /// Runner label to be used if the runner type is labeled.<br/>
        /// Example: code-scanning
        /// </param>
        /// <param name="querySuite">
        /// CodeQL query suite to be used.
        /// </param>
        /// <param name="languages">
        /// CodeQL languages to be analyzed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningDefaultSetupUpdate(
            global::GitHub.CodeScanningDefaultSetupUpdateState? state,
            global::GitHub.CodeScanningDefaultSetupUpdateRunnerType? runnerType,
            string? runnerLabel,
            global::GitHub.CodeScanningDefaultSetupUpdateQuerySuite? querySuite,
            global::System.Collections.Generic.IList<global::GitHub.CodeScanningDefaultSetupUpdateLanguage>? languages)
        {
            this.State = state;
            this.RunnerType = runnerType;
            this.RunnerLabel = runnerLabel;
            this.QuerySuite = querySuite;
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetupUpdate" /> class.
        /// </summary>
        public CodeScanningDefaultSetupUpdate()
        {
        }
    }
}