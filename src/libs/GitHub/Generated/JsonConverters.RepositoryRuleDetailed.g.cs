#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class RepositoryRuleDetailedJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.RepositoryRuleDetailed>
    {
        /// <inheritdoc />
        public override global::GitHub.RepositoryRuleDetailed Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? value10 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value10 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value11 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value11 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value12 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value12 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value13 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value13 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value14 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value14 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? value15 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value15 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? value16 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                value16 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::GitHub.RepositoryRuleDetailed(
                value1,

                value2,

                value3,

                value4,

                value5,

                value6,

                value7,

                value8,

                value9,

                value10,

                value11,

                value12,

                value13,

                value14,

                value15,

                value16
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>).Name}>");
            }

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value10 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value11 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value12 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value13 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value14 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value15 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value16 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.RepositoryRuleDetailed value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>).Name}, {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>).Name}> object.");
            }

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }

            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }

            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }

            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }

            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }

            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }

            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }

            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }

            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }

            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }

            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeInfo);
            }

            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeInfo);
            }

            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeInfo);
            }

            else if (value.IsValue14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeInfo);
            }

            else if (value.IsValue15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, typeInfo);
            }

            else if (value.IsValue16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, typeInfo);
            }
        }
    }
}