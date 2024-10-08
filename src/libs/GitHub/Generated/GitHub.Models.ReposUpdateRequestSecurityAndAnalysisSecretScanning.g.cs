
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Use the `status` property to enable or disable secret scanning for this repository. For more information, see "[About secret scanning](/code-security/secret-security/about-secret-scanning)."
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysisSecretScanning
    {
        /// <summary>
        /// Can be `enabled` or `disabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}