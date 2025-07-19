#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// A repository rule.
    /// </summary>
    public readonly partial struct OrgRules : global::System.IEquatable<OrgRules>
    {
        /// <summary>
        /// Only allow users with bypass permission to create matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCreation? RepositoryRuleCreation { get; init; }
#else
        public global::GitHub.RepositoryRuleCreation? RepositoryRuleCreation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleCreation))]
#endif
        public bool IsRepositoryRuleCreation => RepositoryRuleCreation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleCreation value) => new OrgRules((global::GitHub.RepositoryRuleCreation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCreation?(OrgRules @this) => @this.RepositoryRuleCreation;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleCreation? value)
        {
            RepositoryRuleCreation = value;
        }

        /// <summary>
        /// Only allow users with bypass permission to update matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleUpdate? RepositoryRuleUpdate { get; init; }
#else
        public global::GitHub.RepositoryRuleUpdate? RepositoryRuleUpdate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleUpdate))]
#endif
        public bool IsRepositoryRuleUpdate => RepositoryRuleUpdate != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleUpdate value) => new OrgRules((global::GitHub.RepositoryRuleUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleUpdate?(OrgRules @this) => @this.RepositoryRuleUpdate;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleUpdate? value)
        {
            RepositoryRuleUpdate = value;
        }

        /// <summary>
        /// Only allow users with bypass permissions to delete matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleDeletion? RepositoryRuleDeletion { get; init; }
#else
        public global::GitHub.RepositoryRuleDeletion? RepositoryRuleDeletion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDeletion))]
#endif
        public bool IsRepositoryRuleDeletion => RepositoryRuleDeletion != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleDeletion value) => new OrgRules((global::GitHub.RepositoryRuleDeletion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleDeletion?(OrgRules @this) => @this.RepositoryRuleDeletion;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleDeletion? value)
        {
            RepositoryRuleDeletion = value;
        }

        /// <summary>
        /// Prevent merge commits from being pushed to matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleRequiredLinearHistory? RepositoryRuleRequiredLinearHistory { get; init; }
#else
        public global::GitHub.RepositoryRuleRequiredLinearHistory? RepositoryRuleRequiredLinearHistory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleRequiredLinearHistory))]
#endif
        public bool IsRepositoryRuleRequiredLinearHistory => RepositoryRuleRequiredLinearHistory != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleRequiredLinearHistory value) => new OrgRules((global::GitHub.RepositoryRuleRequiredLinearHistory?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleRequiredLinearHistory?(OrgRules @this) => @this.RepositoryRuleRequiredLinearHistory;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleRequiredLinearHistory? value)
        {
            RepositoryRuleRequiredLinearHistory = value;
        }

        /// <summary>
        /// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleRequiredDeployments? RepositoryRuleRequiredDeployments { get; init; }
#else
        public global::GitHub.RepositoryRuleRequiredDeployments? RepositoryRuleRequiredDeployments { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleRequiredDeployments))]
#endif
        public bool IsRepositoryRuleRequiredDeployments => RepositoryRuleRequiredDeployments != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleRequiredDeployments value) => new OrgRules((global::GitHub.RepositoryRuleRequiredDeployments?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleRequiredDeployments?(OrgRules @this) => @this.RepositoryRuleRequiredDeployments;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleRequiredDeployments? value)
        {
            RepositoryRuleRequiredDeployments = value;
        }

        /// <summary>
        /// Commits pushed to matching refs must have verified signatures.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleRequiredSignatures? RepositoryRuleRequiredSignatures { get; init; }
#else
        public global::GitHub.RepositoryRuleRequiredSignatures? RepositoryRuleRequiredSignatures { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleRequiredSignatures))]
#endif
        public bool IsRepositoryRuleRequiredSignatures => RepositoryRuleRequiredSignatures != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleRequiredSignatures value) => new OrgRules((global::GitHub.RepositoryRuleRequiredSignatures?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleRequiredSignatures?(OrgRules @this) => @this.RepositoryRuleRequiredSignatures;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleRequiredSignatures? value)
        {
            RepositoryRuleRequiredSignatures = value;
        }

        /// <summary>
        /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRulePullRequest? RepositoryRulePullRequest { get; init; }
#else
        public global::GitHub.RepositoryRulePullRequest? RepositoryRulePullRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRulePullRequest))]
#endif
        public bool IsRepositoryRulePullRequest => RepositoryRulePullRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRulePullRequest value) => new OrgRules((global::GitHub.RepositoryRulePullRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRulePullRequest?(OrgRules @this) => @this.RepositoryRulePullRequest;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRulePullRequest? value)
        {
            RepositoryRulePullRequest = value;
        }

        /// <summary>
        /// Choose which status checks must pass before the ref is updated. When enabled, commits must first be pushed to another ref where the checks pass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleRequiredStatusChecks? RepositoryRuleRequiredStatusChecks { get; init; }
#else
        public global::GitHub.RepositoryRuleRequiredStatusChecks? RepositoryRuleRequiredStatusChecks { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleRequiredStatusChecks))]
