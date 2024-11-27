
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningScanHistory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incremental_scans")]
        public global::System.Collections.Generic.IList<global::GitHub.SecretScanningScan>? IncrementalScans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_update_scans")]
        public global::System.Collections.Generic.IList<global::GitHub.SecretScanningScan>? PatternUpdateScans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_scans")]
        public global::System.Collections.Generic.IList<global::GitHub.SecretScanningScan>? BackfillScans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_backfill_scans")]
        public global::System.Collections.Generic.IList<global::GitHub.AllOf<global::GitHub.SecretScanningScan, global::GitHub.SecretScanningScanHistoryCustomPatternBackfillScan>>? CustomPatternBackfillScans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningScanHistory" /> class.
        /// </summary>
        /// <param name="incrementalScans"></param>
        /// <param name="patternUpdateScans"></param>
        /// <param name="backfillScans"></param>
        /// <param name="customPatternBackfillScans"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SecretScanningScanHistory(
            global::System.Collections.Generic.IList<global::GitHub.SecretScanningScan>? incrementalScans,
            global::System.Collections.Generic.IList<global::GitHub.SecretScanningScan>? patternUpdateScans,
            global::System.Collections.Generic.IList<global::GitHub.SecretScanningScan>? backfillScans,
            global::System.Collections.Generic.IList<global::GitHub.AllOf<global::GitHub.SecretScanningScan, global::GitHub.SecretScanningScanHistoryCustomPatternBackfillScan>>? customPatternBackfillScans)
        {
            this.IncrementalScans = incrementalScans;
            this.PatternUpdateScans = patternUpdateScans;
            this.BackfillScans = backfillScans;
            this.CustomPatternBackfillScans = customPatternBackfillScans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningScanHistory" /> class.
        /// </summary>
        public SecretScanningScanHistory()
        {
        }
    }
}