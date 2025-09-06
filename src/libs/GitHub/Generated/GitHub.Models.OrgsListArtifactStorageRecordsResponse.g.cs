
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsListArtifactStorageRecordsResponse
    {
        /// <summary>
        /// The number of storage records for this digest and organization<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_records")]
        public global::System.Collections.Generic.IList<global::GitHub.OrgsListArtifactStorageRecordsResponseStorageRecord>? StorageRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListArtifactStorageRecordsResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The number of storage records for this digest and organization<br/>
        /// Example: 3
        /// </param>
        /// <param name="storageRecords"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsListArtifactStorageRecordsResponse(
            int? totalCount,
            global::System.Collections.Generic.IList<global::GitHub.OrgsListArtifactStorageRecordsResponseStorageRecord>? storageRecords)
        {
            this.TotalCount = totalCount;
            this.StorageRecords = storageRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListArtifactStorageRecordsResponse" /> class.
        /// </summary>
        public OrgsListArtifactStorageRecordsResponse()
        {
        }
    }
}