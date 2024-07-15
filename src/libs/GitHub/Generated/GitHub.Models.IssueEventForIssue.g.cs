using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// Issue Event for Issue
    /// </summary>
    public readonly struct IssueEventForIssue : global::System.IEquatable<IssueEventForIssue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.LabeledIssueEvent? Labeled { get; init; }
#else
        public global::GitHub.LabeledIssueEvent? Labeled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Labeled))]
#endif
        public bool IsLabeled => Labeled != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.LabeledIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.LabeledIssueEvent?(IssueEventForIssue @this) => @this.Labeled;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.LabeledIssueEvent? value)
        {
            Labeled = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.UnlabeledIssueEvent? Unlabeled { get; init; }
#else
        public global::GitHub.UnlabeledIssueEvent? Unlabeled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unlabeled))]
#endif
        public bool IsUnlabeled => Unlabeled != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.UnlabeledIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.UnlabeledIssueEvent?(IssueEventForIssue @this) => @this.Unlabeled;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.UnlabeledIssueEvent? value)
        {
            Unlabeled = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AssignedIssueEvent? Assigned { get; init; }
#else
        public global::GitHub.AssignedIssueEvent? Assigned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assigned))]
#endif
        public bool IsAssigned => Assigned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.AssignedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AssignedIssueEvent?(IssueEventForIssue @this) => @this.Assigned;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.AssignedIssueEvent? value)
        {
            Assigned = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.UnassignedIssueEvent? Unassigned { get; init; }
#else
        public global::GitHub.UnassignedIssueEvent? Unassigned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unassigned))]
#endif
        public bool IsUnassigned => Unassigned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.UnassignedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.UnassignedIssueEvent?(IssueEventForIssue @this) => @this.Unassigned;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.UnassignedIssueEvent? value)
        {
            Unassigned = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.MilestonedIssueEvent? Milestoned { get; init; }
#else
        public global::GitHub.MilestonedIssueEvent? Milestoned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Milestoned))]
#endif
        public bool IsMilestoned => Milestoned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.MilestonedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.MilestonedIssueEvent?(IssueEventForIssue @this) => @this.Milestoned;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.MilestonedIssueEvent? value)
        {
            Milestoned = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.DemilestonedIssueEvent? Demilestoned { get; init; }
#else
        public global::GitHub.DemilestonedIssueEvent? Demilestoned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Demilestoned))]
#endif
        public bool IsDemilestoned => Demilestoned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.DemilestonedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.DemilestonedIssueEvent?(IssueEventForIssue @this) => @this.Demilestoned;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.DemilestonedIssueEvent? value)
        {
            Demilestoned = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RenamedIssueEvent? Renamed { get; init; }
#else
        public global::GitHub.RenamedIssueEvent? Renamed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Renamed))]
#endif
        public bool IsRenamed => Renamed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.RenamedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RenamedIssueEvent?(IssueEventForIssue @this) => @this.Renamed;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.RenamedIssueEvent? value)
        {
            Renamed = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ReviewRequestedIssueEvent? ReviewRequested { get; init; }
#else
        public global::GitHub.ReviewRequestedIssueEvent? ReviewRequested { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequested))]
#endif
        public bool IsReviewRequested => ReviewRequested != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.ReviewRequestedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ReviewRequestedIssueEvent?(IssueEventForIssue @this) => @this.ReviewRequested;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.ReviewRequestedIssueEvent? value)
        {
            ReviewRequested = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ReviewRequestRemovedIssueEvent? ReviewRequestRemoved { get; init; }
#else
        public global::GitHub.ReviewRequestRemovedIssueEvent? ReviewRequestRemoved { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestRemoved))]
#endif
        public bool IsReviewRequestRemoved => ReviewRequestRemoved != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.ReviewRequestRemovedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ReviewRequestRemovedIssueEvent?(IssueEventForIssue @this) => @this.ReviewRequestRemoved;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.ReviewRequestRemovedIssueEvent? value)
        {
            ReviewRequestRemoved = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ReviewDismissedIssueEvent? ReviewDismissed { get; init; }
#else
        public global::GitHub.ReviewDismissedIssueEvent? ReviewDismissed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewDismissed))]
