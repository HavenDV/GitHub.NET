
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestAdvancedSecurityJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity? AdvancedSecurity { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity.Disabled;

        /// <summary>
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependencyGraphJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestDependencyGraph? DependencyGraph { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestDependencyGraph.Enabled;

        /// <summary>
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.Disabled;

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotAlertsJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestDependabotAlerts? DependabotAlerts { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestDependabotAlerts.Disabled;

        /// <summary>
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdatesJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.Disabled;

        /// <summary>
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetupJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.Disabled;

        /// <summary>
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanning? SecretScanning { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanning.Disabled;

        /// <summary>
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningPushProtectionJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.Disabled;

        /// <summary>
        /// The enablement status of secret scanning delegated bypass<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass? SecretScanningDelegatedBypass { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Disabled;

        /// <summary>
        /// Feature options for secret scanning delegated bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass_options")]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptions? SecretScanningDelegatedBypassOptions { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecksJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.Disabled;

        /// <summary>
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatternsJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.Disabled;

        /// <summary>
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReportingJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting.Disabled;

        /// <summary>
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestEnforcementJsonConverter))]
        public global::GitHub.CodeSecurityCreateConfigurationRequestEnforcement? Enforcement { get; set; } = global::GitHub.CodeSecurityCreateConfigurationRequestEnforcement.Enforced;

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
        public static global::GitHub.CodeSecurityCreateConfigurationRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.CodeSecurityCreateConfigurationRequest),
                jsonSerializerContext) as global::GitHub.CodeSecurityCreateConfigurationRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.CodeSecurityCreateConfigurationRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.CodeSecurityCreateConfigurationRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}