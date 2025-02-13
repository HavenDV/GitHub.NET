
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The code scanning alert involved in the event.
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertClosedByUserAlert
    {
        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DismissedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissedBy? DismissedBy { get; set; }

        /// <summary>
        /// The dismissal comment associated with the dismissal of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// The reason for dismissing or closing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCodeScanningAlertClosedByUserAlertDismissedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// The time that the alert was fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed_at")]
        public object? FixedAt { get; set; }

        /// <summary>
        /// The GitHub URL of the alert resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_instance")]
        public global::GitHub.WebhookCodeScanningAlertClosedByUserAlertMostRecentInstance? MostRecentInstance { get; set; }

        /// <summary>
        /// The code scanning alert number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookCodeScanningAlertClosedByUserAlertRule Rule { get; set; }

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCodeScanningAlertClosedByUserAlertStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookCodeScanningAlertClosedByUserAlertState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookCodeScanningAlertClosedByUserAlertTool Tool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissal_approved_by")]
        public global::GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedBy? DismissalApprovedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertClosedByUserAlert" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </param>
        /// <param name="dismissedAt">
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="dismissedBy"></param>
        /// <param name="dismissedComment">
        /// The dismissal comment associated with the dismissal of the alert.
        /// </param>
        /// <param name="dismissedReason">
        /// The reason for dismissing or closing the alert.
        /// </param>
        /// <param name="fixedAt">
        /// The time that the alert was fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.
        /// </param>
        /// <param name="mostRecentInstance"></param>
        /// <param name="number">
        /// The code scanning alert number.
        /// </param>
        /// <param name="rule"></param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        /// <param name="tool"></param>
        /// <param name="url"></param>
        /// <param name="dismissalApprovedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCodeScanningAlertClosedByUserAlert(
            global::System.DateTime createdAt,
            global::System.DateTime dismissedAt,
            global::GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissedBy? dismissedBy,
            global::GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissedReason? dismissedReason,
            string htmlUrl,
            int number,
            global::GitHub.WebhookCodeScanningAlertClosedByUserAlertRule rule,
            global::GitHub.WebhookCodeScanningAlertClosedByUserAlertState state,
            global::GitHub.WebhookCodeScanningAlertClosedByUserAlertTool tool,
            string url,
            string? dismissedComment,
            object? fixedAt,
            global::GitHub.WebhookCodeScanningAlertClosedByUserAlertMostRecentInstance? mostRecentInstance,
            global::GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedBy? dismissalApprovedBy)
        {
            this.CreatedAt = createdAt;
            this.DismissedAt = dismissedAt;
            this.DismissedBy = dismissedBy ?? throw new global::System.ArgumentNullException(nameof(dismissedBy));
            this.DismissedReason = dismissedReason;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Number = number;
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
            this.State = state;
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.DismissedComment = dismissedComment;
            this.FixedAt = fixedAt;
            this.MostRecentInstance = mostRecentInstance;
            this.DismissalApprovedBy = dismissalApprovedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertClosedByUserAlert" /> class.
        /// </summary>
        public WebhookCodeScanningAlertClosedByUserAlert()
        {
        }
    }
}