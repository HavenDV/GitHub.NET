using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// Timeline Event
    /// </summary>
    public readonly partial struct TimelineIssueEvents : global::System.IEquatable<TimelineIssueEvents>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.LabeledIssueEvent? LabeledEvent { get; init; }
#else
        public global::GitHub.LabeledIssueEvent? LabeledEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabeledEvent))]
#endif
        public bool IsLabeledEvent => LabeledEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.LabeledIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.LabeledIssueEvent?(TimelineIssueEvents @this) => @this.LabeledEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.LabeledIssueEvent? value)
        {
            LabeledEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.UnlabeledIssueEvent? UnlabeledEvent { get; init; }
#else
        public global::GitHub.UnlabeledIssueEvent? UnlabeledEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnlabeledEvent))]
#endif
        public bool IsUnlabeledEvent => UnlabeledEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.UnlabeledIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.UnlabeledIssueEvent?(TimelineIssueEvents @this) => @this.UnlabeledEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.UnlabeledIssueEvent? value)
        {
            UnlabeledEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.MilestonedIssueEvent? MilestonedEvent { get; init; }
#else
        public global::GitHub.MilestonedIssueEvent? MilestonedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MilestonedEvent))]
#endif
        public bool IsMilestonedEvent => MilestonedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.MilestonedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.MilestonedIssueEvent?(TimelineIssueEvents @this) => @this.MilestonedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.MilestonedIssueEvent? value)
        {
            MilestonedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.DemilestonedIssueEvent? DemilestonedEvent { get; init; }
#else
        public global::GitHub.DemilestonedIssueEvent? DemilestonedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DemilestonedEvent))]
#endif
        public bool IsDemilestonedEvent => DemilestonedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.DemilestonedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.DemilestonedIssueEvent?(TimelineIssueEvents @this) => @this.DemilestonedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.DemilestonedIssueEvent? value)
        {
            DemilestonedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RenamedIssueEvent? RenamedEvent { get; init; }
#else
        public global::GitHub.RenamedIssueEvent? RenamedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RenamedEvent))]
#endif
        public bool IsRenamedEvent => RenamedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.RenamedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RenamedIssueEvent?(TimelineIssueEvents @this) => @this.RenamedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.RenamedIssueEvent? value)
        {
            RenamedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ReviewRequestedIssueEvent? ReviewRequestedEvent { get; init; }
#else
        public global::GitHub.ReviewRequestedIssueEvent? ReviewRequestedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestedEvent))]
#endif
        public bool IsReviewRequestedEvent => ReviewRequestedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.ReviewRequestedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ReviewRequestedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewRequestedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.ReviewRequestedIssueEvent? value)
        {
            ReviewRequestedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedEvent { get; init; }
#else
        public global::GitHub.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestRemovedEvent))]
#endif
        public bool IsReviewRequestRemovedEvent => ReviewRequestRemovedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.ReviewRequestRemovedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ReviewRequestRemovedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewRequestRemovedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.ReviewRequestRemovedIssueEvent? value)
        {
            ReviewRequestRemovedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ReviewDismissedIssueEvent? ReviewDismissedEvent { get; init; }
#else
        public global::GitHub.ReviewDismissedIssueEvent? ReviewDismissedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewDismissedEvent))]
#endif
        public bool IsReviewDismissedEvent => ReviewDismissedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.ReviewDismissedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ReviewDismissedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewDismissedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.ReviewDismissedIssueEvent? value)
        {
            ReviewDismissedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.LockedIssueEvent? LockedEvent { get; init; }
#else
        public global::GitHub.LockedIssueEvent? LockedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LockedEvent))]
#endif
        public bool IsLockedEvent => LockedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.LockedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.LockedIssueEvent?(TimelineIssueEvents @this) => @this.LockedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.LockedIssueEvent? value)
        {
            LockedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AddedToProjectIssueEvent? AddedToProjectEvent { get; init; }
#else
        public global::GitHub.AddedToProjectIssueEvent? AddedToProjectEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddedToProjectEvent))]
#endif
        public bool IsAddedToProjectEvent => AddedToProjectEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.AddedToProjectIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AddedToProjectIssueEvent?(TimelineIssueEvents @this) => @this.AddedToProjectEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.AddedToProjectIssueEvent? value)
        {
            AddedToProjectEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.MovedColumnInProjectIssueEvent? MovedColumnInProjectEvent { get; init; }
#else
        public global::GitHub.MovedColumnInProjectIssueEvent? MovedColumnInProjectEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MovedColumnInProjectEvent))]
