
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Configuration for iteration fields.
    /// </summary>
    public sealed partial class ProjectsV2FieldConfiguration
    {
        /// <summary>
        /// The day of the week when the iteration starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_day")]
        public int? StartDay { get; set; }

        /// <summary>
        /// The duration of the iteration in days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public global::System.Collections.Generic.IList<global::GitHub.ProjectsV2IterationSettings>? Iterations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2FieldConfiguration" /> class.
        /// </summary>
        /// <param name="startDay">
        /// The day of the week when the iteration starts.
        /// </param>
        /// <param name="duration">
        /// The duration of the iteration in days.
        /// </param>
        /// <param name="iterations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2FieldConfiguration(
            int? startDay,
            int? duration,
            global::System.Collections.Generic.IList<global::GitHub.ProjectsV2IterationSettings>? iterations)
        {
            this.StartDay = startDay;
            this.Duration = duration;
            this.Iterations = iterations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2FieldConfiguration" /> class.
        /// </summary>
        public ProjectsV2FieldConfiguration()
        {
        }
    }
}