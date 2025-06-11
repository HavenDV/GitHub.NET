#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// Details on the location where the token was initially detected. This can be a commit, wiki commit, issue, discussion, pull request.
    /// </summary>
    public readonly partial struct NullableSecretScanningFirstDetectedLocation : global::System.IEquatable<NullableSecretScanningFirstDetectedLocation>
    {
        /// <summary>
        /// Represents a 'commit' secret scanning location type. This location type shows that a secret was detected inside a commit to a repository.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationCommit? Commit { get; init; }
#else
        public global::GitHub.SecretScanningLocationCommit? Commit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Commit))]
#endif
        public bool IsCommit => Commit != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationCommit value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationCommit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationCommit?(NullableSecretScanningFirstDetectedLocation @this) => @this.Commit;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationCommit? value)
        {
            Commit = value;
        }

        /// <summary>
        /// Represents a 'wiki_commit' secret scanning location type. This location type shows that a secret was detected inside a commit to a repository wiki.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationWikiCommit? WikiCommit { get; init; }
#else
        public global::GitHub.SecretScanningLocationWikiCommit? WikiCommit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WikiCommit))]
#endif
        public bool IsWikiCommit => WikiCommit != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationWikiCommit value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationWikiCommit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationWikiCommit?(NullableSecretScanningFirstDetectedLocation @this) => @this.WikiCommit;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationWikiCommit? value)
        {
            WikiCommit = value;
        }

        /// <summary>
        /// Represents an 'issue_title' secret scanning location type. This location type shows that a secret was detected in the title of an issue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationIssueTitle? IssueTitle { get; init; }
#else
        public global::GitHub.SecretScanningLocationIssueTitle? IssueTitle { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueTitle))]
#endif
        public bool IsIssueTitle => IssueTitle != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationIssueTitle value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationIssueTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationIssueTitle?(NullableSecretScanningFirstDetectedLocation @this) => @this.IssueTitle;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationIssueTitle? value)
        {
            IssueTitle = value;
        }

        /// <summary>
        /// Represents an 'issue_body' secret scanning location type. This location type shows that a secret was detected in the body of an issue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationIssueBody? IssueBody { get; init; }
#else
        public global::GitHub.SecretScanningLocationIssueBody? IssueBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueBody))]
#endif
        public bool IsIssueBody => IssueBody != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationIssueBody value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationIssueBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationIssueBody?(NullableSecretScanningFirstDetectedLocation @this) => @this.IssueBody;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationIssueBody? value)
        {
            IssueBody = value;
        }

        /// <summary>
        /// Represents an 'issue_comment' secret scanning location type. This location type shows that a secret was detected in a comment on an issue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationIssueComment? IssueComment { get; init; }
#else
        public global::GitHub.SecretScanningLocationIssueComment? IssueComment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueComment))]
#endif
        public bool IsIssueComment => IssueComment != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationIssueComment value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationIssueComment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationIssueComment?(NullableSecretScanningFirstDetectedLocation @this) => @this.IssueComment;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationIssueComment? value)
        {
            IssueComment = value;
        }

        /// <summary>
        /// Represents a 'discussion_title' secret scanning location type. This location type shows that a secret was detected in the title of a discussion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationDiscussionTitle? DiscussionTitle { get; init; }
#else
        public global::GitHub.SecretScanningLocationDiscussionTitle? DiscussionTitle { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DiscussionTitle))]
#endif
        public bool IsDiscussionTitle => DiscussionTitle != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationDiscussionTitle value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationDiscussionTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationDiscussionTitle?(NullableSecretScanningFirstDetectedLocation @this) => @this.DiscussionTitle;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationDiscussionTitle? value)
        {
            DiscussionTitle = value;
        }

        /// <summary>
        /// Represents a 'discussion_body' secret scanning location type. This location type shows that a secret was detected in the body of a discussion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationDiscussionBody? DiscussionBody { get; init; }
#else
        public global::GitHub.SecretScanningLocationDiscussionBody? DiscussionBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DiscussionBody))]
#endif
        public bool IsDiscussionBody => DiscussionBody != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationDiscussionBody value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationDiscussionBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationDiscussionBody?(NullableSecretScanningFirstDetectedLocation @this) => @this.DiscussionBody;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationDiscussionBody? value)
        {
            DiscussionBody = value;
        }

        /// <summary>
        /// Represents a 'discussion_comment' secret scanning location type. This location type shows that a secret was detected in a comment on a discussion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationDiscussionComment? DiscussionComment { get; init; }
#else
        public global::GitHub.SecretScanningLocationDiscussionComment? DiscussionComment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DiscussionComment))]
