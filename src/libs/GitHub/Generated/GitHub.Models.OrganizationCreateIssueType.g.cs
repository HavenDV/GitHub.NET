
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationCreateIssueType
    {
        /// <summary>
        /// Name of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether or not the issue type is enabled at the organization level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// Description of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color for the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrganizationCreateIssueTypeColorJsonConverter))]
        public global::GitHub.OrganizationCreateIssueTypeColor? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateIssueType" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the issue type.
        /// </param>
        /// <param name="isEnabled">
        /// Whether or not the issue type is enabled at the organization level.
        /// </param>
        /// <param name="description">
        /// Description of the issue type.
        /// </param>
        /// <param name="color">
        /// Color for the issue type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCreateIssueType(
            string name,
            bool isEnabled,
            string? description,
            global::GitHub.OrganizationCreateIssueTypeColor? color)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsEnabled = isEnabled;
            this.Description = description;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateIssueType" /> class.
        /// </summary>
        public OrganizationCreateIssueType()
        {
        }
    }
}