
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Only allow users with bypass permissions to delete matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleDeletion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleDeletionTypeJsonConverter))]
        public global::GitHub.RepositoryRuleDeletionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}