
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityUpdateEnterpriseConfigurationRequest
    {
        /// <summary>
        /// The name of the code security configuration. Must be unique across the enterprise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurityJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitActionJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlertsJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdatesJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetupJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// Feature options for code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup_options")]
        public global::GitHub.CodeScanningDefaultSetupOptions? CodeScanningDefaultSetupOptions { get; set; }

        /// <summary>
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissalJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal? CodeScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of secret scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtectionJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecksJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non-provider patterns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatternsJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_generic_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecretsJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets? SecretScanningGenericSecrets { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningDelegatedAlertDismissalJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningDelegatedAlertDismissal? SecretScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestPrivateVulnerabilityReportingJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestEnforcementJsonConverter))]
        public global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement? Enforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateEnterpriseConfigurationRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique across the enterprise.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup
        /// </param>
        /// <param name="codeScanningDefaultSetupOptions">
        /// Feature options for code scanning default setup
        /// </param>
        /// <param name="codeScanningDelegatedAlertDismissal">
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non-provider patterns
        /// </param>
        /// <param name="secretScanningGenericSecrets">
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedAlertDismissal">
        /// The enablement status of secret scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityUpdateEnterpriseConfigurationRequest(
            string? name,
            string? description,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity? advancedSecurity,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph? dependencyGraph,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts? dependabotAlerts,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::GitHub.CodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning? secretScanning,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets? secretScanningGenericSecrets,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement? enforcement)
        {
            this.Name = name;
            this.Description = description;
            this.AdvancedSecurity = advancedSecurity;
            this.DependencyGraph = dependencyGraph;
            this.DependencyGraphAutosubmitAction = dependencyGraphAutosubmitAction;
            this.DependencyGraphAutosubmitActionOptions = dependencyGraphAutosubmitActionOptions;
            this.DependabotAlerts = dependabotAlerts;
            this.DependabotSecurityUpdates = dependabotSecurityUpdates;
            this.CodeScanningDefaultSetup = codeScanningDefaultSetup;
            this.CodeScanningDefaultSetupOptions = codeScanningDefaultSetupOptions;
            this.CodeScanningDelegatedAlertDismissal = codeScanningDelegatedAlertDismissal;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningValidityChecks = secretScanningValidityChecks;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
            this.SecretScanningGenericSecrets = secretScanningGenericSecrets;
            this.SecretScanningDelegatedAlertDismissal = secretScanningDelegatedAlertDismissal;
            this.PrivateVulnerabilityReporting = privateVulnerabilityReporting;
            this.Enforcement = enforcement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateEnterpriseConfigurationRequest" /> class.
        /// </summary>
        public CodeSecurityUpdateEnterpriseConfigurationRequest()
        {
        }
    }
}