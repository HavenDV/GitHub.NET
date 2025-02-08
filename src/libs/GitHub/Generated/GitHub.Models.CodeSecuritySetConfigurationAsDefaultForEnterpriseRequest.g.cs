
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecuritySetConfigurationAsDefaultForEnterpriseRequest
    {
        /// <summary>
        /// Specify which types of repository this security configuration should be applied to by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_for_new_repos")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewReposJsonConverter))]
        public global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos? DefaultForNewRepos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultForEnterpriseRequest" /> class.
        /// </summary>
        /// <param name="defaultForNewRepos">
        /// Specify which types of repository this security configuration should be applied to by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecuritySetConfigurationAsDefaultForEnterpriseRequest(
            global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos? defaultForNewRepos)
        {
            this.DefaultForNewRepos = defaultForNewRepos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultForEnterpriseRequest" /> class.
        /// </summary>
        public CodeSecuritySetConfigurationAsDefaultForEnterpriseRequest()
        {
        }
    }
}