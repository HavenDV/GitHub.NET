
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertCreatedAlertMostRecentInstance
    {
        /// <summary>
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnalysisKey { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifications")]
        public global::System.Collections.Generic.IList<string>? Classifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_sha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::GitHub.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceLocation? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::GitHub.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceMessage? Message { get; set; }

        /// <summary>
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertCreatedAlertMostRecentInstance" /> class.
        /// </summary>
        /// <param name="analysisKey">
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </param>
        /// <param name="category">
        /// Identifies the configuration under which the analysis was executed.
        /// </param>
        /// <param name="classifications"></param>
        /// <param name="commitSha"></param>
        /// <param name="environment">
        /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
        /// </param>
        /// <param name="location"></param>
        /// <param name="message"></param>
        /// <param name="ref">
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`.
        /// </param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCodeScanningAlertCreatedAlertMostRecentInstance(
            string analysisKey,
            string environment,
            string @ref,
            global::GitHub.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState state,
            string? category,
            global::System.Collections.Generic.IList<string>? classifications,
            string? commitSha,
            global::GitHub.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceLocation? location,
            global::GitHub.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceMessage? message)
        {
            this.AnalysisKey = analysisKey ?? throw new global::System.ArgumentNullException(nameof(analysisKey));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.State = state;
            this.Category = category;
            this.Classifications = classifications;
            this.CommitSha = commitSha;
            this.Location = location;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertCreatedAlertMostRecentInstance" /> class.
        /// </summary>
        public WebhookCodeScanningAlertCreatedAlertMostRecentInstance()
        {
        }
    }
}