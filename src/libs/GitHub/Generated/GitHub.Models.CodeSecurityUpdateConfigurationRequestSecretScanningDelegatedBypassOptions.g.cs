
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Feature options for secret scanning delegated bypass
    /// </summary>
    public sealed partial class CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptions
    {
        /// <summary>
        /// The bypass reviewers for secret scanning delegated bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        public global::System.Collections.Generic.IList<global::GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewer>? Reviewers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptions" /> class.
        /// </summary>
        /// <param name="reviewers">
        /// The bypass reviewers for secret scanning delegated bypass
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptions(
            global::System.Collections.Generic.IList<global::GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewer>? reviewers)
        {
            this.Reviewers = reviewers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptions" /> class.
        /// </summary>
        public CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptions()
        {
        }
    }
}