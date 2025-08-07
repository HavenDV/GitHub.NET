
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSetting
    {
        /// <summary>
        /// The ID of the pattern to configure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_version")]
        public string? CustomPatternVersion { get; set; }

        /// <summary>
        /// Push protection setting to set for the pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSettingJsonConverter))]
        public global::GitHub.SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting? PushProtectionSetting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSetting" /> class.
        /// </summary>
        /// <param name="tokenType">
        /// The ID of the pattern to configure.
        /// </param>
        /// <param name="customPatternVersion">
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </param>
        /// <param name="pushProtectionSetting">
        /// Push protection setting to set for the pattern.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSetting(
            string? tokenType,
            string? customPatternVersion,
            global::GitHub.SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting? pushProtectionSetting)
        {
            this.TokenType = tokenType;
            this.CustomPatternVersion = customPatternVersion;
            this.PushProtectionSetting = pushProtectionSetting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSetting" /> class.
        /// </summary>
        public SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSetting()
        {
        }
    }
}