
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsAddCollaboratorRequest
    {
        /// <summary>
        /// The permission to grant the collaborator.<br/>
        /// Default Value: write<br/>
        /// Example: write
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ProjectsAddCollaboratorRequestPermissionJsonConverter))]
        public global::GitHub.ProjectsAddCollaboratorRequestPermission? Permission { get; set; } = global::GitHub.ProjectsAddCollaboratorRequestPermission.Write;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}