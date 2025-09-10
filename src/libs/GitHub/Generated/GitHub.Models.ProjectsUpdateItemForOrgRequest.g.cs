
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateItemForOrgRequest
    {
        /// <summary>
        /// A list of field updates to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.ProjectsUpdateItemForOrgRequestField> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateItemForOrgRequest" /> class.
        /// </summary>
        /// <param name="fields">
        /// A list of field updates to apply.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsUpdateItemForOrgRequest(
            global::System.Collections.Generic.IList<global::GitHub.ProjectsUpdateItemForOrgRequestField> fields)
        {
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateItemForOrgRequest" /> class.
        /// </summary>
        public ProjectsUpdateItemForOrgRequest()
        {
        }
    }
}