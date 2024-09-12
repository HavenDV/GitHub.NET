
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Prevent commits that exceed a specified file size limit from being pushed to the commit.
    /// </summary>
    public sealed partial class RepositoryRuleVariant19
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleVariant19TypeJsonConverter))]
        public global::GitHub.RepositoryRuleVariant19Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::GitHub.RepositoryRuleVariant19Parameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}