
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Feature options for secret scanning delegated bypass
    /// </summary>
    public sealed partial class CodeSecurityConfigurationSecretScanningDelegatedBypassOptions
    {
        /// <summary>
        /// The bypass reviewers for secret scanning delegated bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        public global::System.Collections.Generic.IList<global::GitHub.CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewer>? Reviewers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationSecretScanningDelegatedBypassOptions" /> class.
        /// </summary>
        /// <param name="reviewers">
        /// The bypass reviewers for secret scanning delegated bypass
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeSecurityConfigurationSecretScanningDelegatedBypassOptions(
            global::System.Collections.Generic.IList<global::GitHub.CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewer>? reviewers)
        {
            this.Reviewers = reviewers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationSecretScanningDelegatedBypassOptions" /> class.
        /// </summary>
        public CodeSecurityConfigurationSecretScanningDelegatedBypassOptions()
        {
        }
    }
}