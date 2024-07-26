using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// A repository rule with ruleset details.
    /// </summary>
    public readonly struct RepositoryRuleDetailed : global::System.IEquatable<RepositoryRuleDetailed>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? Value1 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? Value1 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? Value2 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? Value2 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? Value3 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? Value3 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? Value4 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? Value4 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>? Value5 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>? Value5 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? Value6 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? Value6 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? Value7 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? Value7 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? Value8 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? Value8 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? Value9 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? Value9 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? Value10 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? Value10 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value11 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value11 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? Value12 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? Value12 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? Value13 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? Value13 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value14 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value14 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value15 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? Value15 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value15;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? Value16 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? Value16 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value16;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value16 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? Value17 { get; init; }
#else
        public global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? Value17 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.Value17;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? value)
        {
            Value17 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(
            global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>? value1,
            global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>? value2,
            global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>? value3,
            global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>? value4,
            global::System.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>? value5,
            global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>? value6,
            global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>? value7,
            global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>? value8,
            global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>? value9,
            global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>? value10,
            global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>? value11,
            global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value12,
            global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>? value13,
            global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value14,
            global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>? value15,
            global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>? value16,
            global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>? value17
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && IsValue15 && !IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && IsValue16 && !IsValue17 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && IsValue17;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>),
                Value2,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>),
                Value3,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>),
                Value4,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>),
                Value5,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>),
                Value6,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>),
                Value7,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>),
                Value8,
                typeof(global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>),
                Value9,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>),
                Value10,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>),
                Value11,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value12,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value13,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value14,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value15,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>),
                Value16,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>),
                Value17,
                typeof(global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>),
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
        public bool Equals(RepositoryRuleDetailed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleCreation, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleUpdate, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleDeletion, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleRequiredLinearHistory, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleMergeQueue, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleRequiredDeployments, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleRequiredSignatures, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRulePullRequest, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleRequiredStatusChecks, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleNonFastForward, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleCommitMessagePattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleCommitAuthorEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleCommitterEmailPattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleBranchNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleTagNamePattern, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleWorkflows, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::GitHub.RepositoryRuleCodeScanning, global::GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(Value17, other.Value17) 
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
