
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAlertInstance
    {
        /// <summary>
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_key")]
        public string? AnalysisKey { get; set; }

        /// <summary>
        /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeScanningAlertStateJsonConverter))]
        public global::GitHub.CodeScanningAlertState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_sha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::GitHub.CodeScanningAlertInstanceMessage? Message { get; set; }

        /// <summary>
        /// Describe a region within a file for the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::GitHub.CodeScanningAlertLocation? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Classifications that have been applied to the file that triggered the alert.<br/>
        /// For example identifying it as documentation, or a generated file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifications")]
        public global::System.Collections.Generic.IList<global::GitHub.CodeScanningAlertClassification>? Classifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}