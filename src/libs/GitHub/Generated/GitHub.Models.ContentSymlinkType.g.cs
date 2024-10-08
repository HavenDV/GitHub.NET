
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentSymlinkType
    {
        /// <summary>
        /// 
        /// </summary>
        Symlink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentSymlinkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentSymlinkType value)
        {
            return value switch
            {
                ContentSymlinkType.Symlink => "symlink",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentSymlinkType? ToEnum(string value)
        {
            return value switch
            {
                "symlink" => ContentSymlinkType.Symlink,
                _ => null,
            };
        }
    }
}