
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningCreatePushProtectionBypassRequest
    {
        /// <summary>
        /// The reason for bypassing push protection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SecretScanningPushProtectionBypassReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SecretScanningPushProtectionBypassReason Reason { get; set; }

        /// <summary>
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaceholderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}