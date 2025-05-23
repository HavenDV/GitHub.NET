#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// A repository rule.
    /// </summary>
    public readonly partial struct RepositoryRule : global::System.IEquatable<RepositoryRule>
    {
        /// <summary>
        /// Only allow users with bypass permission to create matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCreation? Creation { get; init; }
#else
        public global::GitHub.RepositoryRuleCreation? Creation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Creation))]
#endif
        public bool IsCreation => Creation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleCreation value) => new RepositoryRule((global::GitHub.RepositoryRuleCreation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCreation?(RepositoryRule @this) => @this.Creation;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleCreation? value)
        {
            Creation = value;
        }

        /// <summary>
        /// Only allow users with bypass permission to update matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleUpdate? Update { get; init; }
#else
        public global::GitHub.RepositoryRuleUpdate? Update { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Update))]
#endif
        public bool IsUpdate => Update != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleUpdate value) => new RepositoryRule((global::GitHub.RepositoryRuleUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleUpdate?(RepositoryRule @this) => @this.Update;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleUpdate? value)
        {
            Update = value;
        }

        /// <summary>
        /// Only allow users with bypass permissions to delete matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleDeletion? Deletion { get; init; }
#else
        public global::GitHub.RepositoryRuleDeletion? Deletion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deletion))]
#endif
        public bool IsDeletion => Deletion != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleDeletion value) => new RepositoryRule((global::GitHub.RepositoryRuleDeletion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleDeletion?(RepositoryRule @this) => @this.Deletion;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleDeletion? value)
        {
            Deletion = value;
        }

        /// <summary>
        /// Prevent merge commits from being pushed to matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleRequiredLinearHistory? RequiredLinearHistory { get; init; }
#else
        public global::GitHub.RepositoryRuleRequiredLinearHistory? RequiredLinearHistory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredLinearHistory))]
#endif
        public bool IsRequiredLinearHistory => RequiredLinearHistory != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleRequiredLinearHistory value) => new RepositoryRule((global::GitHub.RepositoryRuleRequiredLinearHistory?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleRequiredLinearHistory?(RepositoryRule @this) => @this.RequiredLinearHistory;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleRequiredLinearHistory? value)
        {
            RequiredLinearHistory = value;
        }

        /// <summary>
        /// Merges must be performed via a merge queue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleMergeQueue? MergeQueue { get; init; }
#else
        public global::GitHub.RepositoryRuleMergeQueue? MergeQueue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MergeQueue))]
#endif
        public bool IsMergeQueue => MergeQueue != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleMergeQueue value) => new RepositoryRule((global::GitHub.RepositoryRuleMergeQueue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleMergeQueue?(RepositoryRule @this) => @this.MergeQueue;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleMergeQueue? value)
        {
            MergeQueue = value;
        }

        /// <summary>
        /// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleRequiredDeployments? RequiredDeployments { get; init; }
#else
        public global::GitHub.RepositoryRuleRequiredDeployments? RequiredDeployments { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredDeployments))]
#endif
        public bool IsRequiredDeployments => RequiredDeployments != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleRequiredDeployments value) => new RepositoryRule((global::GitHub.RepositoryRuleRequiredDeployments?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleRequiredDeployments?(RepositoryRule @this) => @this.RequiredDeployments;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleRequiredDeployments? value)
        {
            RequiredDeployments = value;
        }

        /// <summary>
        /// Commits pushed to matching refs must have verified signatures.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleRequiredSignatures? RequiredSignatures { get; init; }
#else
        public global::GitHub.RepositoryRuleRequiredSignatures? RequiredSignatures { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredSignatures))]
#endif
        public bool IsRequiredSignatures => RequiredSignatures != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleRequiredSignatures value) => new RepositoryRule((global::GitHub.RepositoryRuleRequiredSignatures?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleRequiredSignatures?(RepositoryRule @this) => @this.RequiredSignatures;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleRequiredSignatures? value)
        {
            RequiredSignatures = value;
        }

        /// <summary>
        /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRulePullRequest? PullRequest { get; init; }
#else
        public global::GitHub.RepositoryRulePullRequest? PullRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequest))]
