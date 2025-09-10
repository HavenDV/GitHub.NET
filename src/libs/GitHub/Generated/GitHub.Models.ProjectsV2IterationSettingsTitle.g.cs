
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The iteration title, in raw text and HTML formats.
    /// </summary>
    public sealed partial class ProjectsV2IterationSettingsTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Raw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2IterationSettingsTitle" /> class.
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="html"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2IterationSettingsTitle(
            string raw,
            string html)
        {
            this.Raw = raw ?? throw new global::System.ArgumentNullException(nameof(raw));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2IterationSettingsTitle" /> class.
        /// </summary>
        public ProjectsV2IterationSettingsTitle()
        {
        }
    }
}