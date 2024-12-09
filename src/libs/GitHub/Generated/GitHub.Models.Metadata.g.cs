
#nullable enable

namespace GitHub
{
    /// <summary>
    /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
    /// </summary>
    public sealed partial class Metadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Metadata(
 )
        {
        }
    }
}