
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleViolationErrorMetadataSecretScanning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_placeholders")]
        public global::System.Collections.Generic.IList<global::GitHub.RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder>? BypassPlaceholders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadataSecretScanning" /> class.
        /// </summary>
        /// <param name="bypassPlaceholders"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRuleViolationErrorMetadataSecretScanning(
            global::System.Collections.Generic.IList<global::GitHub.RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder>? bypassPlaceholders)
        {
            this.BypassPlaceholders = bypassPlaceholders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadataSecretScanning" /> class.
        /// </summary>
        public RepositoryRuleViolationErrorMetadataSecretScanning()
        {
        }
    }
}