#endif
        public bool IsPullRequest => PullRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRulePullRequest value) => new RepositoryRule((global::GitHub.RepositoryRulePullRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRulePullRequest?(RepositoryRule @this) => @this.PullRequest;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRulePullRequest? value)
        {
            PullRequest = value;
        }

        /// <summary>
        /// Choose which status checks must pass before the ref is updated. When enabled, commits must first be pushed to another ref where the checks pass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleRequiredStatusChecks? RequiredStatusChecks { get; init; }
#else
        public global::GitHub.RepositoryRuleRequiredStatusChecks? RequiredStatusChecks { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredStatusChecks))]
#endif
        public bool IsRequiredStatusChecks => RequiredStatusChecks != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleRequiredStatusChecks value) => new RepositoryRule((global::GitHub.RepositoryRuleRequiredStatusChecks?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleRequiredStatusChecks?(RepositoryRule @this) => @this.RequiredStatusChecks;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleRequiredStatusChecks? value)
        {
            RequiredStatusChecks = value;
        }

        /// <summary>
        /// Prevent users with push access from force pushing to refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleNonFastForward? NonFastForward { get; init; }
#else
        public global::GitHub.RepositoryRuleNonFastForward? NonFastForward { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NonFastForward))]
#endif
        public bool IsNonFastForward => NonFastForward != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleNonFastForward value) => new RepositoryRule((global::GitHub.RepositoryRuleNonFastForward?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleNonFastForward?(RepositoryRule @this) => @this.NonFastForward;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleNonFastForward? value)
        {
            NonFastForward = value;
        }

        /// <summary>
        /// Parameters to be used for the commit_message_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCommitMessagePattern? CommitMessagePattern { get; init; }
#else
        public global::GitHub.RepositoryRuleCommitMessagePattern? CommitMessagePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitMessagePattern))]
#endif
        public bool IsCommitMessagePattern => CommitMessagePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleCommitMessagePattern value) => new RepositoryRule((global::GitHub.RepositoryRuleCommitMessagePattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCommitMessagePattern?(RepositoryRule @this) => @this.CommitMessagePattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleCommitMessagePattern? value)
        {
            CommitMessagePattern = value;
        }

        /// <summary>
        /// Parameters to be used for the commit_author_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCommitAuthorEmailPattern? CommitAuthorEmailPattern { get; init; }
#else
        public global::GitHub.RepositoryRuleCommitAuthorEmailPattern? CommitAuthorEmailPattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitAuthorEmailPattern))]
#endif
        public bool IsCommitAuthorEmailPattern => CommitAuthorEmailPattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleCommitAuthorEmailPattern value) => new RepositoryRule((global::GitHub.RepositoryRuleCommitAuthorEmailPattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCommitAuthorEmailPattern?(RepositoryRule @this) => @this.CommitAuthorEmailPattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            CommitAuthorEmailPattern = value;
        }

        /// <summary>
        /// Parameters to be used for the committer_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCommitterEmailPattern? CommitterEmailPattern { get; init; }
#else
        public global::GitHub.RepositoryRuleCommitterEmailPattern? CommitterEmailPattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitterEmailPattern))]
#endif
        public bool IsCommitterEmailPattern => CommitterEmailPattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleCommitterEmailPattern value) => new RepositoryRule((global::GitHub.RepositoryRuleCommitterEmailPattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCommitterEmailPattern?(RepositoryRule @this) => @this.CommitterEmailPattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleCommitterEmailPattern? value)
        {
            CommitterEmailPattern = value;
        }

        /// <summary>
        /// Parameters to be used for the branch_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleBranchNamePattern? BranchNamePattern { get; init; }
#else
        public global::GitHub.RepositoryRuleBranchNamePattern? BranchNamePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BranchNamePattern))]
#endif
        public bool IsBranchNamePattern => BranchNamePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleBranchNamePattern value) => new RepositoryRule((global::GitHub.RepositoryRuleBranchNamePattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleBranchNamePattern?(RepositoryRule @this) => @this.BranchNamePattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleBranchNamePattern? value)
        {
            BranchNamePattern = value;
        }

        /// <summary>
        /// Parameters to be used for the tag_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleTagNamePattern? TagNamePattern { get; init; }
#else
        public global::GitHub.RepositoryRuleTagNamePattern? TagNamePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TagNamePattern))]
