
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A field inside a projects v2 project
    /// </summary>
    public sealed partial class ProjectsV2Field
    {
        /// <summary>
        /// The unique identifier of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The node ID of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The API URL of the project that contains the field.<br/>
        /// Example: https://api.github.com/projects/1
        /// </summary>
        /// <example>https://api.github.com/projects/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// The name of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The field's data type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ProjectsV2FieldDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ProjectsV2FieldDataType DataType { get; set; }

        /// <summary>
        /// The options available for single select fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::GitHub.ProjectsV2SingleSelectOptions>? Options { get; set; }

        /// <summary>
        /// Configuration for iteration fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::GitHub.ProjectsV2FieldConfiguration? Configuration { get; set; }

        /// <summary>
        /// The time when the field was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time when the field was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2Field" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the field.
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the field.
        /// </param>
        /// <param name="projectUrl">
        /// The API URL of the project that contains the field.<br/>
        /// Example: https://api.github.com/projects/1
        /// </param>
        /// <param name="name">
        /// The name of the field.
        /// </param>
        /// <param name="dataType">
        /// The field's data type.
        /// </param>
        /// <param name="options">
        /// The options available for single select fields.
        /// </param>
        /// <param name="configuration">
        /// Configuration for iteration fields.
        /// </param>
        /// <param name="createdAt">
        /// The time when the field was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time when the field was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2Field(
            int id,
            string projectUrl,
            string name,
            global::GitHub.ProjectsV2FieldDataType dataType,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? nodeId,
            global::System.Collections.Generic.IList<global::GitHub.ProjectsV2SingleSelectOptions>? options,
            global::GitHub.ProjectsV2FieldConfiguration? configuration)
        {
            this.Id = id;
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataType = dataType;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.NodeId = nodeId;
            this.Options = options;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2Field" /> class.
        /// </summary>
        public ProjectsV2Field()
        {
        }
    }
}