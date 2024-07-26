
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleVariant19Parameters
    {
        /// <summary>
        /// The maximum file size allowed in megabytes. This limit does not apply to Git Large File Storage (Git LFS).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_file_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxFileSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}