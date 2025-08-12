
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsClassicCreateCardRequestVariant1
    {
        /// <summary>
        /// The project card's note<br/>
        /// Example: Update all gems
        /// </summary>
        /// <example>Update all gems</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsClassicCreateCardRequestVariant1" /> class.
        /// </summary>
        /// <param name="note">
        /// The project card's note<br/>
        /// Example: Update all gems
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsClassicCreateCardRequestVariant1(
            string? note)
        {
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsClassicCreateCardRequestVariant1" /> class.
        /// </summary>
        public ProjectsClassicCreateCardRequestVariant1()
        {
        }
    }
}