#endif
        public bool IsReviewDismissed => ReviewDismissed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.ReviewDismissedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ReviewDismissedIssueEvent?(IssueEventForIssue @this) => @this.ReviewDismissed;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.ReviewDismissedIssueEvent? value)
        {
            ReviewDismissed = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.LockedIssueEvent? Locked { get; init; }
#else
        public global::GitHub.LockedIssueEvent? Locked { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Locked))]
#endif
        public bool IsLocked => Locked != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.LockedIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.LockedIssueEvent?(IssueEventForIssue @this) => @this.Locked;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.LockedIssueEvent? value)
        {
            Locked = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AddedToProjectIssueEvent? AddedToProject { get; init; }
#else
        public global::GitHub.AddedToProjectIssueEvent? AddedToProject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddedToProject))]
#endif
        public bool IsAddedToProject => AddedToProject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.AddedToProjectIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AddedToProjectIssueEvent?(IssueEventForIssue @this) => @this.AddedToProject;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.AddedToProjectIssueEvent? value)
        {
            AddedToProject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.MovedColumnInProjectIssueEvent? MovedColumnInProject { get; init; }
#else
        public global::GitHub.MovedColumnInProjectIssueEvent? MovedColumnInProject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MovedColumnInProject))]
#endif
        public bool IsMovedColumnInProject => MovedColumnInProject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.MovedColumnInProjectIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.MovedColumnInProjectIssueEvent?(IssueEventForIssue @this) => @this.MovedColumnInProject;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.MovedColumnInProjectIssueEvent? value)
        {
            MovedColumnInProject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RemovedFromProjectIssueEvent? RemovedFromProject { get; init; }
#else
        public global::GitHub.RemovedFromProjectIssueEvent? RemovedFromProject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemovedFromProject))]
#endif
        public bool IsRemovedFromProject => RemovedFromProject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.RemovedFromProjectIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RemovedFromProjectIssueEvent?(IssueEventForIssue @this) => @this.RemovedFromProject;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.RemovedFromProjectIssueEvent? value)
        {
            RemovedFromProject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ConvertedNoteToIssueIssueEvent? ConvertedNoteTo { get; init; }
#else
        public global::GitHub.ConvertedNoteToIssueIssueEvent? ConvertedNoteTo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConvertedNoteTo))]
