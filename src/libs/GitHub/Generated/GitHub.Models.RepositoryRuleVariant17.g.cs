
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Prevent commits that include file paths that exceed a specified character limit from being pushed to the commit graph.
    /// </summary>
    public sealed partial class RepositoryRuleVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleVariant17TypeJsonConverter))]
        public global::GitHub.RepositoryRuleVariant17Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::GitHub.RepositoryRuleVariant17Parameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}