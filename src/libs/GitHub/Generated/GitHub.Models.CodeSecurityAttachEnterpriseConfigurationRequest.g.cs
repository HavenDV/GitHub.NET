
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityAttachEnterpriseConfigurationRequest
    {
        /// <summary>
        /// The type of repositories to attach the configuration to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityAttachEnterpriseConfigurationRequestScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeSecurityAttachEnterpriseConfigurationRequestScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityAttachEnterpriseConfigurationRequest" /> class.
        /// </summary>
        /// <param name="scope">
        /// The type of repositories to attach the configuration to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityAttachEnterpriseConfigurationRequest(
            global::GitHub.CodeSecurityAttachEnterpriseConfigurationRequestScope scope)
        {
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityAttachEnterpriseConfigurationRequest" /> class.
        /// </summary>
        public CodeSecurityAttachEnterpriseConfigurationRequest()
        {
        }
    }
}