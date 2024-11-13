
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityAndAnalysisSecretScanningPushProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecurityAndAnalysisSecretScanningPushProtectionStatusJsonConverter))]
        public global::GitHub.SecurityAndAnalysisSecretScanningPushProtectionStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningPushProtection" /> class.
        /// </summary>
        /// <param name="status"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SecurityAndAnalysisSecretScanningPushProtection(
            global::GitHub.SecurityAndAnalysisSecretScanningPushProtectionStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningPushProtection" /> class.
        /// </summary>
        public SecurityAndAnalysisSecretScanningPushProtection()
        {
        }
    }
}