
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningUpdateAlertRequest
    {
        /// <summary>
        /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningAlertSetStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningAlertSetState State { get; set; }

        /// <summary>
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningAlertDismissedReasonJsonConverter))]
        public global::GitHub.CodeScanningAlertDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// The dismissal comment associated with the dismissal of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// If `true`, attempt to create an alert dismissal request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_request")]
        public bool? CreateRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningUpdateAlertRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
        /// </param>
        /// <param name="dismissedReason">
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </param>
        /// <param name="dismissedComment">
        /// The dismissal comment associated with the dismissal of the alert.
        /// </param>
        /// <param name="createRequest">
        /// If `true`, attempt to create an alert dismissal request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningUpdateAlertRequest(
            global::GitHub.CodeScanningAlertSetState state,
            global::GitHub.CodeScanningAlertDismissedReason? dismissedReason,
            string? dismissedComment,
            bool? createRequest)
        {
            this.State = state;
            this.DismissedReason = dismissedReason;
            this.DismissedComment = dismissedComment;
            this.CreateRequest = createRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningUpdateAlertRequest" /> class.
        /// </summary>
        public CodeScanningUpdateAlertRequest()
        {
        }
    }
}