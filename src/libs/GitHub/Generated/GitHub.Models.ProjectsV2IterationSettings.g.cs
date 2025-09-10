
#nullable enable

namespace GitHub
{
    /// <summary>
    /// An iteration setting for an iteration field
    /// </summary>
    public sealed partial class ProjectsV2IterationSettings
    {
        /// <summary>
        /// The unique identifier of the iteration setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The start date of the iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// The duration of the iteration in days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// The iteration title, in raw text and HTML formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ProjectsV2IterationSettingsTitle Title { get; set; }

        /// <summary>
        /// Whether the iteration has been completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2IterationSettings" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the iteration setting.
        /// </param>
        /// <param name="startDate">
        /// The start date of the iteration.
        /// </param>
        /// <param name="duration">
        /// The duration of the iteration in days.
        /// </param>
        /// <param name="title">
        /// The iteration title, in raw text and HTML formats.
        /// </param>
        /// <param name="completed">
        /// Whether the iteration has been completed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2IterationSettings(
            string id,
            global::System.DateTime startDate,
            int duration,
            global::GitHub.ProjectsV2IterationSettingsTitle title,
            bool completed)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.StartDate = startDate;
            this.Duration = duration;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Completed = completed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2IterationSettings" /> class.
        /// </summary>
        public ProjectsV2IterationSettings()
        {
        }
    }
}