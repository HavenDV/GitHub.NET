#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public class RepositoryRuleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.RepositoryRule>
    {
        /// <inheritdoc />
        public override global::GitHub.RepositoryRule Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::GitHub.RepositoryRuleCreation? creation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCreation).Name}");
                creation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleUpdate? update = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleUpdate).Name}");
                update = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleDeletion? deletion = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleDeletion).Name}");
                deletion = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleRequiredLinearHistory? requiredLinearHistory = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleMergeQueue? mergeQueue = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMergeQueue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMergeQueue).Name}");
                mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleRequiredDeployments? requiredDeployments = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredDeployments).Name}");
                requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleRequiredSignatures? requiredSignatures = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredSignatures).Name}");
                requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRulePullRequest? pullRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRulePullRequest).Name}");
                pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleRequiredStatusChecks? requiredStatusChecks = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleNonFastForward? nonFastForward = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleNonFastForward).Name}");
                nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCommitMessagePattern? commitMessagePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitMessagePattern).Name}");
                commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCommitterEmailPattern? committerEmailPattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleBranchNamePattern? branchNamePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleBranchNamePattern).Name}");
                branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleTagNamePattern? tagNamePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleTagNamePattern).Name}");
                tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleFilePathRestriction? filePathRestriction = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFilePathRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFilePathRestriction).Name}");
                filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleMaxFilePathLength? maxFilePathLength = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFilePathLength> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFilePathLength).Name}");
                maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFileExtensionRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleMaxFileSize? maxFileSize = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFileSize> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFileSize).Name}");
                maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleWorkflows? workflows = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleWorkflows).Name}");
                workflows = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCodeScanning? codeScanning = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCodeScanning).Name}");
                codeScanning = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCopilotCodeReview? copilotCodeReview = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCopilotCodeReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCopilotCodeReview> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCopilotCodeReview).Name}");
                copilotCodeReview = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::GitHub.RepositoryRule(
                creation,
                update,
                deletion,
                requiredLinearHistory,
                mergeQueue,
                requiredDeployments,
                requiredSignatures,
                pullRequest,
                requiredStatusChecks,
                nonFastForward,
                commitMessagePattern,
                commitAuthorEmailPattern,
                committerEmailPattern,
                branchNamePattern,
                tagNamePattern,
                filePathRestriction,
                maxFilePathLength,
                fileExtensionRestriction,
                maxFileSize,
                workflows,
                codeScanning,
                copilotCodeReview
                );

            if (creation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCreation).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (update != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleUpdate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (deletion != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleDeletion).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (requiredLinearHistory != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mergeQueue != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMergeQueue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMergeQueue).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (requiredDeployments != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredDeployments).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (requiredSignatures != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredSignatures).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (pullRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRulePullRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (requiredStatusChecks != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (nonFastForward != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleNonFastForward).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (commitMessagePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitMessagePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (commitAuthorEmailPattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (committerEmailPattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (branchNamePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleBranchNamePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tagNamePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleTagNamePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (filePathRestriction != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFilePathRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFilePathRestriction).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (maxFilePathLength != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFilePathLength> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFilePathLength).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileExtensionRestriction != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFileExtensionRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (maxFileSize != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFileSize> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFileSize).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (workflows != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleWorkflows).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeScanning != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCodeScanning).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (copilotCodeReview != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCopilotCodeReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCopilotCodeReview> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCopilotCodeReview).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.RepositoryRule value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCreation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCreation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Creation, typeInfo);
            }
            else if (value.IsUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Update, typeInfo);
            }
            else if (value.IsDeletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleDeletion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleDeletion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deletion, typeInfo);
            }
            else if (value.IsRequiredLinearHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredLinearHistory?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredLinearHistory, typeInfo);
            }
            else if (value.IsMergeQueue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMergeQueue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMergeQueue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MergeQueue, typeInfo);
            }
            else if (value.IsRequiredDeployments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredDeployments?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredDeployments).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredDeployments, typeInfo);
            }
            else if (value.IsRequiredSignatures)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredSignatures?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredSignatures).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredSignatures, typeInfo);
            }
            else if (value.IsPullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRulePullRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRulePullRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequest, typeInfo);
            }
            else if (value.IsRequiredStatusChecks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredStatusChecks?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredStatusChecks, typeInfo);
            }
            else if (value.IsNonFastForward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleNonFastForward?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleNonFastForward).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NonFastForward, typeInfo);
            }
            else if (value.IsCommitMessagePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitMessagePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitMessagePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitMessagePattern, typeInfo);
            }
            else if (value.IsCommitAuthorEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitAuthorEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitAuthorEmailPattern, typeInfo);
            }
            else if (value.IsCommitterEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitterEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitterEmailPattern, typeInfo);
            }
            else if (value.IsBranchNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleBranchNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleBranchNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BranchNamePattern, typeInfo);
            }
            else if (value.IsTagNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleTagNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleTagNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TagNamePattern, typeInfo);
            }
            else if (value.IsFilePathRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFilePathRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFilePathRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePathRestriction, typeInfo);
            }
            else if (value.IsMaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFilePathLength?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFilePathLength).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFilePathLength, typeInfo);
            }
            else if (value.IsFileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFileExtensionRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileExtensionRestriction, typeInfo);
            }
            else if (value.IsMaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFileSize?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFileSize).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFileSize, typeInfo);
            }
            else if (value.IsWorkflows)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleWorkflows?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleWorkflows).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Workflows, typeInfo);
            }
            else if (value.IsCodeScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCodeScanning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCodeScanning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeScanning, typeInfo);
            }
            else if (value.IsCopilotCodeReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCopilotCodeReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCopilotCodeReview?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCopilotCodeReview).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CopilotCodeReview, typeInfo);
            }
        }
    }
}