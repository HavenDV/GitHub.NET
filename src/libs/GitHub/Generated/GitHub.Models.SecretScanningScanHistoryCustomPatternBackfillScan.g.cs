
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningScanHistoryCustomPatternBackfillScan
    {
        /// <summary>
        /// Name of the custom pattern for custom pattern scans
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_name")]
        public string? PatternName { get; set; }

        /// <summary>
        /// Level at which the custom pattern is defined, one of "repository", "organization", or "enterprise"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_scope")]
        public string? PatternScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningScanHistoryCustomPatternBackfillScan" /> class.
        /// </summary>
        /// <param name="patternName">
        /// Name of the custom pattern for custom pattern scans
        /// </param>
        /// <param name="patternScope">
        /// Level at which the custom pattern is defined, one of "repository", "organization", or "enterprise"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SecretScanningScanHistoryCustomPatternBackfillScan(
            string? patternName,
            string? patternScope)
        {
            this.PatternName = patternName;
            this.PatternScope = patternScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningScanHistoryCustomPatternBackfillScan" /> class.
        /// </summary>
        public SecretScanningScanHistoryCustomPatternBackfillScan()
        {
        }
    }
}