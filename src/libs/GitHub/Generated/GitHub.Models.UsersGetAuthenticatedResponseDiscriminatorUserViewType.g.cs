
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsersGetAuthenticatedResponseDiscriminatorUserViewType
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersGetAuthenticatedResponseDiscriminatorUserViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetAuthenticatedResponseDiscriminatorUserViewType value)
        {
            return value switch
            {
                UsersGetAuthenticatedResponseDiscriminatorUserViewType.Public => "public",
                UsersGetAuthenticatedResponseDiscriminatorUserViewType.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetAuthenticatedResponseDiscriminatorUserViewType? ToEnum(string value)
        {
            return value switch
            {
                "public" => UsersGetAuthenticatedResponseDiscriminatorUserViewType.Public,
                "private" => UsersGetAuthenticatedResponseDiscriminatorUserViewType.Private,
                _ => null,
            };
        }
    }
}