#endif
        public bool IsDiscussionComment => DiscussionComment != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationDiscussionComment value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationDiscussionComment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationDiscussionComment?(NullableSecretScanningFirstDetectedLocation @this) => @this.DiscussionComment;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationDiscussionComment? value)
        {
            DiscussionComment = value;
        }

        /// <summary>
        /// Represents a 'pull_request_title' secret scanning location type. This location type shows that a secret was detected in the title of a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationPullRequestTitle? PullRequestTitle { get; init; }
#else
        public global::GitHub.SecretScanningLocationPullRequestTitle? PullRequestTitle { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestTitle))]
#endif
        public bool IsPullRequestTitle => PullRequestTitle != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestTitle value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationPullRequestTitle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationPullRequestTitle?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestTitle;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestTitle? value)
        {
            PullRequestTitle = value;
        }

        /// <summary>
        /// Represents a 'pull_request_body' secret scanning location type. This location type shows that a secret was detected in the body of a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationPullRequestBody? PullRequestBody { get; init; }
#else
        public global::GitHub.SecretScanningLocationPullRequestBody? PullRequestBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestBody))]
#endif
        public bool IsPullRequestBody => PullRequestBody != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestBody value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationPullRequestBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationPullRequestBody?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestBody;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestBody? value)
        {
            PullRequestBody = value;
        }

        /// <summary>
        /// Represents a 'pull_request_comment' secret scanning location type. This location type shows that a secret was detected in a comment on a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationPullRequestComment? PullRequestComment { get; init; }
#else
        public global::GitHub.SecretScanningLocationPullRequestComment? PullRequestComment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestComment))]
#endif
        public bool IsPullRequestComment => PullRequestComment != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestComment value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationPullRequestComment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationPullRequestComment?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestComment;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestComment? value)
        {
            PullRequestComment = value;
        }

        /// <summary>
        /// Represents a 'pull_request_review' secret scanning location type. This location type shows that a secret was detected in a review on a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationPullRequestReview? PullRequestReview { get; init; }
#else
        public global::GitHub.SecretScanningLocationPullRequestReview? PullRequestReview { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestReview))]
#endif
        public bool IsPullRequestReview => PullRequestReview != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestReview value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationPullRequestReview?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationPullRequestReview?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestReview;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestReview? value)
        {
            PullRequestReview = value;
        }

        /// <summary>
        /// Represents a 'pull_request_review_comment' secret scanning location type. This location type shows that a secret was detected in a review comment on a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.SecretScanningLocationPullRequestReviewComment? PullRequestReviewComment { get; init; }
#else
        public global::GitHub.SecretScanningLocationPullRequestReviewComment? PullRequestReviewComment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestReviewComment))]
