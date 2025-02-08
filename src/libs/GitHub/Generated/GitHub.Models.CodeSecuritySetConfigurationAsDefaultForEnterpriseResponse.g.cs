
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse
    {
        /// <summary>
        /// Specifies which types of repository this security configuration is applied to by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_for_new_repos")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewReposJsonConverter))]
        public global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos? DefaultForNewRepos { get; set; }

        /// <summary>
        /// A code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::GitHub.CodeSecurityConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse" /> class.
        /// </summary>
        /// <param name="defaultForNewRepos">
        /// Specifies which types of repository this security configuration is applied to by default.
        /// </param>
        /// <param name="configuration">
        /// A code security configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse(
            global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos? defaultForNewRepos,
            global::GitHub.CodeSecurityConfiguration? configuration)
        {
            this.DefaultForNewRepos = defaultForNewRepos;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse" /> class.
        /// </summary>
        public CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse()
        {
        }
    }
}