
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalAdvisoryIdentifier
    {
        /// <summary>
        /// The type of identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.GlobalAdvisoryIdentifierTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.GlobalAdvisoryIdentifierType Type { get; set; }

        /// <summary>
        /// The identifier value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisoryIdentifier" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of identifier.
        /// </param>
        /// <param name="value">
        /// The identifier value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlobalAdvisoryIdentifier(
            global::GitHub.GlobalAdvisoryIdentifierType type,
            string value)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisoryIdentifier" /> class.
        /// </summary>
        public GlobalAdvisoryIdentifier()
        {
        }
    }
}