
#nullable enable

namespace GitHub
{
    /// <summary>
    /// An option for a single select field
    /// </summary>
    public sealed partial class ProjectsV2SingleSelectOptions
    {
        /// <summary>
        /// The unique identifier of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The display name of the option, in raw text and HTML formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ProjectsV2SingleSelectOptionsName Name { get; set; }

        /// <summary>
        /// The description of the option, in raw text and HTML formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ProjectsV2SingleSelectOptionsDescription Description { get; set; }

        /// <summary>
        /// The color associated with the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2SingleSelectOptions" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the option.
        /// </param>
        /// <param name="name">
        /// The display name of the option, in raw text and HTML formats.
        /// </param>
        /// <param name="description">
        /// The description of the option, in raw text and HTML formats.
        /// </param>
        /// <param name="color">
        /// The color associated with the option.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2SingleSelectOptions(
            string id,
            global::GitHub.ProjectsV2SingleSelectOptionsName name,
            global::GitHub.ProjectsV2SingleSelectOptionsDescription description,
            string color)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2SingleSelectOptions" /> class.
        /// </summary>
        public ProjectsV2SingleSelectOptions()
        {
        }
    }
}