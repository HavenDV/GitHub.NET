
#nullable enable

namespace GitHub
{
    /// <summary>
    /// An item belonging to a project
    /// </summary>
    public sealed partial class ProjectsV2Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_node_id")]
        public string? ProjectNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentNodeId { get; set; }

        /// <summary>
        /// The type of content tracked in a project item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ProjectsV2ItemContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ProjectsV2ItemContentType ContentType { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::GitHub.SimpleUser? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}