#endif
        public bool IsRepositoryRuleRequiredStatusChecks => RepositoryRuleRequiredStatusChecks != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleRequiredStatusChecks value) => new OrgRules((global::GitHub.RepositoryRuleRequiredStatusChecks?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleRequiredStatusChecks?(OrgRules @this) => @this.RepositoryRuleRequiredStatusChecks;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleRequiredStatusChecks? value)
        {
            RepositoryRuleRequiredStatusChecks = value;
        }

        /// <summary>
        /// Prevent users with push access from force pushing to refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleNonFastForward? RepositoryRuleNonFastForward { get; init; }
#else
        public global::GitHub.RepositoryRuleNonFastForward? RepositoryRuleNonFastForward { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleNonFastForward))]
#endif
        public bool IsRepositoryRuleNonFastForward => RepositoryRuleNonFastForward != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleNonFastForward value) => new OrgRules((global::GitHub.RepositoryRuleNonFastForward?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleNonFastForward?(OrgRules @this) => @this.RepositoryRuleNonFastForward;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleNonFastForward? value)
        {
            RepositoryRuleNonFastForward = value;
        }

        /// <summary>
        /// Parameters to be used for the commit_message_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCommitMessagePattern? RepositoryRuleCommitMessagePattern { get; init; }
#else
        public global::GitHub.RepositoryRuleCommitMessagePattern? RepositoryRuleCommitMessagePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleCommitMessagePattern))]
#endif
        public bool IsRepositoryRuleCommitMessagePattern => RepositoryRuleCommitMessagePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleCommitMessagePattern value) => new OrgRules((global::GitHub.RepositoryRuleCommitMessagePattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCommitMessagePattern?(OrgRules @this) => @this.RepositoryRuleCommitMessagePattern;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleCommitMessagePattern? value)
        {
            RepositoryRuleCommitMessagePattern = value;
        }

        /// <summary>
        /// Parameters to be used for the commit_author_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCommitAuthorEmailPattern? RepositoryRuleCommitAuthorEmailPattern { get; init; }
#else
        public global::GitHub.RepositoryRuleCommitAuthorEmailPattern? RepositoryRuleCommitAuthorEmailPattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleCommitAuthorEmailPattern))]
#endif
        public bool IsRepositoryRuleCommitAuthorEmailPattern => RepositoryRuleCommitAuthorEmailPattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleCommitAuthorEmailPattern value) => new OrgRules((global::GitHub.RepositoryRuleCommitAuthorEmailPattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCommitAuthorEmailPattern?(OrgRules @this) => @this.RepositoryRuleCommitAuthorEmailPattern;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            RepositoryRuleCommitAuthorEmailPattern = value;
        }

        /// <summary>
        /// Parameters to be used for the committer_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCommitterEmailPattern? RepositoryRuleCommitterEmailPattern { get; init; }
#else
        public global::GitHub.RepositoryRuleCommitterEmailPattern? RepositoryRuleCommitterEmailPattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleCommitterEmailPattern))]
#endif
        public bool IsRepositoryRuleCommitterEmailPattern => RepositoryRuleCommitterEmailPattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleCommitterEmailPattern value) => new OrgRules((global::GitHub.RepositoryRuleCommitterEmailPattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCommitterEmailPattern?(OrgRules @this) => @this.RepositoryRuleCommitterEmailPattern;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleCommitterEmailPattern? value)
        {
            RepositoryRuleCommitterEmailPattern = value;
        }

        /// <summary>
        /// Parameters to be used for the branch_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleBranchNamePattern? RepositoryRuleBranchNamePattern { get; init; }
#else
        public global::GitHub.RepositoryRuleBranchNamePattern? RepositoryRuleBranchNamePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleBranchNamePattern))]
#endif
        public bool IsRepositoryRuleBranchNamePattern => RepositoryRuleBranchNamePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleBranchNamePattern value) => new OrgRules((global::GitHub.RepositoryRuleBranchNamePattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleBranchNamePattern?(OrgRules @this) => @this.RepositoryRuleBranchNamePattern;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleBranchNamePattern? value)
        {
            RepositoryRuleBranchNamePattern = value;
        }

        /// <summary>
        /// Parameters to be used for the tag_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleTagNamePattern? RepositoryRuleTagNamePattern { get; init; }
#else
        public global::GitHub.RepositoryRuleTagNamePattern? RepositoryRuleTagNamePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleTagNamePattern))]
#endif
        public bool IsRepositoryRuleTagNamePattern => RepositoryRuleTagNamePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleTagNamePattern value) => new OrgRules((global::GitHub.RepositoryRuleTagNamePattern?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleTagNamePattern?(OrgRules @this) => @this.RepositoryRuleTagNamePattern;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleTagNamePattern? value)
        {
            RepositoryRuleTagNamePattern = value;
        }

        /// <summary>
        /// Prevent commits that include changes in specified file and folder paths from being pushed to the commit graph. This includes absolute paths that contain file names.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleFilePathRestriction? RepositoryRuleFilePathRestriction { get; init; }
#else
        public global::GitHub.RepositoryRuleFilePathRestriction? RepositoryRuleFilePathRestriction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleFilePathRestriction))]
