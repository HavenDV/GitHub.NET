
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksCreateRequestVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ChecksCreateRequestVariant1StatusJsonConverter))]
        public global::GitHub.ChecksCreateRequestVariant1Status Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestVariant1" /> class.
        /// </summary>
        /// <param name="status"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChecksCreateRequestVariant1(
            global::GitHub.ChecksCreateRequestVariant1Status status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestVariant1" /> class.
        /// </summary>
        public ChecksCreateRequestVariant1()
        {
        }
    }
}