
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of issue.
    /// </summary>
    public sealed partial class IssueType
    {
        /// <summary>
        /// The unique identifier of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The node identifier of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// The color of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.IssueTypeColorJsonConverter))]
        public global::GitHub.IssueTypeColor? Color { get; set; }

        /// <summary>
        /// The time the issue type created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time the issue type last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The enabled state of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueType" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the issue type.
        /// </param>
        /// <param name="nodeId">
        /// The node identifier of the issue type.
        /// </param>
        /// <param name="name">
        /// The name of the issue type.
        /// </param>
        /// <param name="description">
        /// The description of the issue type.
        /// </param>
        /// <param name="color">
        /// The color of the issue type.
        /// </param>
        /// <param name="createdAt">
        /// The time the issue type created.
        /// </param>
        /// <param name="updatedAt">
        /// The time the issue type last updated.
        /// </param>
        /// <param name="isEnabled">
        /// The enabled state of the issue type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueType(
            int id,
            string nodeId,
            string name,
            string? description,
            global::GitHub.IssueTypeColor? color,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            bool? isEnabled)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Color = color;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueType" /> class.
        /// </summary>
        public IssueType()
        {
        }
    }
}