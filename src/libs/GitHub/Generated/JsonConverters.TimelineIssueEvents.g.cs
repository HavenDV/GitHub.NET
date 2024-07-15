#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class TimelineIssueEventsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.TimelineIssueEvents>
    {
        /// <inheritdoc />
        public override global::GitHub.TimelineIssueEvents Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::GitHub.LabeledIssueEvent? labeledEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LabeledIssueEvent).Name}");
                labeledEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.UnlabeledIssueEvent? unlabeledEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnlabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnlabeledIssueEvent).Name}");
                unlabeledEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.MilestonedIssueEvent? milestonedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MilestonedIssueEvent).Name}");
                milestonedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.DemilestonedIssueEvent? demilestonedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.DemilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.DemilestonedIssueEvent).Name}");
                demilestonedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RenamedIssueEvent? renamedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RenamedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RenamedIssueEvent).Name}");
                renamedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ReviewRequestedIssueEvent? reviewRequestedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}");
                reviewRequestedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ReviewRequestRemovedIssueEvent? reviewRequestRemovedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestRemovedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}");
                reviewRequestRemovedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ReviewDismissedIssueEvent? reviewDismissedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewDismissedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}");
                reviewDismissedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.LockedIssueEvent? lockedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LockedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LockedIssueEvent).Name}");
                lockedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.AddedToProjectIssueEvent? addedToProjectEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AddedToProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AddedToProjectIssueEvent).Name}");
                addedToProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.MovedColumnInProjectIssueEvent? movedColumnInProjectEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MovedColumnInProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}");
                movedColumnInProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.RemovedFromProjectIssueEvent? removedFromProjectEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RemovedFromProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}");
                removedFromProjectEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ConvertedNoteToIssueIssueEvent? convertedNoteToEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ConvertedNoteToIssueIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                convertedNoteToEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.TimelineCommentEvent? commentEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommentEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommentEvent).Name}");
                commentEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.TimelineCrossReferencedEvent? crossReferencedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCrossReferencedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCrossReferencedEvent).Name}");
                crossReferencedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.TimelineCommittedEvent? committedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommittedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommittedEvent).Name}");
                committedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.TimelineReviewedEvent? reviewedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineReviewedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineReviewedEvent).Name}");
                reviewedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.TimelineLineCommentedEvent? lineCommentedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineLineCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineLineCommentedEvent).Name}");
                lineCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.TimelineCommitCommentedEvent? commitCommentedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommitCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommitCommentedEvent).Name}");
                commitCommentedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.TimelineAssignedIssueEvent? assignedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineAssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineAssignedIssueEvent).Name}");
                assignedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.TimelineUnassignedIssueEvent? unassignedEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineUnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineUnassignedIssueEvent).Name}");
                unassignedEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.StateChangeIssueEvent? stateChangeEvent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.StateChangeIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.StateChangeIssueEvent).Name}");
                stateChangeEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::GitHub.TimelineIssueEvents(
                labeledEvent,

                unlabeledEvent,

                milestonedEvent,

                demilestonedEvent,

                renamedEvent,

                reviewRequestedEvent,

                reviewRequestRemovedEvent,

                reviewDismissedEvent,

                lockedEvent,

                addedToProjectEvent,

                movedColumnInProjectEvent,

                removedFromProjectEvent,

                convertedNoteToEvent,

                commentEvent,

                crossReferencedEvent,

                committedEvent,

                reviewedEvent,

                lineCommentedEvent,

                commitCommentedEvent,

                assignedEvent,

                unassignedEvent,

                stateChangeEvent
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for AnyOf<{typeof(global::GitHub.LabeledIssueEvent).Name}, {typeof(global::GitHub.UnlabeledIssueEvent).Name}, {typeof(global::GitHub.MilestonedIssueEvent).Name}, {typeof(global::GitHub.DemilestonedIssueEvent).Name}, {typeof(global::GitHub.RenamedIssueEvent).Name}, {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}, {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}, {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}, {typeof(global::GitHub.LockedIssueEvent).Name}, {typeof(global::GitHub.AddedToProjectIssueEvent).Name}, {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}, {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}, {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}, {typeof(global::GitHub.TimelineCommentEvent).Name}, {typeof(global::GitHub.TimelineCrossReferencedEvent).Name}, {typeof(global::GitHub.TimelineCommittedEvent).Name}, {typeof(global::GitHub.TimelineReviewedEvent).Name}, {typeof(global::GitHub.TimelineLineCommentedEvent).Name}, {typeof(global::GitHub.TimelineCommitCommentedEvent).Name}, {typeof(global::GitHub.TimelineAssignedIssueEvent).Name}, {typeof(global::GitHub.TimelineUnassignedIssueEvent).Name}, {typeof(global::GitHub.StateChangeIssueEvent).Name}>");
            }

            if (labeledEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LabeledIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (unlabeledEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnlabeledIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnlabeledIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (milestonedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MilestonedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (demilestonedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.DemilestonedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.DemilestonedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (renamedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RenamedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RenamedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (reviewRequestedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (reviewRequestRemovedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestRemovedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (reviewDismissedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewDismissedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (lockedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LockedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LockedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (addedToProjectEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AddedToProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AddedToProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (movedColumnInProjectEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MovedColumnInProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (removedFromProjectEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RemovedFromProjectIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (convertedNoteToEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ConvertedNoteToIssueIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (commentEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommentEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommentEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (crossReferencedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCrossReferencedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCrossReferencedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (committedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommittedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommittedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (reviewedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineReviewedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineReviewedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (lineCommentedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineLineCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineLineCommentedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (commitCommentedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommitCommentedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommitCommentedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (assignedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineAssignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineAssignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (unassignedEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineUnassignedIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineUnassignedIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (stateChangeEvent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.StateChangeIssueEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.StateChangeIssueEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.TimelineIssueEvents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid AnyOf<{typeof(global::GitHub.LabeledIssueEvent).Name}, {typeof(global::GitHub.UnlabeledIssueEvent).Name}, {typeof(global::GitHub.MilestonedIssueEvent).Name}, {typeof(global::GitHub.DemilestonedIssueEvent).Name}, {typeof(global::GitHub.RenamedIssueEvent).Name}, {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}, {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}, {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}, {typeof(global::GitHub.LockedIssueEvent).Name}, {typeof(global::GitHub.AddedToProjectIssueEvent).Name}, {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}, {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}, {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}, {typeof(global::GitHub.TimelineCommentEvent).Name}, {typeof(global::GitHub.TimelineCrossReferencedEvent).Name}, {typeof(global::GitHub.TimelineCommittedEvent).Name}, {typeof(global::GitHub.TimelineReviewedEvent).Name}, {typeof(global::GitHub.TimelineLineCommentedEvent).Name}, {typeof(global::GitHub.TimelineCommitCommentedEvent).Name}, {typeof(global::GitHub.TimelineAssignedIssueEvent).Name}, {typeof(global::GitHub.TimelineUnassignedIssueEvent).Name}, {typeof(global::GitHub.StateChangeIssueEvent).Name}> object.");
            }

            if (value.IsLabeledEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LabeledEvent, typeInfo);
            }

            else if (value.IsUnlabeledEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.UnlabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.UnlabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnlabeledEvent, typeInfo);
            }

            else if (value.IsMilestonedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MilestonedEvent, typeInfo);
            }

            else if (value.IsDemilestonedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.DemilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.DemilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DemilestonedEvent, typeInfo);
            }

            else if (value.IsRenamedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RenamedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RenamedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RenamedEvent, typeInfo);
            }

            else if (value.IsReviewRequestedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestedEvent, typeInfo);
            }

            else if (value.IsReviewRequestRemovedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewRequestRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewRequestRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemovedEvent, typeInfo);
            }

            else if (value.IsReviewDismissedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReviewDismissedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ReviewDismissedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissedEvent, typeInfo);
            }

            else if (value.IsLockedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.LockedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.LockedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LockedEvent, typeInfo);
            }

            else if (value.IsAddedToProjectEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AddedToProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AddedToProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProjectEvent, typeInfo);
            }

            else if (value.IsMovedColumnInProjectEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.MovedColumnInProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.MovedColumnInProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProjectEvent, typeInfo);
            }

            else if (value.IsRemovedFromProjectEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.RemovedFromProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.RemovedFromProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProjectEvent, typeInfo);
            }

            else if (value.IsConvertedNoteToEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ConvertedNoteToIssueIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteToEvent, typeInfo);
            }

            else if (value.IsCommentEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommentEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommentEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommentEvent, typeInfo);
            }

            else if (value.IsCrossReferencedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCrossReferencedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCrossReferencedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCrossReferencedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CrossReferencedEvent, typeInfo);
            }

            else if (value.IsCommittedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommittedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommittedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommittedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommittedEvent, typeInfo);
            }

            else if (value.IsReviewedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineReviewedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineReviewedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineReviewedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewedEvent, typeInfo);
            }

            else if (value.IsLineCommentedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineLineCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineLineCommentedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineLineCommentedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LineCommentedEvent, typeInfo);
            }

            else if (value.IsCommitCommentedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineCommitCommentedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineCommitCommentedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineCommitCommentedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitCommentedEvent, typeInfo);
            }

            else if (value.IsAssignedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineAssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineAssignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineAssignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssignedEvent, typeInfo);
            }

            else if (value.IsUnassignedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.TimelineUnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.TimelineUnassignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.TimelineUnassignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnassignedEvent, typeInfo);
            }

            else if (value.IsStateChangeEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.StateChangeIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.StateChangeIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.StateChangeIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StateChangeEvent, typeInfo);
            }
        }
    }
}