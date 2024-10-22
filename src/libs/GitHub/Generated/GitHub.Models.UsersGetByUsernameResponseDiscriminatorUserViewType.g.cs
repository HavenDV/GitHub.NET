
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsersGetByUsernameResponseDiscriminatorUserViewType
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
    public static class UsersGetByUsernameResponseDiscriminatorUserViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetByUsernameResponseDiscriminatorUserViewType value)
        {
            return value switch
            {
                UsersGetByUsernameResponseDiscriminatorUserViewType.Public => "public",
                UsersGetByUsernameResponseDiscriminatorUserViewType.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetByUsernameResponseDiscriminatorUserViewType? ToEnum(string value)
        {
            return value switch
            {
                "public" => UsersGetByUsernameResponseDiscriminatorUserViewType.Public,
                "private" => UsersGetByUsernameResponseDiscriminatorUserViewType.Private,
                _ => null,
            };
        }
    }
}