#endif
        public bool IsConvertedNoteTo => ConvertedNoteTo != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IssueEventForIssue(global::GitHub.ConvertedNoteToIssueIssueEvent value) => new IssueEventForIssue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ConvertedNoteToIssueIssueEvent?(IssueEventForIssue @this) => @this.ConvertedNoteTo;

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(global::GitHub.ConvertedNoteToIssueIssueEvent? value)
        {
            ConvertedNoteTo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IssueEventForIssue(
            global::GitHub.LabeledIssueEvent? labeled,
            global::GitHub.UnlabeledIssueEvent? unlabeled,
            global::GitHub.AssignedIssueEvent? assigned,
            global::GitHub.UnassignedIssueEvent? unassigned,
            global::GitHub.MilestonedIssueEvent? milestoned,
            global::GitHub.DemilestonedIssueEvent? demilestoned,
            global::GitHub.RenamedIssueEvent? renamed,
            global::GitHub.ReviewRequestedIssueEvent? reviewRequested,
            global::GitHub.ReviewRequestRemovedIssueEvent? reviewRequestRemoved,
            global::GitHub.ReviewDismissedIssueEvent? reviewDismissed,
            global::GitHub.LockedIssueEvent? locked,
            global::GitHub.AddedToProjectIssueEvent? addedToProject,
            global::GitHub.MovedColumnInProjectIssueEvent? movedColumnInProject,
            global::GitHub.RemovedFromProjectIssueEvent? removedFromProject,
            global::GitHub.ConvertedNoteToIssueIssueEvent? convertedNoteTo
            )
        {
            Labeled = labeled;
            Unlabeled = unlabeled;
            Assigned = assigned;
            Unassigned = unassigned;
            Milestoned = milestoned;
            Demilestoned = demilestoned;
            Renamed = renamed;
            ReviewRequested = reviewRequested;
            ReviewRequestRemoved = reviewRequestRemoved;
            ReviewDismissed = reviewDismissed;
            Locked = locked;
            AddedToProject = addedToProject;
            MovedColumnInProject = movedColumnInProject;
            RemovedFromProject = removedFromProject;
            ConvertedNoteTo = convertedNoteTo;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConvertedNoteTo as object ??
            RemovedFromProject as object ??
            MovedColumnInProject as object ??
            AddedToProject as object ??
            Locked as object ??
            ReviewDismissed as object ??
            ReviewRequestRemoved as object ??
            ReviewRequested as object ??
            Renamed as object ??
            Demilestoned as object ??
            Milestoned as object ??
            Unassigned as object ??
            Assigned as object ??
            Unlabeled as object ??
            Labeled as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLabeled || IsUnlabeled || IsAssigned || IsUnassigned || IsMilestoned || IsDemilestoned || IsRenamed || IsReviewRequested || IsReviewRequestRemoved || IsReviewDismissed || IsLocked || IsAddedToProject || IsMovedColumnInProject || IsRemovedFromProject || IsConvertedNoteTo;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Labeled,
                typeof(global::GitHub.LabeledIssueEvent),
                Unlabeled,
                typeof(global::GitHub.UnlabeledIssueEvent),
                Assigned,
                typeof(global::GitHub.AssignedIssueEvent),
                Unassigned,
                typeof(global::GitHub.UnassignedIssueEvent),
                Milestoned,
                typeof(global::GitHub.MilestonedIssueEvent),
                Demilestoned,
                typeof(global::GitHub.DemilestonedIssueEvent),
                Renamed,
                typeof(global::GitHub.RenamedIssueEvent),
                ReviewRequested,
                typeof(global::GitHub.ReviewRequestedIssueEvent),
                ReviewRequestRemoved,
                typeof(global::GitHub.ReviewRequestRemovedIssueEvent),
                ReviewDismissed,
                typeof(global::GitHub.ReviewDismissedIssueEvent),
                Locked,
                typeof(global::GitHub.LockedIssueEvent),
                AddedToProject,
                typeof(global::GitHub.AddedToProjectIssueEvent),
                MovedColumnInProject,
                typeof(global::GitHub.MovedColumnInProjectIssueEvent),
                RemovedFromProject,
                typeof(global::GitHub.RemovedFromProjectIssueEvent),
                ConvertedNoteTo,
                typeof(global::GitHub.ConvertedNoteToIssueIssueEvent),
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
        public bool Equals(IssueEventForIssue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.LabeledIssueEvent?>.Default.Equals(Labeled, other.Labeled) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.UnlabeledIssueEvent?>.Default.Equals(Unlabeled, other.Unlabeled) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AssignedIssueEvent?>.Default.Equals(Assigned, other.Assigned) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.UnassignedIssueEvent?>.Default.Equals(Unassigned, other.Unassigned) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.MilestonedIssueEvent?>.Default.Equals(Milestoned, other.Milestoned) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.DemilestonedIssueEvent?>.Default.Equals(Demilestoned, other.Demilestoned) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RenamedIssueEvent?>.Default.Equals(Renamed, other.Renamed) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ReviewRequestedIssueEvent?>.Default.Equals(ReviewRequested, other.ReviewRequested) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ReviewRequestRemovedIssueEvent?>.Default.Equals(ReviewRequestRemoved, other.ReviewRequestRemoved) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ReviewDismissedIssueEvent?>.Default.Equals(ReviewDismissed, other.ReviewDismissed) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.LockedIssueEvent?>.Default.Equals(Locked, other.Locked) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AddedToProjectIssueEvent?>.Default.Equals(AddedToProject, other.AddedToProject) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.MovedColumnInProjectIssueEvent?>.Default.Equals(MovedColumnInProject, other.MovedColumnInProject) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RemovedFromProjectIssueEvent?>.Default.Equals(RemovedFromProject, other.RemovedFromProject) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ConvertedNoteToIssueIssueEvent?>.Default.Equals(ConvertedNoteTo, other.ConvertedNoteTo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IssueEventForIssue obj1, IssueEventForIssue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IssueEventForIssue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IssueEventForIssue obj1, IssueEventForIssue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IssueEventForIssue o && Equals(o);
        }
    }
}
