
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A collection of secret scanning patterns and their settings related to push protection.
    /// </summary>
    public sealed partial class SecretScanningPatternConfiguration
    {
        /// <summary>
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_config_version")]
        public string? PatternConfigVersion { get; set; }

        /// <summary>
        /// Overrides for partner patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_pattern_overrides")]
        public global::System.Collections.Generic.IList<global::GitHub.SecretScanningPatternOverride>? ProviderPatternOverrides { get; set; }

        /// <summary>
        /// Overrides for custom patterns defined by the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_overrides")]
        public global::System.Collections.Generic.IList<global::GitHub.SecretScanningPatternOverride>? CustomPatternOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningPatternConfiguration" /> class.
        /// </summary>
        /// <param name="patternConfigVersion">
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </param>
        /// <param name="providerPatternOverrides">
        /// Overrides for partner patterns.
        /// </param>
        /// <param name="customPatternOverrides">
        /// Overrides for custom patterns defined by the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningPatternConfiguration(
            string? patternConfigVersion,
            global::System.Collections.Generic.IList<global::GitHub.SecretScanningPatternOverride>? providerPatternOverrides,
            global::System.Collections.Generic.IList<global::GitHub.SecretScanningPatternOverride>? customPatternOverrides)
        {
            this.PatternConfigVersion = patternConfigVersion;
            this.ProviderPatternOverrides = providerPatternOverrides;
            this.CustomPatternOverrides = customPatternOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningPatternConfiguration" /> class.
        /// </summary>
        public SecretScanningPatternConfiguration()
        {
        }
    }
}