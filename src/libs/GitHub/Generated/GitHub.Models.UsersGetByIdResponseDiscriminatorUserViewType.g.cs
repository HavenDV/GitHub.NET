
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsersGetByIdResponseDiscriminatorUserViewType
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
    public static class UsersGetByIdResponseDiscriminatorUserViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetByIdResponseDiscriminatorUserViewType value)
        {
            return value switch
            {
                UsersGetByIdResponseDiscriminatorUserViewType.Public => "public",
                UsersGetByIdResponseDiscriminatorUserViewType.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetByIdResponseDiscriminatorUserViewType? ToEnum(string value)
        {
            return value switch
            {
                "public" => UsersGetByIdResponseDiscriminatorUserViewType.Public,
                "private" => UsersGetByIdResponseDiscriminatorUserViewType.Private,
                _ => null,
            };
        }
    }
}