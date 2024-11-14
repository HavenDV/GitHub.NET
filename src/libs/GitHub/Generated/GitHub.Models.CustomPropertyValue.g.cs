
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// Custom property name and associated value
    /// </summary>
    public sealed partial class CustomPropertyValue
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyName { get; set; }

        /// <summary>
        /// The value assigned to the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OneOf<string, global::System.Collections.Generic.IList<string>>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertyValue" /> class.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property
        /// </param>
        /// <param name="value">
        /// The value assigned to the property
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomPropertyValue(
            string propertyName,
            global::GitHub.OneOf<string, global::System.Collections.Generic.IList<string>>? value)
        {
            this.PropertyName = propertyName ?? throw new global::System.ArgumentNullException(nameof(propertyName));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertyValue" /> class.
        /// </summary>
        public CustomPropertyValue()
        {
        }
    }
}