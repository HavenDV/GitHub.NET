#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// Conditions for an organization ruleset.<br/>
    /// The branch and tag rulesets conditions object should contain both `repository_name` and `ref_name` properties, or both `repository_id` and `ref_name` properties, or both `repository_property` and `ref_name` properties.<br/>
    /// The push rulesets conditions object does not require the `ref_name` property.<br/>
    /// For repository policy rulesets, the conditions object should only contain the `repository_name`, the `repository_id`, or the `repository_property`.
    /// </summary>
    public readonly partial struct OrgRulesetConditions : global::System.IEquatable<OrgRulesetConditions>
    {
        /// <summary>
        /// Conditions to target repositories by name and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? Value1 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? Value1 { get; }
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
        public static implicit operator OrgRulesetConditions(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget> value) => new OrgRulesetConditions(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?(OrgRulesetConditions @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Conditions to target repositories by id and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? Value2 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? Value2 { get; }
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
        public static implicit operator OrgRulesetConditions(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget> value) => new OrgRulesetConditions(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?(OrgRulesetConditions @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Conditions to target repositories by property and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? Value3 { get; init; }
#else
        public global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? Value3 { get; }
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
        public static implicit operator OrgRulesetConditions(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget> value) => new OrgRulesetConditions(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?(OrgRulesetConditions @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrgRulesetConditions(
            global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? value1,
            global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? value2,
            global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?, TResult>? value1 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?, TResult>? value2 = null,
            global::System.Func<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?, TResult>? value3 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?>? value1 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?>? value2 = null,
            global::System.Action<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?>? value3 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>),
                Value2,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>),
                Value3,
                typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>),
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
        public bool Equals(OrgRulesetConditions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrgRulesetConditions obj1, OrgRulesetConditions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgRulesetConditions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrgRulesetConditions obj1, OrgRulesetConditions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgRulesetConditions o && Equals(o);
        }
    }
}