#endif
        public bool IsTagNamePattern => TagNamePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleTagNamePattern value) => new RepositoryRule((global::GitHub.RepositoryRuleTagNamePattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleTagNamePattern?(RepositoryRule @this) => @this.TagNamePattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleTagNamePattern? value)
        {
            TagNamePattern = value;
        }

        /// <summary>
        /// Prevent commits that include changes in specified file and folder paths from being pushed to the commit graph. This includes absolute paths that contain file names.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleFilePathRestriction? FilePathRestriction { get; init; }
#else
        public global::GitHub.RepositoryRuleFilePathRestriction? FilePathRestriction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilePathRestriction))]
#endif
        public bool IsFilePathRestriction => FilePathRestriction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleFilePathRestriction value) => new RepositoryRule((global::GitHub.RepositoryRuleFilePathRestriction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleFilePathRestriction?(RepositoryRule @this) => @this.FilePathRestriction;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleFilePathRestriction? value)
        {
            FilePathRestriction = value;
        }

        /// <summary>
        /// Prevent commits that include file paths that exceed the specified character limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleMaxFilePathLength? MaxFilePathLength { get; init; }
#else
        public global::GitHub.RepositoryRuleMaxFilePathLength? MaxFilePathLength { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxFilePathLength))]
#endif
        public bool IsMaxFilePathLength => MaxFilePathLength != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleMaxFilePathLength value) => new RepositoryRule((global::GitHub.RepositoryRuleMaxFilePathLength?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleMaxFilePathLength?(RepositoryRule @this) => @this.MaxFilePathLength;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleMaxFilePathLength? value)
        {
            MaxFilePathLength = value;
        }

        /// <summary>
        /// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleFileExtensionRestriction? FileExtensionRestriction { get; init; }
#else
        public global::GitHub.RepositoryRuleFileExtensionRestriction? FileExtensionRestriction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExtensionRestriction))]
#endif
        public bool IsFileExtensionRestriction => FileExtensionRestriction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleFileExtensionRestriction value) => new RepositoryRule((global::GitHub.RepositoryRuleFileExtensionRestriction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleFileExtensionRestriction?(RepositoryRule @this) => @this.FileExtensionRestriction;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleFileExtensionRestriction? value)
        {
            FileExtensionRestriction = value;
        }

        /// <summary>
        /// Prevent commits with individual files that exceed the specified limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleMaxFileSize? MaxFileSize { get; init; }
#else
        public global::GitHub.RepositoryRuleMaxFileSize? MaxFileSize { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxFileSize))]
#endif
        public bool IsMaxFileSize => MaxFileSize != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleMaxFileSize value) => new RepositoryRule((global::GitHub.RepositoryRuleMaxFileSize?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleMaxFileSize?(RepositoryRule @this) => @this.MaxFileSize;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleMaxFileSize? value)
        {
            MaxFileSize = value;
        }

        /// <summary>
        /// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleWorkflows? Workflows { get; init; }
#else
        public global::GitHub.RepositoryRuleWorkflows? Workflows { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Workflows))]
#endif
        public bool IsWorkflows => Workflows != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleWorkflows value) => new RepositoryRule((global::GitHub.RepositoryRuleWorkflows?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleWorkflows?(RepositoryRule @this) => @this.Workflows;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleWorkflows? value)
        {
            Workflows = value;
        }

        /// <summary>
        /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCodeScanning? CodeScanning { get; init; }
#else
        public global::GitHub.RepositoryRuleCodeScanning? CodeScanning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeScanning))]
