
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSetting
    {
        /// <summary>
        /// The ID of the pattern to configure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// Push protection setting to set for the pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSettingJsonConverter))]
        public global::GitHub.SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting? PushProtectionSetting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSetting" /> class.
        /// </summary>
        /// <param name="tokenType">
        /// The ID of the pattern to configure.
        /// </param>
        /// <param name="pushProtectionSetting">
        /// Push protection setting to set for the pattern.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSetting(
            string? tokenType,
            global::GitHub.SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting? pushProtectionSetting)
        {
            this.TokenType = tokenType;
            this.PushProtectionSetting = pushProtectionSetting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSetting" /> class.
        /// </summary>
        public SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSetting()
        {
        }
    }
}