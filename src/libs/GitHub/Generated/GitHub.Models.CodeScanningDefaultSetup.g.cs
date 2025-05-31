
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetup
    {
        /// <summary>
        /// Code scanning default setup has been configured or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningDefaultSetupStateJsonConverter))]
        public global::GitHub.CodeScanningDefaultSetupState? State { get; set; }

        /// <summary>
        /// Languages to be analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::GitHub.CodeScanningDefaultSetupLanguage>? Languages { get; set; }

        /// <summary>
        /// Runner type to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningDefaultSetupRunnerTypeJsonConverter))]
        public global::GitHub.CodeScanningDefaultSetupRunnerType? RunnerType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningDefaultSetupQuerySuiteJsonConverter))]
        public global::GitHub.CodeScanningDefaultSetupQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// Threat model to be used for code scanning analysis. Use `remote` to analyze only network sources and `remote_and_local` to include local sources like filesystem access, command-line arguments, database reads, environment variable and standard input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threat_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningDefaultSetupThreatModelJsonConverter))]
        public global::GitHub.CodeScanningDefaultSetupThreatModel? ThreatModel { get; set; }

        /// <summary>
        /// Timestamp of latest configuration update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The frequency of the periodic analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningDefaultSetupScheduleJsonConverter))]
        public global::GitHub.CodeScanningDefaultSetupSchedule? Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetup" /> class.
        /// </summary>
        /// <param name="state">
        /// Code scanning default setup has been configured or not.
        /// </param>
        /// <param name="languages">
        /// Languages to be analyzed.
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
        /// <param name="threatModel">
        /// Threat model to be used for code scanning analysis. Use `remote` to analyze only network sources and `remote_and_local` to include local sources like filesystem access, command-line arguments, database reads, environment variable and standard input.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of latest configuration update.
        /// </param>
        /// <param name="schedule">
        /// The frequency of the periodic analysis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningDefaultSetup(
            global::GitHub.CodeScanningDefaultSetupState? state,
            global::System.Collections.Generic.IList<global::GitHub.CodeScanningDefaultSetupLanguage>? languages,
            global::GitHub.CodeScanningDefaultSetupRunnerType? runnerType,
            string? runnerLabel,
            global::GitHub.CodeScanningDefaultSetupQuerySuite? querySuite,
            global::GitHub.CodeScanningDefaultSetupThreatModel? threatModel,
            global::System.DateTime? updatedAt,
            global::GitHub.CodeScanningDefaultSetupSchedule? schedule)
        {
            this.State = state;
            this.Languages = languages;
            this.RunnerType = runnerType;
            this.RunnerLabel = runnerLabel;
            this.QuerySuite = querySuite;
            this.ThreatModel = threatModel;
            this.UpdatedAt = updatedAt;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetup" /> class.
        /// </summary>
        public CodeScanningDefaultSetup()
        {
        }
    }
}