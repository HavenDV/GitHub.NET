#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UsersGetByIdResponse : global::System.IEquatable<UsersGetByIdResponse>
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
        public static implicit operator UsersGetByIdResponse(global::GitHub.PrivateUser value) => new UsersGetByIdResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.PrivateUser?(UsersGetByIdResponse @this) => @this.PrivateUser;

        /// <summary>
        /// 
        /// </summary>
        public UsersGetByIdResponse(global::GitHub.PrivateUser? value)
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
        public static implicit operator UsersGetByIdResponse(global::GitHub.PublicUser value) => new UsersGetByIdResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.PublicUser?(UsersGetByIdResponse @this) => @this.PublicUser;

        /// <summary>
        /// 
        /// </summary>
        public UsersGetByIdResponse(global::GitHub.PublicUser? value)
        {
            PublicUser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UsersGetByIdResponse(
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
        public bool Equals(UsersGetByIdResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::GitHub.PrivateUser?>.Default.Equals(PrivateUser, other.PrivateUser) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.PublicUser?>.Default.Equals(PublicUser, other.PublicUser) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UsersGetByIdResponse obj1, UsersGetByIdResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UsersGetByIdResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UsersGetByIdResponse obj1, UsersGetByIdResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UsersGetByIdResponse o && Equals(o);
        }
    }
}
