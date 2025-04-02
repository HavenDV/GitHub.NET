
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
        /// Use the `status` property to enable or disable GitHub Code Security for this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_security")]
        public global::GitHub.ReposUpdateRequestSecurityAndAnalysisCodeSecurity? CodeSecurity { get; set; }

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
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysis" /> class.
        /// </summary>
        /// <param name="advancedSecurity">
        /// Use the `status` property to enable or disable GitHub Advanced Security for this repository. For more information, see "[About GitHub Advanced Security](/github/getting-started-with-github/learning-about-github/about-github-advanced-security)."
        /// </param>
        /// <param name="codeSecurity">
        /// Use the `status` property to enable or disable GitHub Code Security for this repository.
        /// </param>
        /// <param name="secretScanning">
        /// Use the `status` property to enable or disable secret scanning for this repository. For more information, see "[About secret scanning](/code-security/secret-security/about-secret-scanning)."
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// Use the `status` property to enable or disable secret scanning push protection for this repository. For more information, see "[Protecting pushes with secret scanning](/code-security/secret-scanning/protecting-pushes-with-secret-scanning)."
        /// </param>
        /// <param name="secretScanningAiDetection">
        /// Use the `status` property to enable or disable secret scanning AI detection for this repository. For more information, see "[Responsible detection of generic secrets with AI](https://docs.github.com/code-security/secret-scanning/using-advanced-secret-scanning-and-push-protection-features/generic-secret-detection/responsible-ai-generic-secrets)."
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// Use the `status` property to enable or disable secret scanning non-provider patterns for this repository. For more information, see "[Supported secret scanning patterns](/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)."
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateRequestSecurityAndAnalysis(
            global::GitHub.ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity? advancedSecurity,
            global::GitHub.ReposUpdateRequestSecurityAndAnalysisCodeSecurity? codeSecurity,
            global::GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanning? secretScanning,
            global::GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection? secretScanningPushProtection,
            global::GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningAiDetection? secretScanningAiDetection,
            global::GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns)
        {
            this.AdvancedSecurity = advancedSecurity;
            this.CodeSecurity = codeSecurity;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningAiDetection = secretScanningAiDetection;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysis" /> class.
        /// </summary>
        public ReposUpdateRequestSecurityAndAnalysis()
        {
        }
    }
}