#endif
        public bool IsPullRequestReviewComment => PullRequestReviewComment != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestReviewComment value) => new NullableSecretScanningFirstDetectedLocation((global::GitHub.SecretScanningLocationPullRequestReviewComment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.SecretScanningLocationPullRequestReviewComment?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestReviewComment;

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::GitHub.SecretScanningLocationPullRequestReviewComment? value)
        {
            PullRequestReviewComment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(
            global::GitHub.SecretScanningLocationCommit? commit,
            global::GitHub.SecretScanningLocationWikiCommit? wikiCommit,
            global::GitHub.SecretScanningLocationIssueTitle? issueTitle,
            global::GitHub.SecretScanningLocationIssueBody? issueBody,
            global::GitHub.SecretScanningLocationIssueComment? issueComment,
            global::GitHub.SecretScanningLocationDiscussionTitle? discussionTitle,
            global::GitHub.SecretScanningLocationDiscussionBody? discussionBody,
            global::GitHub.SecretScanningLocationDiscussionComment? discussionComment,
            global::GitHub.SecretScanningLocationPullRequestTitle? pullRequestTitle,
            global::GitHub.SecretScanningLocationPullRequestBody? pullRequestBody,
            global::GitHub.SecretScanningLocationPullRequestComment? pullRequestComment,
            global::GitHub.SecretScanningLocationPullRequestReview? pullRequestReview,
            global::GitHub.SecretScanningLocationPullRequestReviewComment? pullRequestReviewComment
            )
        {
            Commit = commit;
            WikiCommit = wikiCommit;
            IssueTitle = issueTitle;
            IssueBody = issueBody;
            IssueComment = issueComment;
            DiscussionTitle = discussionTitle;
            DiscussionBody = discussionBody;
            DiscussionComment = discussionComment;
            PullRequestTitle = pullRequestTitle;
            PullRequestBody = pullRequestBody;
            PullRequestComment = pullRequestComment;
            PullRequestReview = pullRequestReview;
            PullRequestReviewComment = pullRequestReviewComment;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PullRequestReviewComment as object ??
            PullRequestReview as object ??
            PullRequestComment as object ??
            PullRequestBody as object ??
            PullRequestTitle as object ??
            DiscussionComment as object ??
            DiscussionBody as object ??
            DiscussionTitle as object ??
            IssueComment as object ??
            IssueBody as object ??
            IssueTitle as object ??
            WikiCommit as object ??
            Commit as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Commit?.ToString() ??
            WikiCommit?.ToString() ??
            IssueTitle?.ToString() ??
            IssueBody?.ToString() ??
            IssueComment?.ToString() ??
            DiscussionTitle?.ToString() ??
            DiscussionBody?.ToString() ??
            DiscussionComment?.ToString() ??
            PullRequestTitle?.ToString() ??
            PullRequestBody?.ToString() ??
            PullRequestComment?.ToString() ??
            PullRequestReview?.ToString() ??
            PullRequestReviewComment?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && IsPullRequestReviewComment;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::GitHub.SecretScanningLocationCommit?, TResult>? commit = null,
            global::System.Func<global::GitHub.SecretScanningLocationWikiCommit?, TResult>? wikiCommit = null,
            global::System.Func<global::GitHub.SecretScanningLocationIssueTitle?, TResult>? issueTitle = null,
            global::System.Func<global::GitHub.SecretScanningLocationIssueBody?, TResult>? issueBody = null,
            global::System.Func<global::GitHub.SecretScanningLocationIssueComment?, TResult>? issueComment = null,
            global::System.Func<global::GitHub.SecretScanningLocationDiscussionTitle?, TResult>? discussionTitle = null,
            global::System.Func<global::GitHub.SecretScanningLocationDiscussionBody?, TResult>? discussionBody = null,
            global::System.Func<global::GitHub.SecretScanningLocationDiscussionComment?, TResult>? discussionComment = null,
            global::System.Func<global::GitHub.SecretScanningLocationPullRequestTitle?, TResult>? pullRequestTitle = null,
            global::System.Func<global::GitHub.SecretScanningLocationPullRequestBody?, TResult>? pullRequestBody = null,
            global::System.Func<global::GitHub.SecretScanningLocationPullRequestComment?, TResult>? pullRequestComment = null,
            global::System.Func<global::GitHub.SecretScanningLocationPullRequestReview?, TResult>? pullRequestReview = null,
            global::System.Func<global::GitHub.SecretScanningLocationPullRequestReviewComment?, TResult>? pullRequestReviewComment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommit && commit != null)
            {
                return commit(Commit!);
            }
            else if (IsWikiCommit && wikiCommit != null)
            {
                return wikiCommit(WikiCommit!);
            }
            else if (IsIssueTitle && issueTitle != null)
            {
                return issueTitle(IssueTitle!);
            }
            else if (IsIssueBody && issueBody != null)
            {
                return issueBody(IssueBody!);
            }
            else if (IsIssueComment && issueComment != null)
            {
                return issueComment(IssueComment!);
            }
            else if (IsDiscussionTitle && discussionTitle != null)
            {
                return discussionTitle(DiscussionTitle!);
            }
            else if (IsDiscussionBody && discussionBody != null)
            {
                return discussionBody(DiscussionBody!);
            }
            else if (IsDiscussionComment && discussionComment != null)
            {
                return discussionComment(DiscussionComment!);
            }
            else if (IsPullRequestTitle && pullRequestTitle != null)
            {
                return pullRequestTitle(PullRequestTitle!);
            }
            else if (IsPullRequestBody && pullRequestBody != null)
            {
                return pullRequestBody(PullRequestBody!);
            }
            else if (IsPullRequestComment && pullRequestComment != null)
            {
                return pullRequestComment(PullRequestComment!);
            }
            else if (IsPullRequestReview && pullRequestReview != null)
            {
                return pullRequestReview(PullRequestReview!);
            }
            else if (IsPullRequestReviewComment && pullRequestReviewComment != null)
            {
                return pullRequestReviewComment(PullRequestReviewComment!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::GitHub.SecretScanningLocationCommit?>? commit = null,
            global::System.Action<global::GitHub.SecretScanningLocationWikiCommit?>? wikiCommit = null,
            global::System.Action<global::GitHub.SecretScanningLocationIssueTitle?>? issueTitle = null,
            global::System.Action<global::GitHub.SecretScanningLocationIssueBody?>? issueBody = null,
            global::System.Action<global::GitHub.SecretScanningLocationIssueComment?>? issueComment = null,
            global::System.Action<global::GitHub.SecretScanningLocationDiscussionTitle?>? discussionTitle = null,
            global::System.Action<global::GitHub.SecretScanningLocationDiscussionBody?>? discussionBody = null,
            global::System.Action<global::GitHub.SecretScanningLocationDiscussionComment?>? discussionComment = null,
            global::System.Action<global::GitHub.SecretScanningLocationPullRequestTitle?>? pullRequestTitle = null,
            global::System.Action<global::GitHub.SecretScanningLocationPullRequestBody?>? pullRequestBody = null,
            global::System.Action<global::GitHub.SecretScanningLocationPullRequestComment?>? pullRequestComment = null,
            global::System.Action<global::GitHub.SecretScanningLocationPullRequestReview?>? pullRequestReview = null,
            global::System.Action<global::GitHub.SecretScanningLocationPullRequestReviewComment?>? pullRequestReviewComment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommit)
            {
                commit?.Invoke(Commit!);
            }
            else if (IsWikiCommit)
            {
                wikiCommit?.Invoke(WikiCommit!);
            }
            else if (IsIssueTitle)
            {
                issueTitle?.Invoke(IssueTitle!);
            }
            else if (IsIssueBody)
            {
                issueBody?.Invoke(IssueBody!);
            }
            else if (IsIssueComment)
            {
                issueComment?.Invoke(IssueComment!);
            }
            else if (IsDiscussionTitle)
            {
                discussionTitle?.Invoke(DiscussionTitle!);
            }
            else if (IsDiscussionBody)
            {
                discussionBody?.Invoke(DiscussionBody!);
            }
            else if (IsDiscussionComment)
            {
                discussionComment?.Invoke(DiscussionComment!);
            }
            else if (IsPullRequestTitle)
            {
                pullRequestTitle?.Invoke(PullRequestTitle!);
            }
            else if (IsPullRequestBody)
            {
                pullRequestBody?.Invoke(PullRequestBody!);
            }
            else if (IsPullRequestComment)
            {
                pullRequestComment?.Invoke(PullRequestComment!);
            }
            else if (IsPullRequestReview)
            {
                pullRequestReview?.Invoke(PullRequestReview!);
            }
            else if (IsPullRequestReviewComment)
            {
                pullRequestReviewComment?.Invoke(PullRequestReviewComment!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Commit,
                typeof(global::GitHub.SecretScanningLocationCommit),
                WikiCommit,
                typeof(global::GitHub.SecretScanningLocationWikiCommit),
                IssueTitle,
                typeof(global::GitHub.SecretScanningLocationIssueTitle),
                IssueBody,
                typeof(global::GitHub.SecretScanningLocationIssueBody),
                IssueComment,
                typeof(global::GitHub.SecretScanningLocationIssueComment),
                DiscussionTitle,
                typeof(global::GitHub.SecretScanningLocationDiscussionTitle),
                DiscussionBody,
                typeof(global::GitHub.SecretScanningLocationDiscussionBody),
                DiscussionComment,
                typeof(global::GitHub.SecretScanningLocationDiscussionComment),
                PullRequestTitle,
                typeof(global::GitHub.SecretScanningLocationPullRequestTitle),
                PullRequestBody,
                typeof(global::GitHub.SecretScanningLocationPullRequestBody),
                PullRequestComment,
                typeof(global::GitHub.SecretScanningLocationPullRequestComment),
                PullRequestReview,
                typeof(global::GitHub.SecretScanningLocationPullRequestReview),
                PullRequestReviewComment,
                typeof(global::GitHub.SecretScanningLocationPullRequestReviewComment),
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
        public bool Equals(NullableSecretScanningFirstDetectedLocation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationCommit?>.Default.Equals(Commit, other.Commit) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationWikiCommit?>.Default.Equals(WikiCommit, other.WikiCommit) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationIssueTitle?>.Default.Equals(IssueTitle, other.IssueTitle) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationIssueBody?>.Default.Equals(IssueBody, other.IssueBody) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationIssueComment?>.Default.Equals(IssueComment, other.IssueComment) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationDiscussionTitle?>.Default.Equals(DiscussionTitle, other.DiscussionTitle) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationDiscussionBody?>.Default.Equals(DiscussionBody, other.DiscussionBody) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationDiscussionComment?>.Default.Equals(DiscussionComment, other.DiscussionComment) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationPullRequestTitle?>.Default.Equals(PullRequestTitle, other.PullRequestTitle) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationPullRequestBody?>.Default.Equals(PullRequestBody, other.PullRequestBody) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationPullRequestComment?>.Default.Equals(PullRequestComment, other.PullRequestComment) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationPullRequestReview?>.Default.Equals(PullRequestReview, other.PullRequestReview) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.SecretScanningLocationPullRequestReviewComment?>.Default.Equals(PullRequestReviewComment, other.PullRequestReviewComment) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NullableSecretScanningFirstDetectedLocation obj1, NullableSecretScanningFirstDetectedLocation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NullableSecretScanningFirstDetectedLocation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NullableSecretScanningFirstDetectedLocation obj1, NullableSecretScanningFirstDetectedLocation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NullableSecretScanningFirstDetectedLocation o && Equals(o);
        }
    }
}