#endif
        public bool IsMovedColumnInProjectEvent => MovedColumnInProjectEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.MovedColumnInProjectIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.MovedColumnInProjectIssueEvent?(TimelineIssueEvents @this) => @this.MovedColumnInProjectEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.MovedColumnInProjectIssueEvent? value)
        {
            MovedColumnInProjectEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RemovedFromProjectIssueEvent? RemovedFromProjectEvent { get; init; }
#else
        public global::GitHub.RemovedFromProjectIssueEvent? RemovedFromProjectEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemovedFromProjectEvent))]
#endif
        public bool IsRemovedFromProjectEvent => RemovedFromProjectEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.RemovedFromProjectIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RemovedFromProjectIssueEvent?(TimelineIssueEvents @this) => @this.RemovedFromProjectEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.RemovedFromProjectIssueEvent? value)
        {
            RemovedFromProjectEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ConvertedNoteToIssueIssueEvent? ConvertedNoteToEvent { get; init; }
#else
        public global::GitHub.ConvertedNoteToIssueIssueEvent? ConvertedNoteToEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConvertedNoteToEvent))]
#endif
        public bool IsConvertedNoteToEvent => ConvertedNoteToEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.ConvertedNoteToIssueIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ConvertedNoteToIssueIssueEvent?(TimelineIssueEvents @this) => @this.ConvertedNoteToEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.ConvertedNoteToIssueIssueEvent? value)
        {
            ConvertedNoteToEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.TimelineCommentEvent? CommentEvent { get; init; }
#else
        public global::GitHub.TimelineCommentEvent? CommentEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommentEvent))]
#endif
        public bool IsCommentEvent => CommentEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.TimelineCommentEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.TimelineCommentEvent?(TimelineIssueEvents @this) => @this.CommentEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.TimelineCommentEvent? value)
        {
            CommentEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.TimelineCrossReferencedEvent? CrossReferencedEvent { get; init; }
#else
        public global::GitHub.TimelineCrossReferencedEvent? CrossReferencedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CrossReferencedEvent))]
#endif
        public bool IsCrossReferencedEvent => CrossReferencedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.TimelineCrossReferencedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.TimelineCrossReferencedEvent?(TimelineIssueEvents @this) => @this.CrossReferencedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.TimelineCrossReferencedEvent? value)
        {
            CrossReferencedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.TimelineCommittedEvent? CommittedEvent { get; init; }
#else
        public global::GitHub.TimelineCommittedEvent? CommittedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommittedEvent))]
#endif
        public bool IsCommittedEvent => CommittedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.TimelineCommittedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.TimelineCommittedEvent?(TimelineIssueEvents @this) => @this.CommittedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.TimelineCommittedEvent? value)
        {
            CommittedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.TimelineReviewedEvent? ReviewedEvent { get; init; }
#else
        public global::GitHub.TimelineReviewedEvent? ReviewedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewedEvent))]
#endif
        public bool IsReviewedEvent => ReviewedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.TimelineReviewedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.TimelineReviewedEvent?(TimelineIssueEvents @this) => @this.ReviewedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.TimelineReviewedEvent? value)
        {
            ReviewedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.TimelineLineCommentedEvent? LineCommentedEvent { get; init; }
#else
        public global::GitHub.TimelineLineCommentedEvent? LineCommentedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LineCommentedEvent))]
#endif
        public bool IsLineCommentedEvent => LineCommentedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.TimelineLineCommentedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.TimelineLineCommentedEvent?(TimelineIssueEvents @this) => @this.LineCommentedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.TimelineLineCommentedEvent? value)
        {
            LineCommentedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.TimelineCommitCommentedEvent? CommitCommentedEvent { get; init; }
#else
        public global::GitHub.TimelineCommitCommentedEvent? CommitCommentedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitCommentedEvent))]
#endif
        public bool IsCommitCommentedEvent => CommitCommentedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.TimelineCommitCommentedEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.TimelineCommitCommentedEvent?(TimelineIssueEvents @this) => @this.CommitCommentedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.TimelineCommitCommentedEvent? value)
        {
            CommitCommentedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.TimelineAssignedIssueEvent? AssignedEvent { get; init; }
#else
        public global::GitHub.TimelineAssignedIssueEvent? AssignedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssignedEvent))]
#endif
        public bool IsAssignedEvent => AssignedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.TimelineAssignedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.TimelineAssignedIssueEvent?(TimelineIssueEvents @this) => @this.AssignedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.TimelineAssignedIssueEvent? value)
        {
            AssignedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.TimelineUnassignedIssueEvent? UnassignedEvent { get; init; }
#else
        public global::GitHub.TimelineUnassignedIssueEvent? UnassignedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnassignedEvent))]
#endif
        public bool IsUnassignedEvent => UnassignedEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.TimelineUnassignedIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.TimelineUnassignedIssueEvent?(TimelineIssueEvents @this) => @this.UnassignedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.TimelineUnassignedIssueEvent? value)
        {
            UnassignedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.StateChangeIssueEvent? StateChangeEvent { get; init; }
#else
        public global::GitHub.StateChangeIssueEvent? StateChangeEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StateChangeEvent))]
