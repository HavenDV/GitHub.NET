
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsAddItemForUserRequest
    {
        /// <summary>
        /// The type of item to add to the project. Must be either Issue or PullRequest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ProjectsAddItemForUserRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ProjectsAddItemForUserRequestType Type { get; set; }

        /// <summary>
        /// The numeric ID of the issue or pull request to add to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddItemForUserRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of item to add to the project. Must be either Issue or PullRequest.
        /// </param>
        /// <param name="id">
        /// The numeric ID of the issue or pull request to add to the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsAddItemForUserRequest(
            global::GitHub.ProjectsAddItemForUserRequestType type,
            int id)
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddItemForUserRequest" /> class.
        /// </summary>
        public ProjectsAddItemForUserRequest()
        {
        }
    }
}