#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// A repository rule with ruleset details.
    /// </summary>
    public readonly partial struct RepositoryRuleDetailed : global::System.IEquatable<RepositoryRuleDetailed>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? Value1 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? Value2 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? Value3 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? Value4 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>? Value5 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? Value6 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? Value7 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? Value8 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? Value9 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? Value10 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value11 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? Value12 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? Value13 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value14 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value15 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value15;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>? Value16 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>? Value16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value16;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value16 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>? Value17 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>? Value17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value17))]
#endif
        public bool IsValue17 => Value17 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value17;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value17 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>? Value18 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>? Value18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value18))]
#endif
        public bool IsValue18 => Value18 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value18;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value18 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>? Value19 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>? Value19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value19))]
#endif
        public bool IsValue19 => Value19 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value19;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value19 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? Value20 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? Value20 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value20))]
#endif
        public bool IsValue20 => Value20 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value20;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value20 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? Value21 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? Value21 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value21))]
#endif
        public bool IsValue21 => Value21 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value21;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value21 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(
            global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? value1,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? value2,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? value3,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? value4,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>? value5,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? value6,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? value7,
            global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? value8,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? value9,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? value10,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? value11,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value12,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value13,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value14,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value15,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>? value16,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>? value17,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>? value18,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>? value19,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? value20,
            global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? value21
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
            Value15 = value15;
            Value16 = value16;
            Value17 = value17;
            Value18 = value18;
            Value19 = value19;
            Value20 = value20;
            Value21 = value21;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value21 as object ??
            Value20 as object ??
            Value19 as object ??
            Value18 as object ??
            Value17 as object ??
            Value16 as object ??
            Value15 as object ??
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && IsValue21;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value1 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value2 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value3 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value4 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value5 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value6 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value7 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value8 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value9 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value10 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value11 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value12 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value13 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value14 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value15 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value16 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value17 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value18 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value19 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value20 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>?, TResult>? value21 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }
            else if (IsValue15 && value15 != null)
            {
                return value15(Value15!);
            }
            else if (IsValue16 && value16 != null)
            {
                return value16(Value16!);
            }
            else if (IsValue17 && value17 != null)
            {
                return value17(Value17!);
            }
            else if (IsValue18 && value18 != null)
            {
                return value18(Value18!);
            }
            else if (IsValue19 && value19 != null)
            {
                return value19(Value19!);
            }
            else if (IsValue20 && value20 != null)
            {
                return value20(Value20!);
            }
            else if (IsValue21 && value21 != null)
            {
                return value21(Value21!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>?>? value1 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>?>? value2 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>?>? value3 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>?>? value4 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>?>? value5 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>?>? value6 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>?>? value7 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>?>? value8 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>?>? value9 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>?>? value10 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>?>? value11 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?>? value12 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?>? value13 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?>? value14 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?>? value15 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>?>? value16 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>?>? value17 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>?>? value18 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>?>? value19 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>?>? value20 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>?>? value21 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
            else if (IsValue15)
            {
                value15?.Invoke(Value15!);
            }
            else if (IsValue16)
            {
                value16?.Invoke(Value16!);
            }
            else if (IsValue17)
            {
                value17?.Invoke(Value17!);
            }
            else if (IsValue18)
            {
                value18?.Invoke(Value18!);
            }
            else if (IsValue19)
            {
                value19?.Invoke(Value19!);
            }
            else if (IsValue20)
            {
                value20?.Invoke(Value20!);
            }
            else if (IsValue21)
            {
                value21?.Invoke(Value21!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>),
                Value2,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>),
                Value3,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>),
                Value4,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>),
                Value5,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>),
                Value6,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>),
                Value7,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>),
                Value8,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>),
                Value9,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>),
                Value10,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>),
                Value11,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value12,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value13,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value14,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value15,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value16,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>),
                Value17,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>),
                Value18,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>),
                Value19,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>),
                Value20,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>),
                Value21,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>),
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
        public bool Equals(RepositoryRuleDetailed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleFilePathRestriction, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFilePathLength, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value17, other.Value17) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleFileExtensionRestriction, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value18, other.Value18) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleMaxFileSize, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value19, other.Value19) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value20, other.Value20) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value21, other.Value21) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoryRuleDetailed obj1, RepositoryRuleDetailed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoryRuleDetailed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoryRuleDetailed obj1, RepositoryRuleDetailed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoryRuleDetailed o && Equals(o);
        }
    }
}
