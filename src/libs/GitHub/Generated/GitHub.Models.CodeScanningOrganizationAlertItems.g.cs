
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningOrganizationAlertItems
    {
        /// <summary>
        /// The security alert number.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int Number { get; set; } = default!;

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The REST API URL for fetching the list of instances for an alert.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("instances_url")]
        public string InstancesUrl { get; set; } = default!;

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningAlertStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningAlertState? State { get; set; }

        /// <summary>
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed_at")]
        public global::System.DateTime? FixedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableSimpleUser? DismissedBy { get; set; }

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_at")]
        public global::System.DateTime? DismissedAt { get; set; }

        /// <summary>
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningAlertDismissedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningAlertDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// The dismissal comment associated with the dismissal of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningAlertRuleSummary Rule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningAnalysisTool Tool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_instance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningAlertInstance MostRecentInstance { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleRepository Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissal_approved_by")]
        public global::GitHub.NullableSimpleUser? DismissalApprovedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningOrganizationAlertItems" /> class.
        /// </summary>
        /// <param name="number">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="instancesUrl">
        /// The REST API URL for fetching the list of instances for an alert.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        /// <param name="fixedAt">
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dismissedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="dismissedAt">
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dismissedReason">
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </param>
        /// <param name="dismissedComment">
        /// The dismissal comment associated with the dismissal of the alert.
        /// </param>
        /// <param name="rule"></param>
        /// <param name="tool"></param>
        /// <param name="mostRecentInstance"></param>
        /// <param name="repository">
        /// A GitHub repository.
        /// </param>
        /// <param name="dismissalApprovedBy">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningOrganizationAlertItems(
            global::GitHub.CodeScanningAlertState? state,
            global::GitHub.NullableSimpleUser? dismissedBy,
            global::GitHub.CodeScanningAlertDismissedReason? dismissedReason,
            global::GitHub.CodeScanningAlertRuleSummary rule,
            global::GitHub.CodeScanningAnalysisTool tool,
            global::GitHub.CodeScanningAlertInstance mostRecentInstance,
            global::GitHub.SimpleRepository repository,
            global::System.DateTime? updatedAt,
            global::System.DateTime? fixedAt,
            global::System.DateTime? dismissedAt,
            string? dismissedComment,
            global::GitHub.NullableSimpleUser? dismissalApprovedBy,
            int number = default!,
            global::System.DateTime createdAt = default!,
            string url = default!,
            string htmlUrl = default!,
            string instancesUrl = default!)
        {
            this.State = state;
            this.DismissedBy = dismissedBy ?? throw new global::System.ArgumentNullException(nameof(dismissedBy));
            this.DismissedReason = dismissedReason;
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.MostRecentInstance = mostRecentInstance ?? throw new global::System.ArgumentNullException(nameof(mostRecentInstance));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Number = number;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.InstancesUrl = instancesUrl;
            this.FixedAt = fixedAt;
            this.DismissedAt = dismissedAt;
            this.DismissedComment = dismissedComment;
            this.DismissalApprovedBy = dismissalApprovedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningOrganizationAlertItems" /> class.
        /// </summary>
        public CodeScanningOrganizationAlertItems()
        {
        }
    }
}