
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Content Traffic
    /// </summary>
    public sealed partial class ContentTraffic
    {
        /// <summary>
        /// Example: /github/hubot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Example: github/hubot: A customizable life embetterment robot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Example: 3542
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Example: 2225
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniques")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Uniques { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}