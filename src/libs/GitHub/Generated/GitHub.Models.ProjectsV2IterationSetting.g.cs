
#nullable enable

namespace GitHub
{
    /// <summary>
    /// An iteration setting for an iteration field
    /// </summary>
    public sealed partial class ProjectsV2IterationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title_html")]
        public string? TitleHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2IterationSetting" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="titleHtml"></param>
        /// <param name="duration"></param>
        /// <param name="startDate"></param>
        /// <param name="completed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2IterationSetting(
            string id,
            string title,
            string? titleHtml,
            double? duration,
            string? startDate,
            bool? completed)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.TitleHtml = titleHtml;
            this.Duration = duration;
            this.StartDate = startDate;
            this.Completed = completed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2IterationSetting" /> class.
        /// </summary>
        public ProjectsV2IterationSetting()
        {
        }
    }
}