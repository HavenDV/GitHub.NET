
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Enable or disable GitHub Advanced Security for the repository.<br/>
    /// For standalone Code Scanning or Secret Protection products, this parameter cannot be used.
    /// </summary>
    public sealed partial class SecurityAndAnalysisAdvancedSecurity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecurityAndAnalysisAdvancedSecurityStatusJsonConverter))]
        public global::GitHub.SecurityAndAnalysisAdvancedSecurityStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisAdvancedSecurity" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityAndAnalysisAdvancedSecurity(
            global::GitHub.SecurityAndAnalysisAdvancedSecurityStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisAdvancedSecurity" /> class.
        /// </summary>
        public SecurityAndAnalysisAdvancedSecurity()
        {
        }
    }
}