#endif
        public bool IsRepositoryRuleFilePathRestriction => RepositoryRuleFilePathRestriction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleFilePathRestriction value) => new OrgRules((global::GitHub.RepositoryRuleFilePathRestriction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleFilePathRestriction?(OrgRules @this) => @this.RepositoryRuleFilePathRestriction;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleFilePathRestriction? value)
        {
            RepositoryRuleFilePathRestriction = value;
        }

        /// <summary>
        /// Prevent commits that include file paths that exceed the specified character limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleMaxFilePathLength? RepositoryRuleMaxFilePathLength { get; init; }
#else
        public global::GitHub.RepositoryRuleMaxFilePathLength? RepositoryRuleMaxFilePathLength { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleMaxFilePathLength))]
#endif
        public bool IsRepositoryRuleMaxFilePathLength => RepositoryRuleMaxFilePathLength != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleMaxFilePathLength value) => new OrgRules((global::GitHub.RepositoryRuleMaxFilePathLength?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleMaxFilePathLength?(OrgRules @this) => @this.RepositoryRuleMaxFilePathLength;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleMaxFilePathLength? value)
        {
            RepositoryRuleMaxFilePathLength = value;
        }

        /// <summary>
        /// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleFileExtensionRestriction? RepositoryRuleFileExtensionRestriction { get; init; }
#else
        public global::GitHub.RepositoryRuleFileExtensionRestriction? RepositoryRuleFileExtensionRestriction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleFileExtensionRestriction))]
#endif
        public bool IsRepositoryRuleFileExtensionRestriction => RepositoryRuleFileExtensionRestriction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleFileExtensionRestriction value) => new OrgRules((global::GitHub.RepositoryRuleFileExtensionRestriction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleFileExtensionRestriction?(OrgRules @this) => @this.RepositoryRuleFileExtensionRestriction;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleFileExtensionRestriction? value)
        {
            RepositoryRuleFileExtensionRestriction = value;
        }

        /// <summary>
        /// Prevent commits with individual files that exceed the specified limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleMaxFileSize? RepositoryRuleMaxFileSize { get; init; }
#else
        public global::GitHub.RepositoryRuleMaxFileSize? RepositoryRuleMaxFileSize { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleMaxFileSize))]
#endif
        public bool IsRepositoryRuleMaxFileSize => RepositoryRuleMaxFileSize != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleMaxFileSize value) => new OrgRules((global::GitHub.RepositoryRuleMaxFileSize?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleMaxFileSize?(OrgRules @this) => @this.RepositoryRuleMaxFileSize;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleMaxFileSize? value)
        {
            RepositoryRuleMaxFileSize = value;
        }

        /// <summary>
        /// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleWorkflows? RepositoryRuleWorkflows { get; init; }
#else
        public global::GitHub.RepositoryRuleWorkflows? RepositoryRuleWorkflows { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleWorkflows))]
#endif
        public bool IsRepositoryRuleWorkflows => RepositoryRuleWorkflows != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleWorkflows value) => new OrgRules((global::GitHub.RepositoryRuleWorkflows?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleWorkflows?(OrgRules @this) => @this.RepositoryRuleWorkflows;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleWorkflows? value)
        {
            RepositoryRuleWorkflows = value;
        }

        /// <summary>
        /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.RepositoryRuleCodeScanning? RepositoryRuleCodeScanning { get; init; }
#else
        public global::GitHub.RepositoryRuleCodeScanning? RepositoryRuleCodeScanning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleCodeScanning))]
