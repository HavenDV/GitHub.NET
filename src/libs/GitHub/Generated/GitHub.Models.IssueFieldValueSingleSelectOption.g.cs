
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Details about the selected option (only present for single_select fields)
    /// </summary>
    public sealed partial class IssueFieldValueSingleSelectOption
    {
        /// <summary>
        /// Unique identifier for the option.<br/>
        /// Example: 1L
        /// </summary>
        /// <example>1L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The name of the option<br/>
        /// Example: High
        /// </summary>
        /// <example>High</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The color of the option<br/>
        /// Example: red
        /// </summary>
        /// <example>red</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueFieldValueSingleSelectOption" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the option.<br/>
        /// Example: 1L
        /// </param>
        /// <param name="name">
        /// The name of the option<br/>
        /// Example: High
        /// </param>
        /// <param name="color">
        /// The color of the option<br/>
        /// Example: red
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueFieldValueSingleSelectOption(
            long id,
            string name,
            string color)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueFieldValueSingleSelectOption" /> class.
        /// </summary>
        public IssueFieldValueSingleSelectOption()
        {
        }
    }
}