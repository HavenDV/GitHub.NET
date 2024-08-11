
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A run of a CodeQL query against one or more repositories.
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysis
    {
        /// <summary>
        /// The ID of the variant analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controller_repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleRepository ControllerRepo { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleUser Actor { get; set; }

        /// <summary>
        /// The language targeted by the CodeQL query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeScanningVariantAnalysisLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningVariantAnalysisLanguage QueryLanguage { get; set; }

        /// <summary>
        /// The download url for the query pack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_pack_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueryPackUrl { get; set; }

        /// <summary>
        /// The date and time at which the variant analysis was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time at which the variant analysis was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The date and time at which the variant analysis was completed, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ. Will be null if the variant analysis has not yet completed or this information is not available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeScanningVariantAnalysisStatus2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningVariantAnalysisStatus2 Status { get; set; }

        /// <summary>
        /// The GitHub Actions workflow run used to execute this variant analysis. This is only available if the workflow run has started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions_workflow_run_id")]
        public int ActionsWorkflowRunId { get; set; }

        /// <summary>
        /// The reason for a failure of the variant analysis. This is only available if the variant analysis has failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeScanningVariantAnalysisFailureReasonJsonConverter))]
        public global::GitHub.CodeScanningVariantAnalysisFailureReason? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanned_repositories")]
        public global::System.Collections.Generic.IList<global::GitHub.CodeScanningVariantAnalysisScannedRepositorie>? ScannedRepositories { get; set; }

        /// <summary>
        /// Information about repositories that were skipped from processing. This information is only available to the user that initiated the variant analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_repositories")]
        public global::GitHub.CodeScanningVariantAnalysisSkippedRepositories? SkippedRepositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}