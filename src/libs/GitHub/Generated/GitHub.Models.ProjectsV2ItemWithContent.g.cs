
#nullable enable

namespace GitHub
{
    /// <summary>
    /// An item belonging to a project
    /// </summary>
    public sealed partial class ProjectsV2ItemWithContent
    {
        /// <summary>
        /// The unique identifier of the project item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// The node ID of the project item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The API URL of the project that contains this item.<br/>
        /// Example: https://api.github.com/users/monalisa/2/projectsV2/3
        /// </summary>
        /// <example>https://api.github.com/users/monalisa/2/projectsV2/3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        public string? ProjectUrl { get; set; }

        /// <summary>
        /// The type of content tracked in a project item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ProjectsV2ItemContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ProjectsV2ItemContentType ContentType { get; set; }

        /// <summary>
        /// The content of the item, which varies by content type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public object? Content { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::GitHub.SimpleUser? Creator { get; set; }

        /// <summary>
        /// The time when the item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time when the item was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The time when the item was archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// The API URL of this item.<br/>
        /// Example: https://api.github.com/users/monalisa/2/projectsV2/items/3
        /// </summary>
        /// <example>https://api.github.com/users/monalisa/2/projectsV2/items/3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_url")]
        public string? ItemUrl { get; set; }

        /// <summary>
        /// The fields and values associated with this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<object>? Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2ItemWithContent" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the project item.
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the project item.
        /// </param>
        /// <param name="projectUrl">
        /// The API URL of the project that contains this item.<br/>
        /// Example: https://api.github.com/users/monalisa/2/projectsV2/3
        /// </param>
        /// <param name="contentType">
        /// The type of content tracked in a project item
        /// </param>
        /// <param name="content">
        /// The content of the item, which varies by content type.
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// The time when the item was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time when the item was last updated.
        /// </param>
        /// <param name="archivedAt">
        /// The time when the item was archived.
        /// </param>
        /// <param name="itemUrl">
        /// The API URL of this item.<br/>
        /// Example: https://api.github.com/users/monalisa/2/projectsV2/items/3
        /// </param>
        /// <param name="fields">
        /// The fields and values associated with this item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2ItemWithContent(
            double id,
            global::GitHub.ProjectsV2ItemContentType contentType,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? archivedAt,
            string? nodeId,
            string? projectUrl,
            object? content,
            global::GitHub.SimpleUser? creator,
            string? itemUrl,
            global::System.Collections.Generic.IList<object>? fields)
        {
            this.Id = id;
            this.ContentType = contentType;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
            this.NodeId = nodeId;
            this.ProjectUrl = projectUrl;
            this.Content = content;
            this.Creator = creator;
            this.ItemUrl = itemUrl;
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2ItemWithContent" /> class.
        /// </summary>
        public ProjectsV2ItemWithContent()
        {
        }
    }
}