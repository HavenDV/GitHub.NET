
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Enable or disable Dependabot security updates for the repository.
    /// </summary>
    public sealed partial class SecurityAndAnalysisDependabotSecurityUpdates
    {
        /// <summary>
        /// The enablement status of Dependabot security updates for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecurityAndAnalysisDependabotSecurityUpdatesStatusJsonConverter))]
        public global::GitHub.SecurityAndAnalysisDependabotSecurityUpdatesStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisDependabotSecurityUpdates" /> class.
        /// </summary>
        /// <param name="status">
        /// The enablement status of Dependabot security updates for the repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityAndAnalysisDependabotSecurityUpdates(
            global::GitHub.SecurityAndAnalysisDependabotSecurityUpdatesStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisDependabotSecurityUpdates" /> class.
        /// </summary>
        public SecurityAndAnalysisDependabotSecurityUpdates()
        {
        }
    }
}