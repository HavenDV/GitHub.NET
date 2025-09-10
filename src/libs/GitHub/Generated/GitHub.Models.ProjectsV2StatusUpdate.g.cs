
#nullable enable

namespace GitHub
{
    /// <summary>
    /// An status update belonging to a project
    /// </summary>
    public sealed partial class ProjectsV2StatusUpdate
    {
        /// <summary>
        /// The unique identifier of the status update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// The node ID of the status update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The node ID of the project that this status update belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_node_id")]
        public string? ProjectNodeId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::GitHub.SimpleUser? Creator { get; set; }

        /// <summary>
        /// The time when the status update was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time when the status update was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The current status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ProjectsV2StatusUpdateStatusJsonConverter))]
        public global::GitHub.ProjectsV2StatusUpdateStatus? Status { get; set; }

        /// <summary>
        /// The start date of the period covered by the update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The target date associated with the update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_date")]
        public global::System.DateTime? TargetDate { get; set; }

        /// <summary>
        /// Body of the status update<br/>
        /// Example: The project is off to a great start!
        /// </summary>
        /// <example>The project is off to a great start!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2StatusUpdate" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the status update.
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the status update.
        /// </param>
        /// <param name="projectNodeId">
        /// The node ID of the project that this status update belongs to.
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// The time when the status update was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time when the status update was last updated.
        /// </param>
        /// <param name="status">
        /// The current status.
        /// </param>
        /// <param name="startDate">
        /// The start date of the period covered by the update.
        /// </param>
        /// <param name="targetDate">
        /// The target date associated with the update.
        /// </param>
        /// <param name="body">
        /// Body of the status update<br/>
        /// Example: The project is off to a great start!
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2StatusUpdate(
            double id,
            string nodeId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? projectNodeId,
            global::GitHub.SimpleUser? creator,
            global::GitHub.ProjectsV2StatusUpdateStatus? status,
            global::System.DateTime? startDate,
            global::System.DateTime? targetDate,
            string? body)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectNodeId = projectNodeId;
            this.Creator = creator;
            this.Status = status;
            this.StartDate = startDate;
            this.TargetDate = targetDate;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2StatusUpdate" /> class.
        /// </summary>
        public ProjectsV2StatusUpdate()
        {
        }
    }
}