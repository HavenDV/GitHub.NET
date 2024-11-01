
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Specify which security and analysis features to enable or disable for the repository.<br/>
    /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
    /// For example, to enable GitHub Advanced Security, use this data in the body of the `PATCH` request:<br/>
    /// `{ "security_and_analysis": {"advanced_security": { "status": "enabled" } } }`.<br/>
    /// You can check which security and analysis features are currently enabled by using a `GET /repos/{owner}/{repo}` request.
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysis
    {
        /// <summary>
        /// Use the `status` property to enable or disable GitHub Advanced Security for this repository. For more information, see "[About GitHub Advanced Security](/github/getting-started-with-github/learning-about-github/about-github-advanced-security)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        public global::GitHub.ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning for this repository. For more information, see "[About secret scanning](/code-security/secret-security/about-secret-scanning)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        public global::GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning push protection for this repository. For more information, see "[Protecting pushes with secret scanning](/code-security/secret-scanning/protecting-pushes-with-secret-scanning)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        public global::GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning AI detection for this repository. For more information, see "[Responsible detection of generic secrets with AI](https://docs.github.com/code-security/secret-scanning/using-advanced-secret-scanning-and-push-protection-features/generic-secret-detection/responsible-ai-generic-secrets)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_ai_detection")]
        public global::GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningAiDetection? SecretScanningAiDetection { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning non-provider patterns for this repository. For more information, see "[Supported secret scanning patterns](/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        public global::GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::GitHub.ReposUpdateRequestSecurityAndAnalysis? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.ReposUpdateRequestSecurityAndAnalysis),
                jsonSerializerContext) as global::GitHub.ReposUpdateRequestSecurityAndAnalysis;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.ReposUpdateRequestSecurityAndAnalysis? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.ReposUpdateRequestSecurityAndAnalysis>(
                json,
                jsonSerializerOptions);
        }

    }
}