#endif
        public bool IsRepositoryRuleCodeScanning => RepositoryRuleCodeScanning != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgRules(global::GitHub.RepositoryRuleCodeScanning value) => new OrgRules((global::GitHub.RepositoryRuleCodeScanning?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.RepositoryRuleCodeScanning?(OrgRules @this) => @this.RepositoryRuleCodeScanning;

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(global::GitHub.RepositoryRuleCodeScanning? value)
        {
            RepositoryRuleCodeScanning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrgRules(
            global::GitHub.RepositoryRuleCreation? repositoryRuleCreation,
            global::GitHub.RepositoryRuleUpdate? repositoryRuleUpdate,
            global::GitHub.RepositoryRuleDeletion? repositoryRuleDeletion,
            global::GitHub.RepositoryRuleRequiredLinearHistory? repositoryRuleRequiredLinearHistory,
            global::GitHub.RepositoryRuleRequiredDeployments? repositoryRuleRequiredDeployments,
            global::GitHub.RepositoryRuleRequiredSignatures? repositoryRuleRequiredSignatures,
            global::GitHub.RepositoryRulePullRequest? repositoryRulePullRequest,
            global::GitHub.RepositoryRuleRequiredStatusChecks? repositoryRuleRequiredStatusChecks,
            global::GitHub.RepositoryRuleNonFastForward? repositoryRuleNonFastForward,
            global::GitHub.RepositoryRuleCommitMessagePattern? repositoryRuleCommitMessagePattern,
            global::GitHub.RepositoryRuleCommitAuthorEmailPattern? repositoryRuleCommitAuthorEmailPattern,
            global::GitHub.RepositoryRuleCommitterEmailPattern? repositoryRuleCommitterEmailPattern,
            global::GitHub.RepositoryRuleBranchNamePattern? repositoryRuleBranchNamePattern,
            global::GitHub.RepositoryRuleTagNamePattern? repositoryRuleTagNamePattern,
            global::GitHub.RepositoryRuleFilePathRestriction? repositoryRuleFilePathRestriction,
            global::GitHub.RepositoryRuleMaxFilePathLength? repositoryRuleMaxFilePathLength,
            global::GitHub.RepositoryRuleFileExtensionRestriction? repositoryRuleFileExtensionRestriction,
            global::GitHub.RepositoryRuleMaxFileSize? repositoryRuleMaxFileSize,
            global::GitHub.RepositoryRuleWorkflows? repositoryRuleWorkflows,
            global::GitHub.RepositoryRuleCodeScanning? repositoryRuleCodeScanning
            )
        {
            RepositoryRuleCreation = repositoryRuleCreation;
            RepositoryRuleUpdate = repositoryRuleUpdate;
            RepositoryRuleDeletion = repositoryRuleDeletion;
            RepositoryRuleRequiredLinearHistory = repositoryRuleRequiredLinearHistory;
            RepositoryRuleRequiredDeployments = repositoryRuleRequiredDeployments;
            RepositoryRuleRequiredSignatures = repositoryRuleRequiredSignatures;
            RepositoryRulePullRequest = repositoryRulePullRequest;
            RepositoryRuleRequiredStatusChecks = repositoryRuleRequiredStatusChecks;
            RepositoryRuleNonFastForward = repositoryRuleNonFastForward;
            RepositoryRuleCommitMessagePattern = repositoryRuleCommitMessagePattern;
            RepositoryRuleCommitAuthorEmailPattern = repositoryRuleCommitAuthorEmailPattern;
            RepositoryRuleCommitterEmailPattern = repositoryRuleCommitterEmailPattern;
            RepositoryRuleBranchNamePattern = repositoryRuleBranchNamePattern;
            RepositoryRuleTagNamePattern = repositoryRuleTagNamePattern;
            RepositoryRuleFilePathRestriction = repositoryRuleFilePathRestriction;
            RepositoryRuleMaxFilePathLength = repositoryRuleMaxFilePathLength;
            RepositoryRuleFileExtensionRestriction = repositoryRuleFileExtensionRestriction;
            RepositoryRuleMaxFileSize = repositoryRuleMaxFileSize;
            RepositoryRuleWorkflows = repositoryRuleWorkflows;
            RepositoryRuleCodeScanning = repositoryRuleCodeScanning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RepositoryRuleCodeScanning as object ??
            RepositoryRuleWorkflows as object ??
            RepositoryRuleMaxFileSize as object ??
            RepositoryRuleFileExtensionRestriction as object ??
            RepositoryRuleMaxFilePathLength as object ??
            RepositoryRuleFilePathRestriction as object ??
            RepositoryRuleTagNamePattern as object ??
            RepositoryRuleBranchNamePattern as object ??
            RepositoryRuleCommitterEmailPattern as object ??
            RepositoryRuleCommitAuthorEmailPattern as object ??
            RepositoryRuleCommitMessagePattern as object ??
            RepositoryRuleNonFastForward as object ??
            RepositoryRuleRequiredStatusChecks as object ??
            RepositoryRulePullRequest as object ??
            RepositoryRuleRequiredSignatures as object ??
            RepositoryRuleRequiredDeployments as object ??
            RepositoryRuleRequiredLinearHistory as object ??
            RepositoryRuleDeletion as object ??
            RepositoryRuleUpdate as object ??
            RepositoryRuleCreation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RepositoryRuleCreation?.ToString() ??
            RepositoryRuleUpdate?.ToString() ??
            RepositoryRuleDeletion?.ToString() ??
            RepositoryRuleRequiredLinearHistory?.ToString() ??
            RepositoryRuleRequiredDeployments?.ToString() ??
            RepositoryRuleRequiredSignatures?.ToString() ??
            RepositoryRulePullRequest?.ToString() ??
            RepositoryRuleRequiredStatusChecks?.ToString() ??
            RepositoryRuleNonFastForward?.ToString() ??
            RepositoryRuleCommitMessagePattern?.ToString() ??
            RepositoryRuleCommitAuthorEmailPattern?.ToString() ??
            RepositoryRuleCommitterEmailPattern?.ToString() ??
            RepositoryRuleBranchNamePattern?.ToString() ??
            RepositoryRuleTagNamePattern?.ToString() ??
            RepositoryRuleFilePathRestriction?.ToString() ??
            RepositoryRuleMaxFilePathLength?.ToString() ??
            RepositoryRuleFileExtensionRestriction?.ToString() ??
            RepositoryRuleMaxFileSize?.ToString() ??
            RepositoryRuleWorkflows?.ToString() ??
            RepositoryRuleCodeScanning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && IsRepositoryRuleWorkflows && !IsRepositoryRuleCodeScanning || !IsRepositoryRuleCreation && !IsRepositoryRuleUpdate && !IsRepositoryRuleDeletion && !IsRepositoryRuleRequiredLinearHistory && !IsRepositoryRuleRequiredDeployments && !IsRepositoryRuleRequiredSignatures && !IsRepositoryRulePullRequest && !IsRepositoryRuleRequiredStatusChecks && !IsRepositoryRuleNonFastForward && !IsRepositoryRuleCommitMessagePattern && !IsRepositoryRuleCommitAuthorEmailPattern && !IsRepositoryRuleCommitterEmailPattern && !IsRepositoryRuleBranchNamePattern && !IsRepositoryRuleTagNamePattern && !IsRepositoryRuleFilePathRestriction && !IsRepositoryRuleMaxFilePathLength && !IsRepositoryRuleFileExtensionRestriction && !IsRepositoryRuleMaxFileSize && !IsRepositoryRuleWorkflows && IsRepositoryRuleCodeScanning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::GitHub.RepositoryRuleCreation?, TResult>? repositoryRuleCreation = null,
            global::System.Func<global::GitHub.RepositoryRuleUpdate?, TResult>? repositoryRuleUpdate = null,
            global::System.Func<global::GitHub.RepositoryRuleDeletion?, TResult>? repositoryRuleDeletion = null,
            global::System.Func<global::GitHub.RepositoryRuleRequiredLinearHistory?, TResult>? repositoryRuleRequiredLinearHistory = null,
            global::System.Func<global::GitHub.RepositoryRuleRequiredDeployments?, TResult>? repositoryRuleRequiredDeployments = null,
            global::System.Func<global::GitHub.RepositoryRuleRequiredSignatures?, TResult>? repositoryRuleRequiredSignatures = null,
            global::System.Func<global::GitHub.RepositoryRulePullRequest?, TResult>? repositoryRulePullRequest = null,
            global::System.Func<global::GitHub.RepositoryRuleRequiredStatusChecks?, TResult>? repositoryRuleRequiredStatusChecks = null,
            global::System.Func<global::GitHub.RepositoryRuleNonFastForward?, TResult>? repositoryRuleNonFastForward = null,
            global::System.Func<global::GitHub.RepositoryRuleCommitMessagePattern?, TResult>? repositoryRuleCommitMessagePattern = null,
            global::System.Func<global::GitHub.RepositoryRuleCommitAuthorEmailPattern?, TResult>? repositoryRuleCommitAuthorEmailPattern = null,
            global::System.Func<global::GitHub.RepositoryRuleCommitterEmailPattern?, TResult>? repositoryRuleCommitterEmailPattern = null,
            global::System.Func<global::GitHub.RepositoryRuleBranchNamePattern?, TResult>? repositoryRuleBranchNamePattern = null,
            global::System.Func<global::GitHub.RepositoryRuleTagNamePattern?, TResult>? repositoryRuleTagNamePattern = null,
            global::System.Func<global::GitHub.RepositoryRuleFilePathRestriction?, TResult>? repositoryRuleFilePathRestriction = null,
            global::System.Func<global::GitHub.RepositoryRuleMaxFilePathLength?, TResult>? repositoryRuleMaxFilePathLength = null,
            global::System.Func<global::GitHub.RepositoryRuleFileExtensionRestriction?, TResult>? repositoryRuleFileExtensionRestriction = null,
            global::System.Func<global::GitHub.RepositoryRuleMaxFileSize?, TResult>? repositoryRuleMaxFileSize = null,
            global::System.Func<global::GitHub.RepositoryRuleWorkflows?, TResult>? repositoryRuleWorkflows = null,
            global::System.Func<global::GitHub.RepositoryRuleCodeScanning?, TResult>? repositoryRuleCodeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryRuleCreation && repositoryRuleCreation != null)
            {
                return repositoryRuleCreation(RepositoryRuleCreation!);
            }
            else if (IsRepositoryRuleUpdate && repositoryRuleUpdate != null)
            {
                return repositoryRuleUpdate(RepositoryRuleUpdate!);
            }
            else if (IsRepositoryRuleDeletion && repositoryRuleDeletion != null)
            {
                return repositoryRuleDeletion(RepositoryRuleDeletion!);
            }
            else if (IsRepositoryRuleRequiredLinearHistory && repositoryRuleRequiredLinearHistory != null)
            {
                return repositoryRuleRequiredLinearHistory(RepositoryRuleRequiredLinearHistory!);
            }
            else if (IsRepositoryRuleRequiredDeployments && repositoryRuleRequiredDeployments != null)
            {
                return repositoryRuleRequiredDeployments(RepositoryRuleRequiredDeployments!);
            }
            else if (IsRepositoryRuleRequiredSignatures && repositoryRuleRequiredSignatures != null)
            {
                return repositoryRuleRequiredSignatures(RepositoryRuleRequiredSignatures!);
            }
            else if (IsRepositoryRulePullRequest && repositoryRulePullRequest != null)
            {
                return repositoryRulePullRequest(RepositoryRulePullRequest!);
            }
            else if (IsRepositoryRuleRequiredStatusChecks && repositoryRuleRequiredStatusChecks != null)
            {
                return repositoryRuleRequiredStatusChecks(RepositoryRuleRequiredStatusChecks!);
            }
            else if (IsRepositoryRuleNonFastForward && repositoryRuleNonFastForward != null)
            {
                return repositoryRuleNonFastForward(RepositoryRuleNonFastForward!);
            }
            else if (IsRepositoryRuleCommitMessagePattern && repositoryRuleCommitMessagePattern != null)
            {
                return repositoryRuleCommitMessagePattern(RepositoryRuleCommitMessagePattern!);
            }
            else if (IsRepositoryRuleCommitAuthorEmailPattern && repositoryRuleCommitAuthorEmailPattern != null)
            {
                return repositoryRuleCommitAuthorEmailPattern(RepositoryRuleCommitAuthorEmailPattern!);
            }
            else if (IsRepositoryRuleCommitterEmailPattern && repositoryRuleCommitterEmailPattern != null)
            {
                return repositoryRuleCommitterEmailPattern(RepositoryRuleCommitterEmailPattern!);
            }
            else if (IsRepositoryRuleBranchNamePattern && repositoryRuleBranchNamePattern != null)
            {
                return repositoryRuleBranchNamePattern(RepositoryRuleBranchNamePattern!);
            }
            else if (IsRepositoryRuleTagNamePattern && repositoryRuleTagNamePattern != null)
            {
                return repositoryRuleTagNamePattern(RepositoryRuleTagNamePattern!);
            }
            else if (IsRepositoryRuleFilePathRestriction && repositoryRuleFilePathRestriction != null)
            {
                return repositoryRuleFilePathRestriction(RepositoryRuleFilePathRestriction!);
            }
            else if (IsRepositoryRuleMaxFilePathLength && repositoryRuleMaxFilePathLength != null)
            {
                return repositoryRuleMaxFilePathLength(RepositoryRuleMaxFilePathLength!);
            }
            else if (IsRepositoryRuleFileExtensionRestriction && repositoryRuleFileExtensionRestriction != null)
            {
                return repositoryRuleFileExtensionRestriction(RepositoryRuleFileExtensionRestriction!);
            }
            else if (IsRepositoryRuleMaxFileSize && repositoryRuleMaxFileSize != null)
            {
                return repositoryRuleMaxFileSize(RepositoryRuleMaxFileSize!);
            }
            else if (IsRepositoryRuleWorkflows && repositoryRuleWorkflows != null)
            {
                return repositoryRuleWorkflows(RepositoryRuleWorkflows!);
            }
            else if (IsRepositoryRuleCodeScanning && repositoryRuleCodeScanning != null)
            {
                return repositoryRuleCodeScanning(RepositoryRuleCodeScanning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::GitHub.RepositoryRuleCreation?>? repositoryRuleCreation = null,
            global::System.Action<global::GitHub.RepositoryRuleUpdate?>? repositoryRuleUpdate = null,
            global::System.Action<global::GitHub.RepositoryRuleDeletion?>? repositoryRuleDeletion = null,
            global::System.Action<global::GitHub.RepositoryRuleRequiredLinearHistory?>? repositoryRuleRequiredLinearHistory = null,
            global::System.Action<global::GitHub.RepositoryRuleRequiredDeployments?>? repositoryRuleRequiredDeployments = null,
            global::System.Action<global::GitHub.RepositoryRuleRequiredSignatures?>? repositoryRuleRequiredSignatures = null,
            global::System.Action<global::GitHub.RepositoryRulePullRequest?>? repositoryRulePullRequest = null,
            global::System.Action<global::GitHub.RepositoryRuleRequiredStatusChecks?>? repositoryRuleRequiredStatusChecks = null,
            global::System.Action<global::GitHub.RepositoryRuleNonFastForward?>? repositoryRuleNonFastForward = null,
            global::System.Action<global::GitHub.RepositoryRuleCommitMessagePattern?>? repositoryRuleCommitMessagePattern = null,
            global::System.Action<global::GitHub.RepositoryRuleCommitAuthorEmailPattern?>? repositoryRuleCommitAuthorEmailPattern = null,
            global::System.Action<global::GitHub.RepositoryRuleCommitterEmailPattern?>? repositoryRuleCommitterEmailPattern = null,
            global::System.Action<global::GitHub.RepositoryRuleBranchNamePattern?>? repositoryRuleBranchNamePattern = null,
            global::System.Action<global::GitHub.RepositoryRuleTagNamePattern?>? repositoryRuleTagNamePattern = null,
            global::System.Action<global::GitHub.RepositoryRuleFilePathRestriction?>? repositoryRuleFilePathRestriction = null,
            global::System.Action<global::GitHub.RepositoryRuleMaxFilePathLength?>? repositoryRuleMaxFilePathLength = null,
            global::System.Action<global::GitHub.RepositoryRuleFileExtensionRestriction?>? repositoryRuleFileExtensionRestriction = null,
            global::System.Action<global::GitHub.RepositoryRuleMaxFileSize?>? repositoryRuleMaxFileSize = null,
            global::System.Action<global::GitHub.RepositoryRuleWorkflows?>? repositoryRuleWorkflows = null,
            global::System.Action<global::GitHub.RepositoryRuleCodeScanning?>? repositoryRuleCodeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryRuleCreation)
            {
                repositoryRuleCreation?.Invoke(RepositoryRuleCreation!);
            }
            else if (IsRepositoryRuleUpdate)
            {
                repositoryRuleUpdate?.Invoke(RepositoryRuleUpdate!);
            }
            else if (IsRepositoryRuleDeletion)
            {
                repositoryRuleDeletion?.Invoke(RepositoryRuleDeletion!);
            }
            else if (IsRepositoryRuleRequiredLinearHistory)
            {
                repositoryRuleRequiredLinearHistory?.Invoke(RepositoryRuleRequiredLinearHistory!);
            }
            else if (IsRepositoryRuleRequiredDeployments)
            {
                repositoryRuleRequiredDeployments?.Invoke(RepositoryRuleRequiredDeployments!);
            }
            else if (IsRepositoryRuleRequiredSignatures)
            {
                repositoryRuleRequiredSignatures?.Invoke(RepositoryRuleRequiredSignatures!);
            }
            else if (IsRepositoryRulePullRequest)
            {
                repositoryRulePullRequest?.Invoke(RepositoryRulePullRequest!);
            }
            else if (IsRepositoryRuleRequiredStatusChecks)
            {
                repositoryRuleRequiredStatusChecks?.Invoke(RepositoryRuleRequiredStatusChecks!);
            }
            else if (IsRepositoryRuleNonFastForward)
            {
                repositoryRuleNonFastForward?.Invoke(RepositoryRuleNonFastForward!);
            }
            else if (IsRepositoryRuleCommitMessagePattern)
            {
                repositoryRuleCommitMessagePattern?.Invoke(RepositoryRuleCommitMessagePattern!);
            }
            else if (IsRepositoryRuleCommitAuthorEmailPattern)
            {
                repositoryRuleCommitAuthorEmailPattern?.Invoke(RepositoryRuleCommitAuthorEmailPattern!);
            }
            else if (IsRepositoryRuleCommitterEmailPattern)
            {
                repositoryRuleCommitterEmailPattern?.Invoke(RepositoryRuleCommitterEmailPattern!);
            }
            else if (IsRepositoryRuleBranchNamePattern)
            {
                repositoryRuleBranchNamePattern?.Invoke(RepositoryRuleBranchNamePattern!);
            }
            else if (IsRepositoryRuleTagNamePattern)
            {
                repositoryRuleTagNamePattern?.Invoke(RepositoryRuleTagNamePattern!);
            }
            else if (IsRepositoryRuleFilePathRestriction)
            {
                repositoryRuleFilePathRestriction?.Invoke(RepositoryRuleFilePathRestriction!);
            }
            else if (IsRepositoryRuleMaxFilePathLength)
            {
                repositoryRuleMaxFilePathLength?.Invoke(RepositoryRuleMaxFilePathLength!);
            }
            else if (IsRepositoryRuleFileExtensionRestriction)
            {
                repositoryRuleFileExtensionRestriction?.Invoke(RepositoryRuleFileExtensionRestriction!);
            }
            else if (IsRepositoryRuleMaxFileSize)
            {
                repositoryRuleMaxFileSize?.Invoke(RepositoryRuleMaxFileSize!);
            }
            else if (IsRepositoryRuleWorkflows)
            {
                repositoryRuleWorkflows?.Invoke(RepositoryRuleWorkflows!);
            }
            else if (IsRepositoryRuleCodeScanning)
            {
                repositoryRuleCodeScanning?.Invoke(RepositoryRuleCodeScanning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RepositoryRuleCreation,
                typeof(global::GitHub.RepositoryRuleCreation),
                RepositoryRuleUpdate,
                typeof(global::GitHub.RepositoryRuleUpdate),
                RepositoryRuleDeletion,
                typeof(global::GitHub.RepositoryRuleDeletion),
                RepositoryRuleRequiredLinearHistory,
                typeof(global::GitHub.RepositoryRuleRequiredLinearHistory),
                RepositoryRuleRequiredDeployments,
                typeof(global::GitHub.RepositoryRuleRequiredDeployments),
                RepositoryRuleRequiredSignatures,
                typeof(global::GitHub.RepositoryRuleRequiredSignatures),
                RepositoryRulePullRequest,
                typeof(global::GitHub.RepositoryRulePullRequest),
                RepositoryRuleRequiredStatusChecks,
                typeof(global::GitHub.RepositoryRuleRequiredStatusChecks),
                RepositoryRuleNonFastForward,
                typeof(global::GitHub.RepositoryRuleNonFastForward),
                RepositoryRuleCommitMessagePattern,
                typeof(global::GitHub.RepositoryRuleCommitMessagePattern),
                RepositoryRuleCommitAuthorEmailPattern,
                typeof(global::GitHub.RepositoryRuleCommitAuthorEmailPattern),
                RepositoryRuleCommitterEmailPattern,
                typeof(global::GitHub.RepositoryRuleCommitterEmailPattern),
                RepositoryRuleBranchNamePattern,
                typeof(global::GitHub.RepositoryRuleBranchNamePattern),
                RepositoryRuleTagNamePattern,
                typeof(global::GitHub.RepositoryRuleTagNamePattern),
                RepositoryRuleFilePathRestriction,
                typeof(global::GitHub.RepositoryRuleFilePathRestriction),
                RepositoryRuleMaxFilePathLength,
                typeof(global::GitHub.RepositoryRuleMaxFilePathLength),
                RepositoryRuleFileExtensionRestriction,
                typeof(global::GitHub.RepositoryRuleFileExtensionRestriction),
                RepositoryRuleMaxFileSize,
                typeof(global::GitHub.RepositoryRuleMaxFileSize),
                RepositoryRuleWorkflows,
                typeof(global::GitHub.RepositoryRuleWorkflows),
                RepositoryRuleCodeScanning,
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
        public bool Equals(OrgRules other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCreation?>.Default.Equals(RepositoryRuleCreation, other.RepositoryRuleCreation) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleUpdate?>.Default.Equals(RepositoryRuleUpdate, other.RepositoryRuleUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleDeletion?>.Default.Equals(RepositoryRuleDeletion, other.RepositoryRuleDeletion) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleRequiredLinearHistory?>.Default.Equals(RepositoryRuleRequiredLinearHistory, other.RepositoryRuleRequiredLinearHistory) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleRequiredDeployments?>.Default.Equals(RepositoryRuleRequiredDeployments, other.RepositoryRuleRequiredDeployments) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleRequiredSignatures?>.Default.Equals(RepositoryRuleRequiredSignatures, other.RepositoryRuleRequiredSignatures) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRulePullRequest?>.Default.Equals(RepositoryRulePullRequest, other.RepositoryRulePullRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleRequiredStatusChecks?>.Default.Equals(RepositoryRuleRequiredStatusChecks, other.RepositoryRuleRequiredStatusChecks) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleNonFastForward?>.Default.Equals(RepositoryRuleNonFastForward, other.RepositoryRuleNonFastForward) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCommitMessagePattern?>.Default.Equals(RepositoryRuleCommitMessagePattern, other.RepositoryRuleCommitMessagePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCommitAuthorEmailPattern?>.Default.Equals(RepositoryRuleCommitAuthorEmailPattern, other.RepositoryRuleCommitAuthorEmailPattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCommitterEmailPattern?>.Default.Equals(RepositoryRuleCommitterEmailPattern, other.RepositoryRuleCommitterEmailPattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleBranchNamePattern?>.Default.Equals(RepositoryRuleBranchNamePattern, other.RepositoryRuleBranchNamePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleTagNamePattern?>.Default.Equals(RepositoryRuleTagNamePattern, other.RepositoryRuleTagNamePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleFilePathRestriction?>.Default.Equals(RepositoryRuleFilePathRestriction, other.RepositoryRuleFilePathRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleMaxFilePathLength?>.Default.Equals(RepositoryRuleMaxFilePathLength, other.RepositoryRuleMaxFilePathLength) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleFileExtensionRestriction?>.Default.Equals(RepositoryRuleFileExtensionRestriction, other.RepositoryRuleFileExtensionRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleMaxFileSize?>.Default.Equals(RepositoryRuleMaxFileSize, other.RepositoryRuleMaxFileSize) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleWorkflows?>.Default.Equals(RepositoryRuleWorkflows, other.RepositoryRuleWorkflows) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.RepositoryRuleCodeScanning?>.Default.Equals(RepositoryRuleCodeScanning, other.RepositoryRuleCodeScanning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrgRules obj1, OrgRules obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgRules>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrgRules obj1, OrgRules obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgRules o && Equals(o);
        }
    }
}
