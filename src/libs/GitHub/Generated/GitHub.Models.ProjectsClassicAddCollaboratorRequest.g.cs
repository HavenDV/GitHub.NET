
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsClassicAddCollaboratorRequest
    {
        /// <summary>
        /// The permission to grant the collaborator.<br/>
        /// Default Value: write<br/>
        /// Example: write
        /// </summary>
        /// <example>write</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ProjectsClassicAddCollaboratorRequestPermissionJsonConverter))]
        public global::GitHub.ProjectsClassicAddCollaboratorRequestPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsClassicAddCollaboratorRequest" /> class.
        /// </summary>
        /// <param name="permission">
        /// The permission to grant the collaborator.<br/>
        /// Default Value: write<br/>
        /// Example: write
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsClassicAddCollaboratorRequest(
            global::GitHub.ProjectsClassicAddCollaboratorRequestPermission? permission)
        {
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsClassicAddCollaboratorRequest" /> class.
        /// </summary>
        public ProjectsClassicAddCollaboratorRequest()
        {
        }
    }
}