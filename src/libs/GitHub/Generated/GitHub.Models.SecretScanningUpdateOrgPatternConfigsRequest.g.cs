
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningUpdateOrgPatternConfigsRequest
    {
        /// <summary>
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_config_version")]
        public string? PatternConfigVersion { get; set; }

        /// <summary>
        /// Pattern settings for provider patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_pattern_settings")]
        public global::System.Collections.Generic.IList<global::GitHub.SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSetting>? ProviderPatternSettings { get; set; }

        /// <summary>
        /// Pattern settings for custom patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_settings")]
        public global::System.Collections.Generic.IList<global::GitHub.SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSetting>? CustomPatternSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateOrgPatternConfigsRequest" /> class.
        /// </summary>
        /// <param name="patternConfigVersion">
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </param>
        /// <param name="providerPatternSettings">
        /// Pattern settings for provider patterns.
        /// </param>
        /// <param name="customPatternSettings">
        /// Pattern settings for custom patterns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningUpdateOrgPatternConfigsRequest(
            string? patternConfigVersion,
            global::System.Collections.Generic.IList<global::GitHub.SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSetting>? providerPatternSettings,
            global::System.Collections.Generic.IList<global::GitHub.SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSetting>? customPatternSettings)
        {
            this.PatternConfigVersion = patternConfigVersion;
            this.ProviderPatternSettings = providerPatternSettings;
            this.CustomPatternSettings = customPatternSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateOrgPatternConfigsRequest" /> class.
        /// </summary>
        public SecretScanningUpdateOrgPatternConfigsRequest()
        {
        }
    }
}