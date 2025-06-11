#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public class NullableSecretScanningFirstDetectedLocationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.NullableSecretScanningFirstDetectedLocation>
    {
        /// <inheritdoc />
        public override global::GitHub.NullableSecretScanningFirstDetectedLocation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::GitHub.SecretScanningLocationCommit? commit = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationCommit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationCommit).Name}");
                commit = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationWikiCommit? wikiCommit = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationWikiCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationWikiCommit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationWikiCommit).Name}");
                wikiCommit = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationIssueTitle? issueTitle = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueTitle> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueTitle).Name}");
                issueTitle = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationIssueBody? issueBody = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueBody).Name}");
                issueBody = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationIssueComment? issueComment = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueComment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueComment).Name}");
                issueComment = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationDiscussionTitle? discussionTitle = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionTitle> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionTitle).Name}");
                discussionTitle = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationDiscussionBody? discussionBody = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionBody).Name}");
                discussionBody = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationDiscussionComment? discussionComment = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionComment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionComment).Name}");
                discussionComment = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationPullRequestTitle? pullRequestTitle = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestTitle> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestTitle).Name}");
                pullRequestTitle = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationPullRequestBody? pullRequestBody = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestBody).Name}");
                pullRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationPullRequestComment? pullRequestComment = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestComment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestComment).Name}");
                pullRequestComment = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationPullRequestReview? pullRequestReview = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestReview> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestReview).Name}");
                pullRequestReview = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.SecretScanningLocationPullRequestReviewComment? pullRequestReviewComment = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestReviewComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestReviewComment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestReviewComment).Name}");
                pullRequestReviewComment = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::GitHub.NullableSecretScanningFirstDetectedLocation(
                commit,
                wikiCommit,
                issueTitle,
                issueBody,
                issueComment,
                discussionTitle,
                discussionBody,
                discussionComment,
                pullRequestTitle,
                pullRequestBody,
                pullRequestComment,
                pullRequestReview,
                pullRequestReviewComment
                );

            if (commit != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationCommit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationCommit).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (wikiCommit != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationWikiCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationWikiCommit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationWikiCommit).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (issueTitle != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueTitle> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueTitle).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (issueBody != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueBody).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (issueComment != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueComment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueComment).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (discussionTitle != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionTitle> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionTitle).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (discussionBody != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionBody).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (discussionComment != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionComment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionComment).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (pullRequestTitle != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestTitle> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestTitle).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (pullRequestBody != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestBody).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (pullRequestComment != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestComment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestComment).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (pullRequestReview != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestReview> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestReview).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (pullRequestReviewComment != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestReviewComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestReviewComment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestReviewComment).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.NullableSecretScanningFirstDetectedLocation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCommit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationCommit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationCommit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Commit, typeInfo);
            }
            else if (value.IsWikiCommit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationWikiCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationWikiCommit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationWikiCommit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WikiCommit, typeInfo);
            }
            else if (value.IsIssueTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueTitle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueTitle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueTitle, typeInfo);
            }
            else if (value.IsIssueBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueBody, typeInfo);
            }
            else if (value.IsIssueComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationIssueComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationIssueComment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationIssueComment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueComment, typeInfo);
            }
            else if (value.IsDiscussionTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionTitle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionTitle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DiscussionTitle, typeInfo);
            }
            else if (value.IsDiscussionBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DiscussionBody, typeInfo);
            }
            else if (value.IsDiscussionComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationDiscussionComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationDiscussionComment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationDiscussionComment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DiscussionComment, typeInfo);
            }
            else if (value.IsPullRequestTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestTitle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestTitle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestTitle, typeInfo);
            }
            else if (value.IsPullRequestBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestBody, typeInfo);
            }
            else if (value.IsPullRequestComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestComment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestComment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestComment, typeInfo);
            }
            else if (value.IsPullRequestReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestReview?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestReview).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestReview, typeInfo);
            }
            else if (value.IsPullRequestReviewComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.SecretScanningLocationPullRequestReviewComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.SecretScanningLocationPullRequestReviewComment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.SecretScanningLocationPullRequestReviewComment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestReviewComment, typeInfo);
            }
        }
    }
}