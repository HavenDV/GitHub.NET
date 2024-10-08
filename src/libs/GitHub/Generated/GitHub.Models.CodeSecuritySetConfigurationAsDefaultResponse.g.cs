
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecuritySetConfigurationAsDefaultResponse
    {
        /// <summary>
        /// Specifies which types of repository this security configuration is applied to by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_for_new_repos")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewReposJsonConverter))]
        public global::GitHub.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos? DefaultForNewRepos { get; set; }

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
    }
}