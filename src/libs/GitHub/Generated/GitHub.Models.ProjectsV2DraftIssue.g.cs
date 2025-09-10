
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A draft issue in a project
    /// </summary>
    public sealed partial class ProjectsV2DraftIssue
    {
        /// <summary>
        /// The ID of the draft issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// The node ID of the draft issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The title of the draft issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The body content of the draft issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// The time the draft issue was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time the draft issue was last updated
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
        /// Initializes a new instance of the <see cref="ProjectsV2DraftIssue" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the draft issue
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the draft issue
        /// </param>
        /// <param name="title">
        /// The title of the draft issue
        /// </param>
        /// <param name="body">
        /// The body content of the draft issue
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// The time the draft issue was created
        /// </param>
        /// <param name="updatedAt">
        /// The time the draft issue was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2DraftIssue(
            double id,
            string nodeId,
            string title,
            global::GitHub.NullableSimpleUser? user,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? body)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2DraftIssue" /> class.
        /// </summary>
        public ProjectsV2DraftIssue()
        {
        }
    }
}