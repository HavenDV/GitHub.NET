
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Use the `status` property to enable or disable secret scanning AI detection for this repository. For more information, see "[Responsible detection of generic secrets with AI](https://docs.github.com/code-security/secret-scanning/using-advanced-secret-scanning-and-push-protection-features/generic-secret-detection/responsible-ai-generic-secrets)."
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysisSecretScanningAiDetection
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