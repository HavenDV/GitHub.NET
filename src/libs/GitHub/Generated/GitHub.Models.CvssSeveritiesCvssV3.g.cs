
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CvssSeveritiesCvssV3
    {
        /// <summary>
        /// The CVSS 3 vector string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? VectorString { get; set; }

        /// <summary>
        /// The CVSS 3 score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}