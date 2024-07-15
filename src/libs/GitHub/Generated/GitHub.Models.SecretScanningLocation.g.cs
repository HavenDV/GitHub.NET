
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningLocation
    {
        /// <summary>
        /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.<br/>
        /// Example: commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SecretScanningLocationTypeJsonConverter))]
        public global::GitHub.SecretScanningLocationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory13))]
        public global::System.OneOf<global::GitHub.SecretScanningLocationCommit?, global::GitHub.SecretScanningLocationWikiCommit?, global::GitHub.SecretScanningLocationIssueTitle?, global::GitHub.SecretScanningLocationIssueBody?, global::GitHub.SecretScanningLocationIssueComment?, global::GitHub.SecretScanningLocationDiscussionTitle?, global::GitHub.SecretScanningLocationDiscussionBody?, global::GitHub.SecretScanningLocationDiscussionComment?, global::GitHub.SecretScanningLocationPullRequestTitle?, global::GitHub.SecretScanningLocationPullRequestBody?, global::GitHub.SecretScanningLocationPullRequestComment?, global::GitHub.SecretScanningLocationPullRequestReview?, global::GitHub.SecretScanningLocationPullRequestReviewComment?>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}