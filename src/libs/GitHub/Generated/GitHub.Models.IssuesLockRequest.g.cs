
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesLockRequest
    {
        /// <summary>
        /// The reason for locking the issue or pull request conversation. Lock will fail if you don't use one of these reasons:  <br/>
        ///  * `off-topic`  <br/>
        ///  * `too heated`  <br/>
        ///  * `resolved`  <br/>
        ///  * `spam`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.IssuesLockRequestLockReasonJsonConverter))]
        public global::GitHub.IssuesLockRequestLockReason? LockReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}