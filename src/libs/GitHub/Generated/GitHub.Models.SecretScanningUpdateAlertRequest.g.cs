
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningUpdateAlertRequest
    {
        /// <summary>
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecretScanningAlertStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SecretScanningAlertState State { get; set; }

        /// <summary>
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecretScanningAlertResolutionJsonConverter))]
        public global::GitHub.SecretScanningAlertResolution? Resolution { get; set; }

        /// <summary>
        /// An optional comment when closing or reopening an alert. Cannot be updated or deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_comment")]
        public string? ResolutionComment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateAlertRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </param>
        /// <param name="resolution">
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </param>
        /// <param name="resolutionComment">
        /// An optional comment when closing or reopening an alert. Cannot be updated or deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningUpdateAlertRequest(
            global::GitHub.SecretScanningAlertState state,
            global::GitHub.SecretScanningAlertResolution? resolution,
            string? resolutionComment)
        {
            this.State = state;
            this.Resolution = resolution;
            this.ResolutionComment = resolutionComment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateAlertRequest" /> class.
        /// </summary>
        public SecretScanningUpdateAlertRequest()
        {
        }
    }
}