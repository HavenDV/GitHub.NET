
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Use the `status` property to enable or disable GitHub Code Security for this repository.
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysisCodeSecurity
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
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisCodeSecurity" /> class.
        /// </summary>
        /// <param name="status">
        /// Can be `enabled` or `disabled`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateRequestSecurityAndAnalysisCodeSecurity(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisCodeSecurity" /> class.
        /// </summary>
        public ReposUpdateRequestSecurityAndAnalysisCodeSecurity()
        {
        }
    }
}