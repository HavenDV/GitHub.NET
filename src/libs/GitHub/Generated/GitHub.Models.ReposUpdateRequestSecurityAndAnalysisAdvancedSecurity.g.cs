
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Use the `status` property to enable or disable GitHub Advanced Security for this repository.<br/>
    /// For more information, see "[About GitHub Advanced<br/>
    /// Security](/github/getting-started-with-github/learning-about-github/about-github-advanced-security)."<br/>
    /// For standalone Code Scanning or Secret Protection products, this parameter cannot be used.
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity
    {
        /// <summary>
        /// Can be `enabled` or `disabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity" /> class.
        /// </summary>
        /// <param name="status">
        /// Can be `enabled` or `disabled`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity" /> class.
        /// </summary>
        public ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity()
        {
        }
    }
}