#endif
        public bool IsCodeScanning => CodeScanning != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::GitHub.RepositoryRuleCodeScanning value) => new RepositoryRule((global::GitHub.RepositoryRuleCodeScanning?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCodeScanning?(RepositoryRule @this) => @this.CodeScanning;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::GitHub.RepositoryRuleCodeScanning? value)
        {
            CodeScanning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(
            global::GitHub.RepositoryRuleCreation? creation,
            global::GitHub.RepositoryRuleUpdate? update,
            global::GitHub.RepositoryRuleDeletion? deletion,
            global::GitHub.RepositoryRuleRequiredLinearHistory? requiredLinearHistory,
            global::GitHub.RepositoryRuleMergeQueue? mergeQueue,
            global::GitHub.RepositoryRuleRequiredDeployments? requiredDeployments,
            global::GitHub.RepositoryRuleRequiredSignatures? requiredSignatures,
            global::GitHub.RepositoryRulePullRequest? pullRequest,
            global::GitHub.RepositoryRuleRequiredStatusChecks? requiredStatusChecks,
            global::GitHub.RepositoryRuleNonFastForward? nonFastForward,
            global::GitHub.RepositoryRuleCommitMessagePattern? commitMessagePattern,
            global::GitHub.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern,
            global::GitHub.RepositoryRuleCommitterEmailPattern? committerEmailPattern,
            global::GitHub.RepositoryRuleBranchNamePattern? branchNamePattern,
            global::GitHub.RepositoryRuleTagNamePattern? tagNamePattern,
            global::GitHub.RepositoryRuleFilePathRestriction? filePathRestriction,
            global::GitHub.RepositoryRuleMaxFilePathLength? maxFilePathLength,
            global::GitHub.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction,
            global::GitHub.RepositoryRuleMaxFileSize? maxFileSize,
            global::GitHub.RepositoryRuleWorkflows? workflows,
            global::GitHub.RepositoryRuleCodeScanning? codeScanning
            )
        {
            Creation = creation;
            Update = update;
            Deletion = deletion;
            RequiredLinearHistory = requiredLinearHistory;
            MergeQueue = mergeQueue;
            RequiredDeployments = requiredDeployments;
            RequiredSignatures = requiredSignatures;
            PullRequest = pullRequest;
            RequiredStatusChecks = requiredStatusChecks;
            NonFastForward = nonFastForward;
            CommitMessagePattern = commitMessagePattern;
            CommitAuthorEmailPattern = commitAuthorEmailPattern;
            CommitterEmailPattern = committerEmailPattern;
            BranchNamePattern = branchNamePattern;
            TagNamePattern = tagNamePattern;
            FilePathRestriction = filePathRestriction;
            MaxFilePathLength = maxFilePathLength;
            FileExtensionRestriction = fileExtensionRestriction;
            MaxFileSize = maxFileSize;
            Workflows = workflows;
            CodeScanning = codeScanning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeScanning as object ??
            Workflows as object ??
            MaxFileSize as object ??
            FileExtensionRestriction as object ??
            MaxFilePathLength as object ??
            FilePathRestriction as object ??
            TagNamePattern as object ??
            BranchNamePattern as object ??
            CommitterEmailPattern as object ??
            CommitAuthorEmailPattern as object ??
            CommitMessagePattern as object ??
            NonFastForward as object ??
            RequiredStatusChecks as object ??
            PullRequest as object ??
            RequiredSignatures as object ??
            RequiredDeployments as object ??
            MergeQueue as object ??
            RequiredLinearHistory as object ??
            Deletion as object ??
            Update as object ??
            Creation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Creation?.ToString() ??
            Update?.ToString() ??
            Deletion?.ToString() ??
            RequiredLinearHistory?.ToString() ??
            MergeQueue?.ToString() ??
            RequiredDeployments?.ToString() ??
            RequiredSignatures?.ToString() ??
            PullRequest?.ToString() ??
            RequiredStatusChecks?.ToString() ??
            NonFastForward?.ToString() ??
            CommitMessagePattern?.ToString() ??
            CommitAuthorEmailPattern?.ToString() ??
            CommitterEmailPattern?.ToString() ??
            BranchNamePattern?.ToString() ??
            TagNamePattern?.ToString() ??
            FilePathRestriction?.ToString() ??
            MaxFilePathLength?.ToString() ??
            FileExtensionRestriction?.ToString() ??
            MaxFileSize?.ToString() ??
            Workflows?.ToString() ??
            CodeScanning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && IsCodeScanning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::GitHub.RepositoryRuleCreation?, TResult>? creation = null,
            global::System.Func<global::GitHub.RepositoryRuleUpdate?, TResult>? update = null,
            global::System.Func<global::GitHub.RepositoryRuleDeletion?, TResult>? deletion = null,
            global::System.Func<global::GitHub.RepositoryRuleRequiredLinearHistory?, TResult>? requiredLinearHistory = null,
            global::System.Func<global::GitHub.RepositoryRuleMergeQueue?, TResult>? mergeQueue = null,
            global::System.Func<global::GitHub.RepositoryRuleRequiredDeployments?, TResult>? requiredDeployments = null,
            global::System.Func<global::GitHub.RepositoryRuleRequiredSignatures?, TResult>? requiredSignatures = null,
            global::System.Func<global::GitHub.RepositoryRulePullRequest?, TResult>? pullRequest = null,
            global::System.Func<global::GitHub.RepositoryRuleRequiredStatusChecks?, TResult>? requiredStatusChecks = null,
            global::System.Func<global::GitHub.RepositoryRuleNonFastForward?, TResult>? nonFastForward = null,
            global::System.Func<global::GitHub.RepositoryRuleCommitMessagePattern?, TResult>? commitMessagePattern = null,
            global::System.Func<global::GitHub.RepositoryRuleCommitAuthorEmailPattern?, TResult>? commitAuthorEmailPattern = null,
            global::System.Func<global::GitHub.RepositoryRuleCommitterEmailPattern?, TResult>? committerEmailPattern = null,
            global::System.Func<global::GitHub.RepositoryRuleBranchNamePattern?, TResult>? branchNamePattern = null,
            global::System.Func<global::GitHub.RepositoryRuleTagNamePattern?, TResult>? tagNamePattern = null,
            global::System.Func<global::GitHub.RepositoryRuleFilePathRestriction?, TResult>? filePathRestriction = null,
            global::System.Func<global::GitHub.RepositoryRuleMaxFilePathLength?, TResult>? maxFilePathLength = null,
            global::System.Func<global::GitHub.RepositoryRuleFileExtensionRestriction?, TResult>? fileExtensionRestriction = null,
            global::System.Func<global::GitHub.RepositoryRuleMaxFileSize?, TResult>? maxFileSize = null,
            global::System.Func<global::GitHub.RepositoryRuleWorkflows?, TResult>? workflows = null,
            global::System.Func<global::GitHub.RepositoryRuleCodeScanning?, TResult>? codeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreation && creation != null)
            {
                return creation(Creation!);
            }
            else if (IsUpdate && update != null)
            {
                return update(Update!);
            }
            else if (IsDeletion && deletion != null)
            {
                return deletion(Deletion!);
            }
            else if (IsRequiredLinearHistory && requiredLinearHistory != null)
            {
                return requiredLinearHistory(RequiredLinearHistory!);
            }
            else if (IsMergeQueue && mergeQueue != null)
            {
                return mergeQueue(MergeQueue!);
            }
            else if (IsRequiredDeployments && requiredDeployments != null)
            {
                return requiredDeployments(RequiredDeployments!);
            }
            else if (IsRequiredSignatures && requiredSignatures != null)
            {
                return requiredSignatures(RequiredSignatures!);
            }
            else if (IsPullRequest && pullRequest != null)
            {
                return pullRequest(PullRequest!);
            }
            else if (IsRequiredStatusChecks && requiredStatusChecks != null)
            {
                return requiredStatusChecks(RequiredStatusChecks!);
            }
            else if (IsNonFastForward && nonFastForward != null)
            {
                return nonFastForward(NonFastForward!);
            }
            else if (IsCommitMessagePattern && commitMessagePattern != null)
            {
                return commitMessagePattern(CommitMessagePattern!);
            }
            else if (IsCommitAuthorEmailPattern && commitAuthorEmailPattern != null)
            {
                return commitAuthorEmailPattern(CommitAuthorEmailPattern!);
            }
            else if (IsCommitterEmailPattern && committerEmailPattern != null)
            {
                return committerEmailPattern(CommitterEmailPattern!);
            }
            else if (IsBranchNamePattern && branchNamePattern != null)
            {
                return branchNamePattern(BranchNamePattern!);
            }
            else if (IsTagNamePattern && tagNamePattern != null)
            {
                return tagNamePattern(TagNamePattern!);
            }
            else if (IsFilePathRestriction && filePathRestriction != null)
            {
                return filePathRestriction(FilePathRestriction!);
            }
            else if (IsMaxFilePathLength && maxFilePathLength != null)
            {
                return maxFilePathLength(MaxFilePathLength!);
            }
            else if (IsFileExtensionRestriction && fileExtensionRestriction != null)
            {
                return fileExtensionRestriction(FileExtensionRestriction!);
            }
            else if (IsMaxFileSize && maxFileSize != null)
            {
                return maxFileSize(MaxFileSize!);
            }
            else if (IsWorkflows && workflows != null)
            {
                return workflows(Workflows!);
            }
            else if (IsCodeScanning && codeScanning != null)
            {
                return codeScanning(CodeScanning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::GitHub.RepositoryRuleCreation?>? creation = null,
            global::System.Action<global::GitHub.RepositoryRuleUpdate?>? update = null,
            global::System.Action<global::GitHub.RepositoryRuleDeletion?>? deletion = null,
            global::System.Action<global::GitHub.RepositoryRuleRequiredLinearHistory?>? requiredLinearHistory = null,
            global::System.Action<global::GitHub.RepositoryRuleMergeQueue?>? mergeQueue = null,
            global::System.Action<global::GitHub.RepositoryRuleRequiredDeployments?>? requiredDeployments = null,
            global::System.Action<global::GitHub.RepositoryRuleRequiredSignatures?>? requiredSignatures = null,
            global::System.Action<global::GitHub.RepositoryRulePullRequest?>? pullRequest = null,
            global::System.Action<global::GitHub.RepositoryRuleRequiredStatusChecks?>? requiredStatusChecks = null,
            global::System.Action<global::GitHub.RepositoryRuleNonFastForward?>? nonFastForward = null,
            global::System.Action<global::GitHub.RepositoryRuleCommitMessagePattern?>? commitMessagePattern = null,
            global::System.Action<global::GitHub.RepositoryRuleCommitAuthorEmailPattern?>? commitAuthorEmailPattern = null,
            global::System.Action<global::GitHub.RepositoryRuleCommitterEmailPattern?>? committerEmailPattern = null,
            global::System.Action<global::GitHub.RepositoryRuleBranchNamePattern?>? branchNamePattern = null,
            global::System.Action<global::GitHub.RepositoryRuleTagNamePattern?>? tagNamePattern = null,
            global::System.Action<global::GitHub.RepositoryRuleFilePathRestriction?>? filePathRestriction = null,
            global::System.Action<global::GitHub.RepositoryRuleMaxFilePathLength?>? maxFilePathLength = null,
            global::System.Action<global::GitHub.RepositoryRuleFileExtensionRestriction?>? fileExtensionRestriction = null,
            global::System.Action<global::GitHub.RepositoryRuleMaxFileSize?>? maxFileSize = null,
            global::System.Action<global::GitHub.RepositoryRuleWorkflows?>? workflows = null,
            global::System.Action<global::GitHub.RepositoryRuleCodeScanning?>? codeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreation)
            {
                creation?.Invoke(Creation!);
            }
            else if (IsUpdate)
            {
                update?.Invoke(Update!);
            }
            else if (IsDeletion)
            {
                deletion?.Invoke(Deletion!);
            }
            else if (IsRequiredLinearHistory)
            {
                requiredLinearHistory?.Invoke(RequiredLinearHistory!);
            }
            else if (IsMergeQueue)
            {
                mergeQueue?.Invoke(MergeQueue!);
            }
            else if (IsRequiredDeployments)
            {
                requiredDeployments?.Invoke(RequiredDeployments!);
            }
            else if (IsRequiredSignatures)
            {
                requiredSignatures?.Invoke(RequiredSignatures!);
            }
            else if (IsPullRequest)
            {
                pullRequest?.Invoke(PullRequest!);
            }
            else if (IsRequiredStatusChecks)
            {
                requiredStatusChecks?.Invoke(RequiredStatusChecks!);
            }
            else if (IsNonFastForward)
            {
                nonFastForward?.Invoke(NonFastForward!);
            }
            else if (IsCommitMessagePattern)
            {
                commitMessagePattern?.Invoke(CommitMessagePattern!);
            }
            else if (IsCommitAuthorEmailPattern)
            {
                commitAuthorEmailPattern?.Invoke(CommitAuthorEmailPattern!);
            }
            else if (IsCommitterEmailPattern)
            {
                committerEmailPattern?.Invoke(CommitterEmailPattern!);
            }
            else if (IsBranchNamePattern)
            {
                branchNamePattern?.Invoke(BranchNamePattern!);
            }
            else if (IsTagNamePattern)
            {
                tagNamePattern?.Invoke(TagNamePattern!);
            }
            else if (IsFilePathRestriction)
            {
                filePathRestriction?.Invoke(FilePathRestriction!);
            }
            else if (IsMaxFilePathLength)
            {
                maxFilePathLength?.Invoke(MaxFilePathLength!);
            }
            else if (IsFileExtensionRestriction)
            {
                fileExtensionRestriction?.Invoke(FileExtensionRestriction!);
            }
            else if (IsMaxFileSize)
            {
                maxFileSize?.Invoke(MaxFileSize!);
            }
            else if (IsWorkflows)
            {
                workflows?.Invoke(Workflows!);
            }
            else if (IsCodeScanning)
            {
                codeScanning?.Invoke(CodeScanning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Creation,
                typeof(global::GitHub.RepositoryRuleCreation),
                Update,
                typeof(global::GitHub.RepositoryRuleUpdate),
                Deletion,
                typeof(global::GitHub.RepositoryRuleDeletion),
                RequiredLinearHistory,
                typeof(global::GitHub.RepositoryRuleRequiredLinearHistory),
                MergeQueue,
                typeof(global::GitHub.RepositoryRuleMergeQueue),
                RequiredDeployments,
                typeof(global::GitHub.RepositoryRuleRequiredDeployments),
                RequiredSignatures,
                typeof(global::GitHub.RepositoryRuleRequiredSignatures),
                PullRequest,
                typeof(global::GitHub.RepositoryRulePullRequest),
                RequiredStatusChecks,
                typeof(global::GitHub.RepositoryRuleRequiredStatusChecks),
                NonFastForward,
                typeof(global::GitHub.RepositoryRuleNonFastForward),
                CommitMessagePattern,
                typeof(global::GitHub.RepositoryRuleCommitMessagePattern),
                CommitAuthorEmailPattern,
                typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern),
                CommitterEmailPattern,
                typeof(global::GitHub.RepositoryRuleCommitterEmailPattern),
                BranchNamePattern,
                typeof(global::GitHub.RepositoryRuleBranchNamePattern),
                TagNamePattern,
                typeof(global::GitHub.RepositoryRuleTagNamePattern),
                FilePathRestriction,
                typeof(global::GitHub.RepositoryRuleFilePathRestriction),
                MaxFilePathLength,
                typeof(global::GitHub.RepositoryRuleMaxFilePathLength),
                FileExtensionRestriction,
                typeof(global::GitHub.RepositoryRuleFileExtensionRestriction),
                MaxFileSize,
                typeof(global::GitHub.RepositoryRuleMaxFileSize),
                Workflows,
                typeof(global::GitHub.RepositoryRuleWorkflows),
                CodeScanning,
                typeof(global::GitHub.RepositoryRuleCodeScanning),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RepositoryRule other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCreation?>.Default.Equals(Creation, other.Creation) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleUpdate?>.Default.Equals(Update, other.Update) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleDeletion?>.Default.Equals(Deletion, other.Deletion) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleRequiredLinearHistory?>.Default.Equals(RequiredLinearHistory, other.RequiredLinearHistory) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleMergeQueue?>.Default.Equals(MergeQueue, other.MergeQueue) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleRequiredDeployments?>.Default.Equals(RequiredDeployments, other.RequiredDeployments) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleRequiredSignatures?>.Default.Equals(RequiredSignatures, other.RequiredSignatures) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRulePullRequest?>.Default.Equals(PullRequest, other.PullRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleRequiredStatusChecks?>.Default.Equals(RequiredStatusChecks, other.RequiredStatusChecks) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleNonFastForward?>.Default.Equals(NonFastForward, other.NonFastForward) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCommitMessagePattern?>.Default.Equals(CommitMessagePattern, other.CommitMessagePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCommitAuthorEmailPattern?>.Default.Equals(CommitAuthorEmailPattern, other.CommitAuthorEmailPattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCommitterEmailPattern?>.Default.Equals(CommitterEmailPattern, other.CommitterEmailPattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleBranchNamePattern?>.Default.Equals(BranchNamePattern, other.BranchNamePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleTagNamePattern?>.Default.Equals(TagNamePattern, other.TagNamePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleFilePathRestriction?>.Default.Equals(FilePathRestriction, other.FilePathRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleMaxFilePathLength?>.Default.Equals(MaxFilePathLength, other.MaxFilePathLength) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleFileExtensionRestriction?>.Default.Equals(FileExtensionRestriction, other.FileExtensionRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleMaxFileSize?>.Default.Equals(MaxFileSize, other.MaxFileSize) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleWorkflows?>.Default.Equals(Workflows, other.Workflows) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCodeScanning?>.Default.Equals(CodeScanning, other.CodeScanning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoryRule obj1, RepositoryRule obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoryRule>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoryRule obj1, RepositoryRule obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoryRule o && Equals(o);
        }
    }
}
