
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityAndAnalysis
    {
        /// <summary>
        /// Enable or disable GitHub Advanced Security for the repository.<br/>
        /// For standalone Code Scanning or Secret Protection products, this parameter cannot be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        public global::GitHub.SecurityAndAnalysisAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_security")]
        public global::GitHub.SecurityAndAnalysisCodeSecurity? CodeSecurity { get; set; }

        /// <summary>
        /// Enable or disable Dependabot security updates for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        public global::GitHub.SecurityAndAnalysisDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        public global::GitHub.SecurityAndAnalysisSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        public global::GitHub.SecurityAndAnalysisSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        public global::GitHub.SecurityAndAnalysisSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_ai_detection")]
        public global::GitHub.SecurityAndAnalysisSecretScanningAiDetection? SecretScanningAiDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysis" /> class.
        /// </summary>
        /// <param name="advancedSecurity">
        /// Enable or disable GitHub Advanced Security for the repository.<br/>
        /// For standalone Code Scanning or Secret Protection products, this parameter cannot be used.
        /// </param>
        /// <param name="codeSecurity"></param>
        /// <param name="dependabotSecurityUpdates">
        /// Enable or disable Dependabot security updates for the repository.
        /// </param>
        /// <param name="secretScanning"></param>
        /// <param name="secretScanningPushProtection"></param>
        /// <param name="secretScanningNonProviderPatterns"></param>
        /// <param name="secretScanningAiDetection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityAndAnalysis(
            global::GitHub.SecurityAndAnalysisAdvancedSecurity? advancedSecurity,
            global::GitHub.SecurityAndAnalysisCodeSecurity? codeSecurity,
            global::GitHub.SecurityAndAnalysisDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::GitHub.SecurityAndAnalysisSecretScanning? secretScanning,
            global::GitHub.SecurityAndAnalysisSecretScanningPushProtection? secretScanningPushProtection,
            global::GitHub.SecurityAndAnalysisSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::GitHub.SecurityAndAnalysisSecretScanningAiDetection? secretScanningAiDetection)
        {
            this.AdvancedSecurity = advancedSecurity;
            this.CodeSecurity = codeSecurity;
            this.DependabotSecurityUpdates = dependabotSecurityUpdates;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
            this.SecretScanningAiDetection = secretScanningAiDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysis" /> class.
        /// </summary>
        public SecurityAndAnalysis()
        {
        }
    }
}