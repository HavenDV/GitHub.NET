
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateItemForUserRequestField
    {
        /// <summary>
        /// The ID of the project field to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The new value for the field:<br/>
        /// - For text, number, and date fields, provide the new value directly.<br/>
        /// - For single select and iteration fields, provide the ID of the option or iteration.<br/>
        /// - To clear the field, set this to null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OneOfJsonConverter<string, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OneOf<string, double?>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateItemForUserRequestField" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the project field to update.
        /// </param>
        /// <param name="value">
        /// The new value for the field:<br/>
        /// - For text, number, and date fields, provide the new value directly.<br/>
        /// - For single select and iteration fields, provide the ID of the option or iteration.<br/>
        /// - To clear the field, set this to null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsUpdateItemForUserRequestField(
            int id,
            global::GitHub.OneOf<string, double?>? value)
        {
            this.Id = id;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateItemForUserRequestField" /> class.
        /// </summary>
        public ProjectsUpdateItemForUserRequestField()
        {
        }
    }
}