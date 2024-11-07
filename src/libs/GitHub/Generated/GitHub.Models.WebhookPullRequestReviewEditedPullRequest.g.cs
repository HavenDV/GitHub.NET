
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewEditedPullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestLinks Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_lock_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookPullRequestReviewEditedPullRequestActiveLockReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestActiveLockReason? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestAssignee? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.WebhookPullRequestReviewEditedPullRequestAssignee2> Assignees { get; set; }

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookPullRequestReviewEditedPullRequestAuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestAuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// The status of auto merging a pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_merge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestAutoMerge? AutoMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestBase Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestHead Head { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.WebhookPullRequestReviewEditedPullRequestLabel> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? MergeCommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? MergedAt { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestMilestone? Milestone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PatchUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_reviewers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.OneOf<global::GitHub.WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1, global::GitHub.WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2>> RequestedReviewers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.WebhookPullRequestReviewEditedPullRequestRequestedTeam> RequestedTeams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReviewCommentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReviewCommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookPullRequestReviewEditedPullRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewEditedPullRequestUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::GitHub.WebhookPullRequestReviewEditedPullRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.WebhookPullRequestReviewEditedPullRequest),
                jsonSerializerContext) as global::GitHub.WebhookPullRequestReviewEditedPullRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.WebhookPullRequestReviewEditedPullRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.WebhookPullRequestReviewEditedPullRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::GitHub.WebhookPullRequestReviewEditedPullRequest?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::GitHub.WebhookPullRequestReviewEditedPullRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::GitHub.WebhookPullRequestReviewEditedPullRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::GitHub.WebhookPullRequestReviewEditedPullRequest?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::GitHub.WebhookPullRequestReviewEditedPullRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}