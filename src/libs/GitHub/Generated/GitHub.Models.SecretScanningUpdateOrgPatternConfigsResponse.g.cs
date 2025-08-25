
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningUpdateOrgPatternConfigsResponse
    {
        /// <summary>
        /// The updated pattern configuration version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_config_version")]
        public string? PatternConfigVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateOrgPatternConfigsResponse" /> class.
        /// </summary>
        /// <param name="patternConfigVersion">
        /// The updated pattern configuration version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningUpdateOrgPatternConfigsResponse(
            string? patternConfigVersion)
        {
            this.PatternConfigVersion = patternConfigVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateOrgPatternConfigsResponse" /> class.
        /// </summary>
        public SecretScanningUpdateOrgPatternConfigsResponse()
        {
        }
    }
}