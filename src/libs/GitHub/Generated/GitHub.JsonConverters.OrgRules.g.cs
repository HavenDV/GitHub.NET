#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public class OrgRulesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.OrgRules>
    {
        /// <inheritdoc />
        public override global::GitHub.OrgRules Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::GitHub.RepositoryRuleCreation? repositoryRuleCreation = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCreation).Name}");
                repositoryRuleCreation = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleUpdate? repositoryRuleUpdate = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleUpdate).Name}");
                repositoryRuleUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleDeletion? repositoryRuleDeletion = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleDeletion).Name}");
                repositoryRuleDeletion = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleRequiredLinearHistory? repositoryRuleRequiredLinearHistory = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                repositoryRuleRequiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleRequiredDeployments? repositoryRuleRequiredDeployments = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredDeployments).Name}");
                repositoryRuleRequiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleRequiredSignatures? repositoryRuleRequiredSignatures = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredSignatures).Name}");
                repositoryRuleRequiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRulePullRequest? repositoryRulePullRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRulePullRequest).Name}");
                repositoryRulePullRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleRequiredStatusChecks? repositoryRuleRequiredStatusChecks = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                repositoryRuleRequiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleNonFastForward? repositoryRuleNonFastForward = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleNonFastForward).Name}");
                repositoryRuleNonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCommitMessagePattern? repositoryRuleCommitMessagePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitMessagePattern).Name}");
                repositoryRuleCommitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCommitAuthorEmailPattern? repositoryRuleCommitAuthorEmailPattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                repositoryRuleCommitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCommitterEmailPattern? repositoryRuleCommitterEmailPattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                repositoryRuleCommitterEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleBranchNamePattern? repositoryRuleBranchNamePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleBranchNamePattern).Name}");
                repositoryRuleBranchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleTagNamePattern? repositoryRuleTagNamePattern = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleTagNamePattern).Name}");
                repositoryRuleTagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleFilePathRestriction? repositoryRuleFilePathRestriction = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFilePathRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFilePathRestriction).Name}");
                repositoryRuleFilePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleMaxFilePathLength? repositoryRuleMaxFilePathLength = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFilePathLength> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFilePathLength).Name}");
                repositoryRuleMaxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleFileExtensionRestriction? repositoryRuleFileExtensionRestriction = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFileExtensionRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                repositoryRuleFileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleMaxFileSize? repositoryRuleMaxFileSize = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFileSize> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFileSize).Name}");
                repositoryRuleMaxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleWorkflows? repositoryRuleWorkflows = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleWorkflows).Name}");
                repositoryRuleWorkflows = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RepositoryRuleCodeScanning? repositoryRuleCodeScanning = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCodeScanning).Name}");
                repositoryRuleCodeScanning = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::GitHub.OrgRules(
                repositoryRuleCreation,
                repositoryRuleUpdate,
                repositoryRuleDeletion,
                repositoryRuleRequiredLinearHistory,
                repositoryRuleRequiredDeployments,
                repositoryRuleRequiredSignatures,
                repositoryRulePullRequest,
                repositoryRuleRequiredStatusChecks,
                repositoryRuleNonFastForward,
                repositoryRuleCommitMessagePattern,
                repositoryRuleCommitAuthorEmailPattern,
                repositoryRuleCommitterEmailPattern,
                repositoryRuleBranchNamePattern,
                repositoryRuleTagNamePattern,
                repositoryRuleFilePathRestriction,
                repositoryRuleMaxFilePathLength,
                repositoryRuleFileExtensionRestriction,
                repositoryRuleMaxFileSize,
                repositoryRuleWorkflows,
                repositoryRuleCodeScanning
                );

            if (repositoryRuleCreation != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCreation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCreation).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleUpdate != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleUpdate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleDeletion != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleDeletion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleDeletion).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleRequiredLinearHistory != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredLinearHistory> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleRequiredDeployments != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredDeployments> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredDeployments).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleRequiredSignatures != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredSignatures> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredSignatures).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRulePullRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRulePullRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRulePullRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleRequiredStatusChecks != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredStatusChecks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleNonFastForward != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleNonFastForward> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleNonFastForward).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleCommitMessagePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitMessagePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitMessagePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleCommitAuthorEmailPattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitAuthorEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleCommitterEmailPattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitterEmailPattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleBranchNamePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleBranchNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleBranchNamePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleTagNamePattern != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleTagNamePattern> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleTagNamePattern).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleFilePathRestriction != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFilePathRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFilePathRestriction).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleMaxFilePathLength != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFilePathLength> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFilePathLength).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleFileExtensionRestriction != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFileExtensionRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleMaxFileSize != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFileSize> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFileSize).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleWorkflows != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleWorkflows> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleWorkflows).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (repositoryRuleCodeScanning != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCodeScanning> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCodeScanning).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.OrgRules value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRepositoryRuleCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCreation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCreation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleCreation, typeInfo);
            }
            else if (value.IsRepositoryRuleUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleUpdate, typeInfo);
            }
            else if (value.IsRepositoryRuleDeletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleDeletion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleDeletion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleDeletion, typeInfo);
            }
            else if (value.IsRepositoryRuleRequiredLinearHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredLinearHistory?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleRequiredLinearHistory, typeInfo);
            }
            else if (value.IsRepositoryRuleRequiredDeployments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredDeployments?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredDeployments).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleRequiredDeployments, typeInfo);
            }
            else if (value.IsRepositoryRuleRequiredSignatures)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredSignatures?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredSignatures).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleRequiredSignatures, typeInfo);
            }
            else if (value.IsRepositoryRulePullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRulePullRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRulePullRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRulePullRequest, typeInfo);
            }
            else if (value.IsRepositoryRuleRequiredStatusChecks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleRequiredStatusChecks?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleRequiredStatusChecks, typeInfo);
            }
            else if (value.IsRepositoryRuleNonFastForward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleNonFastForward?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleNonFastForward).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleNonFastForward, typeInfo);
            }
            else if (value.IsRepositoryRuleCommitMessagePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitMessagePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitMessagePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleCommitMessagePattern, typeInfo);
            }
            else if (value.IsRepositoryRuleCommitAuthorEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitAuthorEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleCommitAuthorEmailPattern, typeInfo);
            }
            else if (value.IsRepositoryRuleCommitterEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCommitterEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleCommitterEmailPattern, typeInfo);
            }
            else if (value.IsRepositoryRuleBranchNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleBranchNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleBranchNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleBranchNamePattern, typeInfo);
            }
            else if (value.IsRepositoryRuleTagNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleTagNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleTagNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleTagNamePattern, typeInfo);
            }
            else if (value.IsRepositoryRuleFilePathRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFilePathRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFilePathRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleFilePathRestriction, typeInfo);
            }
            else if (value.IsRepositoryRuleMaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFilePathLength?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFilePathLength).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleMaxFilePathLength, typeInfo);
            }
            else if (value.IsRepositoryRuleFileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleFileExtensionRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleFileExtensionRestriction, typeInfo);
            }
            else if (value.IsRepositoryRuleMaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleMaxFileSize?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleMaxFileSize).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleMaxFileSize, typeInfo);
            }
            else if (value.IsRepositoryRuleWorkflows)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleWorkflows?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleWorkflows).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleWorkflows, typeInfo);
            }
            else if (value.IsRepositoryRuleCodeScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RepositoryRuleCodeScanning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RepositoryRuleCodeScanning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryRuleCodeScanning, typeInfo);
            }
        }
    }
}