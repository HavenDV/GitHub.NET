#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class IssueEventForIssueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.IssueEventForIssue>
    {
        /// <inheritdoc />
        public override global::GitHub.IssueEventForIssue Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::GitHub.LabeledIssueEvent? labeled = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LabeledIssueEvent).Name}");
                labeled = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.UnlabeledIssueEvent? unlabeled = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnlabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnlabeledIssueEvent).Name}");
                unlabeled = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.AssignedIssueEvent? assigned = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AssignedIssueEvent).Name}");
                assigned = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.UnassignedIssueEvent? unassigned = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnassignedIssueEvent).Name}");
                unassigned = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.MilestonedIssueEvent? milestoned = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MilestonedIssueEvent).Name}");
                milestoned = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.DemilestonedIssueEvent? demilestoned = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.DemilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.DemilestonedIssueEvent).Name}");
                demilestoned = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RenamedIssueEvent? renamed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RenamedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RenamedIssueEvent).Name}");
                renamed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ReviewRequestedIssueEvent? reviewRequested = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}");
                reviewRequested = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ReviewRequestRemovedIssueEvent? reviewRequestRemoved = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestRemovedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}");
                reviewRequestRemoved = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ReviewDismissedIssueEvent? reviewDismissed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewDismissedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}");
                reviewDismissed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.LockedIssueEvent? locked = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LockedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LockedIssueEvent).Name}");
                locked = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.AddedToProjectIssueEvent? addedToProject = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AddedToProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AddedToProjectIssueEvent).Name}");
                addedToProject = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.MovedColumnInProjectIssueEvent? movedColumnInProject = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MovedColumnInProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}");
                movedColumnInProject = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RemovedFromProjectIssueEvent? removedFromProject = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RemovedFromProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}");
                removedFromProject = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ConvertedNoteToIssueIssueEvent? convertedNoteTo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ConvertedNoteToIssueIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                convertedNoteTo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::GitHub.IssueEventForIssue(
                labeled,

                unlabeled,

                assigned,

                unassigned,

                milestoned,

                demilestoned,

                renamed,

                reviewRequested,

                reviewRequestRemoved,

                reviewDismissed,

                locked,

                addedToProject,

                movedColumnInProject,

                removedFromProject,

                convertedNoteTo
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for AnyOf<{typeof(global::GitHub.LabeledIssueEvent).Name}, {typeof(global::GitHub.UnlabeledIssueEvent).Name}, {typeof(global::GitHub.AssignedIssueEvent).Name}, {typeof(global::GitHub.UnassignedIssueEvent).Name}, {typeof(global::GitHub.MilestonedIssueEvent).Name}, {typeof(global::GitHub.DemilestonedIssueEvent).Name}, {typeof(global::GitHub.RenamedIssueEvent).Name}, {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}, {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}, {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}, {typeof(global::GitHub.LockedIssueEvent).Name}, {typeof(global::GitHub.AddedToProjectIssueEvent).Name}, {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}, {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}, {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}>");
            }

            if (labeled != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LabeledIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (unlabeled != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnlabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnlabeledIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (assigned != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AssignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (unassigned != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnassignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (milestoned != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MilestonedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (demilestoned != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.DemilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.DemilestonedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (renamed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RenamedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RenamedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (reviewRequested != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (reviewRequestRemoved != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestRemovedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (reviewDismissed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewDismissedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (locked != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LockedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LockedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (addedToProject != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AddedToProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AddedToProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (movedColumnInProject != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MovedColumnInProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (removedFromProject != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RemovedFromProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (convertedNoteTo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ConvertedNoteToIssueIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.IssueEventForIssue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid AnyOf<{typeof(global::GitHub.LabeledIssueEvent).Name}, {typeof(global::GitHub.UnlabeledIssueEvent).Name}, {typeof(global::GitHub.AssignedIssueEvent).Name}, {typeof(global::GitHub.UnassignedIssueEvent).Name}, {typeof(global::GitHub.MilestonedIssueEvent).Name}, {typeof(global::GitHub.DemilestonedIssueEvent).Name}, {typeof(global::GitHub.RenamedIssueEvent).Name}, {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}, {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}, {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}, {typeof(global::GitHub.LockedIssueEvent).Name}, {typeof(global::GitHub.AddedToProjectIssueEvent).Name}, {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}, {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}, {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}> object.");
            }

            if (value.IsLabeled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Labeled, typeInfo);
            }

            else if (value.IsUnlabeled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnlabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnlabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unlabeled, typeInfo);
            }

            else if (value.IsAssigned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AssignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AssignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assigned, typeInfo);
            }

            else if (value.IsUnassigned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnassignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnassignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unassigned, typeInfo);
            }

            else if (value.IsMilestoned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Milestoned, typeInfo);
            }

            else if (value.IsDemilestoned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.DemilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.DemilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Demilestoned, typeInfo);
            }

            else if (value.IsRenamed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RenamedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RenamedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Renamed, typeInfo);
            }

            else if (value.IsReviewRequested)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequested, typeInfo);
            }

            else if (value.IsReviewRequestRemoved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemoved, typeInfo);
            }

            else if (value.IsReviewDismissed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewDismissedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissed, typeInfo);
            }

            else if (value.IsLocked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LockedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LockedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Locked, typeInfo);
            }

            else if (value.IsAddedToProject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AddedToProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AddedToProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProject, typeInfo);
            }

            else if (value.IsMovedColumnInProject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MovedColumnInProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProject, typeInfo);
            }

            else if (value.IsRemovedFromProject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RemovedFromProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProject, typeInfo);
            }

            else if (value.IsConvertedNoteTo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ConvertedNoteToIssueIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteTo, typeInfo);
            }
        }
    }
}