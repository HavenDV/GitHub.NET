#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UsersGetAuthenticatedResponse : global::System.IEquatable<UsersGetAuthenticatedResponse>
    {
        /// <summary>
        /// Private User
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.PrivateUser? PrivateUser { get; init; }
#else
        public global::GitHub.PrivateUser? PrivateUser { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PrivateUser))]
#endif
        public bool IsPrivateUser => PrivateUser != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UsersGetAuthenticatedResponse(global::GitHub.PrivateUser value) => new UsersGetAuthenticatedResponse((global::GitHub.PrivateUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.PrivateUser?(UsersGetAuthenticatedResponse @this) => @this.PrivateUser;

        /// <summary>
        /// 
        /// </summary>
        public UsersGetAuthenticatedResponse(global::GitHub.PrivateUser? value)
        {
            PrivateUser = value;
        }

        /// <summary>
        /// Public User
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.PublicUser? PublicUser { get; init; }
#else
        public global::GitHub.PublicUser? PublicUser { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PublicUser))]
#endif
        public bool IsPublicUser => PublicUser != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UsersGetAuthenticatedResponse(global::GitHub.PublicUser value) => new UsersGetAuthenticatedResponse((global::GitHub.PublicUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.PublicUser?(UsersGetAuthenticatedResponse @this) => @this.PublicUser;

        /// <summary>
        /// 
        /// </summary>
        public UsersGetAuthenticatedResponse(global::GitHub.PublicUser? value)
        {
            PublicUser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UsersGetAuthenticatedResponse(
            global::GitHub.PrivateUser? privateUser,
            global::GitHub.PublicUser? publicUser
            )
        {
            PrivateUser = privateUser;
            PublicUser = publicUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PublicUser as object ??
            PrivateUser as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PrivateUser?.ToString() ??
            PublicUser?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrivateUser && !IsPublicUser || !IsPrivateUser && IsPublicUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::GitHub.PrivateUser?, TResult>? privateUser = null,
            global::System.Func<global::GitHub.PublicUser?, TResult>? publicUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrivateUser && privateUser != null)
            {
                return privateUser(PrivateUser!);
            }
            else if (IsPublicUser && publicUser != null)
            {
                return publicUser(PublicUser!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::GitHub.PrivateUser?>? privateUser = null,
            global::System.Action<global::GitHub.PublicUser?>? publicUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrivateUser)
            {
                privateUser?.Invoke(PrivateUser!);
            }
            else if (IsPublicUser)
            {
                publicUser?.Invoke(PublicUser!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PrivateUser,
                typeof(global::GitHub.PrivateUser),
                PublicUser,
                typeof(global::GitHub.PublicUser),
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
        public bool Equals(UsersGetAuthenticatedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.PrivateUser?>.Default.Equals(PrivateUser, other.PrivateUser) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.PublicUser?>.Default.Equals(PublicUser, other.PublicUser) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UsersGetAuthenticatedResponse obj1, UsersGetAuthenticatedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UsersGetAuthenticatedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UsersGetAuthenticatedResponse obj1, UsersGetAuthenticatedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UsersGetAuthenticatedResponse o && Equals(o);
        }
    }
}
