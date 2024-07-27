
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityCreateConfigurationRequest
    {
        /// <summary>
        /// The name of the code security configuration. Must be unique within the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestAdvancedSecurityJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity? AdvancedSecurity { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity.Disabled;

        /// <summary>
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestDependencyGraphJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestDependencyGraph? DependencyGraph { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestDependencyGraph.Enabled;

        /// <summary>
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotAlertsJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestDependabotAlerts? DependabotAlerts { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestDependabotAlerts.Disabled;

        /// <summary>
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdatesJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.Disabled;

        /// <summary>
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetupJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.Disabled;

        /// <summary>
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanning? SecretScanning { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanning.Disabled;

        /// <summary>
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningPushProtectionJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.Disabled;

        /// <summary>
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecksJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.Disabled;

        /// <summary>
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReportingJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting.Disabled;

        /// <summary>
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecurityCreateConfigurationRequestEnforcementJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestEnforcement? Enforcement { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestEnforcement.Enforced;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}