#endif
        public bool IsStateChangeEvent => StateChangeEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::GitHub.StateChangeIssueEvent value) => new TimelineIssueEvents(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.StateChangeIssueEvent?(TimelineIssueEvents @this) => @this.StateChangeEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::GitHub.StateChangeIssueEvent? value)
        {
            StateChangeEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(
            global::GitHub.LabeledIssueEvent? labeledEvent,
            global::GitHub.UnlabeledIssueEvent? unlabeledEvent,
            global::GitHub.MilestonedIssueEvent? milestonedEvent,
            global::GitHub.DemilestonedIssueEvent? demilestonedEvent,
            global::GitHub.RenamedIssueEvent? renamedEvent,
            global::GitHub.ReviewRequestedIssueEvent? reviewRequestedEvent,
            global::GitHub.ReviewRequestRemovedIssueEvent? reviewRequestRemovedEvent,
            global::GitHub.ReviewDismissedIssueEvent? reviewDismissedEvent,
            global::GitHub.LockedIssueEvent? lockedEvent,
            global::GitHub.AddedToProjectIssueEvent? addedToProjectEvent,
            global::GitHub.MovedColumnInProjectIssueEvent? movedColumnInProjectEvent,
            global::GitHub.RemovedFromProjectIssueEvent? removedFromProjectEvent,
            global::GitHub.ConvertedNoteToIssueIssueEvent? convertedNoteToEvent,
            global::GitHub.TimelineCommentEvent? commentEvent,
            global::GitHub.TimelineCrossReferencedEvent? crossReferencedEvent,
            global::GitHub.TimelineCommittedEvent? committedEvent,
            global::GitHub.TimelineReviewedEvent? reviewedEvent,
            global::GitHub.TimelineLineCommentedEvent? lineCommentedEvent,
            global::GitHub.TimelineCommitCommentedEvent? commitCommentedEvent,
            global::GitHub.TimelineAssignedIssueEvent? assignedEvent,
            global::GitHub.TimelineUnassignedIssueEvent? unassignedEvent,
            global::GitHub.StateChangeIssueEvent? stateChangeEvent
            )
        {
            LabeledEvent = labeledEvent;
            UnlabeledEvent = unlabeledEvent;
            MilestonedEvent = milestonedEvent;
            DemilestonedEvent = demilestonedEvent;
            RenamedEvent = renamedEvent;
            ReviewRequestedEvent = reviewRequestedEvent;
            ReviewRequestRemovedEvent = reviewRequestRemovedEvent;
            ReviewDismissedEvent = reviewDismissedEvent;
            LockedEvent = lockedEvent;
            AddedToProjectEvent = addedToProjectEvent;
            MovedColumnInProjectEvent = movedColumnInProjectEvent;
            RemovedFromProjectEvent = removedFromProjectEvent;
            ConvertedNoteToEvent = convertedNoteToEvent;
            CommentEvent = commentEvent;
            CrossReferencedEvent = crossReferencedEvent;
            CommittedEvent = committedEvent;
            ReviewedEvent = reviewedEvent;
            LineCommentedEvent = lineCommentedEvent;
            CommitCommentedEvent = commitCommentedEvent;
            AssignedEvent = assignedEvent;
            UnassignedEvent = unassignedEvent;
            StateChangeEvent = stateChangeEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StateChangeEvent as object ??
            UnassignedEvent as object ??
            AssignedEvent as object ??
            CommitCommentedEvent as object ??
            LineCommentedEvent as object ??
            ReviewedEvent as object ??
            CommittedEvent as object ??
            CrossReferencedEvent as object ??
            CommentEvent as object ??
            ConvertedNoteToEvent as object ??
            RemovedFromProjectEvent as object ??
            MovedColumnInProjectEvent as object ??
            AddedToProjectEvent as object ??
            LockedEvent as object ??
            ReviewDismissedEvent as object ??
            ReviewRequestRemovedEvent as object ??
            ReviewRequestedEvent as object ??
            RenamedEvent as object ??
            DemilestonedEvent as object ??
            MilestonedEvent as object ??
            UnlabeledEvent as object ??
            LabeledEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLabeledEvent || IsUnlabeledEvent || IsMilestonedEvent || IsDemilestonedEvent || IsRenamedEvent || IsReviewRequestedEvent || IsReviewRequestRemovedEvent || IsReviewDismissedEvent || IsLockedEvent || IsAddedToProjectEvent || IsMovedColumnInProjectEvent || IsRemovedFromProjectEvent || IsConvertedNoteToEvent || IsCommentEvent || IsCrossReferencedEvent || IsCommittedEvent || IsReviewedEvent || IsLineCommentedEvent || IsCommitCommentedEvent || IsAssignedEvent || IsUnassignedEvent || IsStateChangeEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LabeledEvent,
                typeof(global::GitHub.LabeledIssueEvent),
                UnlabeledEvent,
                typeof(global::GitHub.UnlabeledIssueEvent),
                MilestonedEvent,
                typeof(global::GitHub.MilestonedIssueEvent),
                DemilestonedEvent,
                typeof(global::GitHub.DemilestonedIssueEvent),
                RenamedEvent,
                typeof(global::GitHub.RenamedIssueEvent),
                ReviewRequestedEvent,
                typeof(global::GitHub.ReviewRequestedIssueEvent),
                ReviewRequestRemovedEvent,
                typeof(global::GitHub.ReviewRequestRemovedIssueEvent),
                ReviewDismissedEvent,
                typeof(global::GitHub.ReviewDismissedIssueEvent),
                LockedEvent,
                typeof(global::GitHub.LockedIssueEvent),
                AddedToProjectEvent,
                typeof(global::GitHub.AddedToProjectIssueEvent),
                MovedColumnInProjectEvent,
                typeof(global::GitHub.MovedColumnInProjectIssueEvent),
                RemovedFromProjectEvent,
                typeof(global::GitHub.RemovedFromProjectIssueEvent),
                ConvertedNoteToEvent,
                typeof(global::GitHub.ConvertedNoteToIssueIssueEvent),
                CommentEvent,
                typeof(global::GitHub.TimelineCommentEvent),
                CrossReferencedEvent,
                typeof(global::GitHub.TimelineCrossReferencedEvent),
                CommittedEvent,
                typeof(global::GitHub.TimelineCommittedEvent),
                ReviewedEvent,
                typeof(global::GitHub.TimelineReviewedEvent),
                LineCommentedEvent,
                typeof(global::GitHub.TimelineLineCommentedEvent),
                CommitCommentedEvent,
                typeof(global::GitHub.TimelineCommitCommentedEvent),
                AssignedEvent,
                typeof(global::GitHub.TimelineAssignedIssueEvent),
                UnassignedEvent,
                typeof(global::GitHub.TimelineUnassignedIssueEvent),
                StateChangeEvent,
                typeof(global::GitHub.StateChangeIssueEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TimelineIssueEvents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.LabeledIssueEvent?>.Default.Equals(LabeledEvent, other.LabeledEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.UnlabeledIssueEvent?>.Default.Equals(UnlabeledEvent, other.UnlabeledEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.MilestonedIssueEvent?>.Default.Equals(MilestonedEvent, other.MilestonedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.DemilestonedIssueEvent?>.Default.Equals(DemilestonedEvent, other.DemilestonedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RenamedIssueEvent?>.Default.Equals(RenamedEvent, other.RenamedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ReviewRequestedIssueEvent?>.Default.Equals(ReviewRequestedEvent, other.ReviewRequestedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ReviewRequestRemovedIssueEvent?>.Default.Equals(ReviewRequestRemovedEvent, other.ReviewRequestRemovedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ReviewDismissedIssueEvent?>.Default.Equals(ReviewDismissedEvent, other.ReviewDismissedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.LockedIssueEvent?>.Default.Equals(LockedEvent, other.LockedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AddedToProjectIssueEvent?>.Default.Equals(AddedToProjectEvent, other.AddedToProjectEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.MovedColumnInProjectIssueEvent?>.Default.Equals(MovedColumnInProjectEvent, other.MovedColumnInProjectEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RemovedFromProjectIssueEvent?>.Default.Equals(RemovedFromProjectEvent, other.RemovedFromProjectEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ConvertedNoteToIssueIssueEvent?>.Default.Equals(ConvertedNoteToEvent, other.ConvertedNoteToEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.TimelineCommentEvent?>.Default.Equals(CommentEvent, other.CommentEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.TimelineCrossReferencedEvent?>.Default.Equals(CrossReferencedEvent, other.CrossReferencedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.TimelineCommittedEvent?>.Default.Equals(CommittedEvent, other.CommittedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.TimelineReviewedEvent?>.Default.Equals(ReviewedEvent, other.ReviewedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.TimelineLineCommentedEvent?>.Default.Equals(LineCommentedEvent, other.LineCommentedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.TimelineCommitCommentedEvent?>.Default.Equals(CommitCommentedEvent, other.CommitCommentedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.TimelineAssignedIssueEvent?>.Default.Equals(AssignedEvent, other.AssignedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.TimelineUnassignedIssueEvent?>.Default.Equals(UnassignedEvent, other.UnassignedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.StateChangeIssueEvent?>.Default.Equals(StateChangeEvent, other.StateChangeEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TimelineIssueEvents obj1, TimelineIssueEvents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TimelineIssueEvents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TimelineIssueEvents obj1, TimelineIssueEvents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TimelineIssueEvents o && Equals(o);
        }
    }
}
