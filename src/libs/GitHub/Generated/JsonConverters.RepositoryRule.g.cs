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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::GitHub.RepositoryRuleCreation? creation = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.Creation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleCreation)}");
                creation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleUpdate? update = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.Update)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleUpdate)}");
                update = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleDeletion? deletion = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.Deletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleDeletion)}");
                deletion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleRequiredLinearHistory? requiredLinearHistory = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.RequiredLinearHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleRequiredLinearHistory)}");
                requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleMergeQueue? mergeQueue = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.MergeQueue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMergeQueue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleMergeQueue)}");
                mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleRequiredDeployments? requiredDeployments = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.RequiredDeployments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleRequiredDeployments)}");
                requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleRequiredSignatures? requiredSignatures = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.RequiredSignatures)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleRequiredSignatures)}");
                requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRulePullRequest? pullRequest = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.PullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRulePullRequest)}");
                pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleRequiredStatusChecks? requiredStatusChecks = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.RequiredStatusChecks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleRequiredStatusChecks)}");
                requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleNonFastForward? nonFastForward = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.NonFastForward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleNonFastForward)}");
                nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleCommitMessagePattern? commitMessagePattern = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.CommitMessagePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleCommitMessagePattern)}");
                commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.CommitAuthorEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern)}");
                commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleCommitterEmailPattern? committerEmailPattern = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.CommitterEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleCommitterEmailPattern)}");
                committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleBranchNamePattern? branchNamePattern = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.BranchNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleBranchNamePattern)}");
                branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleTagNamePattern? tagNamePattern = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.TagNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleTagNamePattern)}");
                tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleFilePathRestriction? filePathRestriction = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.FilePathRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFilePathRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleFilePathRestriction)}");
                filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleMaxFilePathLength? maxFilePathLength = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.MaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFilePathLength> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleMaxFilePathLength)}");
                maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.FileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFileExtensionRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleFileExtensionRestriction)}");
                fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleMaxFileSize? maxFileSize = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.MaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFileSize> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleMaxFileSize)}");
                maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleWorkflows? workflows = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.Workflows)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleWorkflows)}");
                workflows = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.RepositoryRuleCodeScanning? codeScanning = default;
            if (discriminator?.Type == global::GitHub.RepositoryRuleDiscriminatorType.CodeScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.RepositoryRuleCodeScanning)}");
                codeScanning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::GitHub.RepositoryRule(
                discriminator?.Type,
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
                codeScanning
                );

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
        }
    }
}