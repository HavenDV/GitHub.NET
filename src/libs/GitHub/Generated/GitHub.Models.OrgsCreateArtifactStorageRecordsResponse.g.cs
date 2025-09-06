
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsCreateArtifactStorageRecordsResponse
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_records")]
        public global::System.Collections.Generic.IList<global::GitHub.OrgsCreateArtifactStorageRecordsResponseStorageRecord>? StorageRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactStorageRecordsResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// Example: 1
        /// </param>
        /// <param name="storageRecords"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsCreateArtifactStorageRecordsResponse(
            int? totalCount,
            global::System.Collections.Generic.IList<global::GitHub.OrgsCreateArtifactStorageRecordsResponseStorageRecord>? storageRecords)
        {
            this.TotalCount = totalCount;
            this.StorageRecords = storageRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactStorageRecordsResponse" /> class.
        /// </summary>
        public OrgsCreateArtifactStorageRecordsResponse()
        {
        }
    }
}