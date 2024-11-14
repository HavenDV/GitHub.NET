
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The source type of the property<br/>
    /// Example: organization
    /// </summary>
    public enum CustomPropertySourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomPropertySourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomPropertySourceType value)
        {
            return value switch
            {
                CustomPropertySourceType.Organization => "organization",
                CustomPropertySourceType.Enterprise => "enterprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomPropertySourceType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => CustomPropertySourceType.Organization,
                "enterprise" => CustomPropertySourceType.Enterprise,
                _ => null,
            };
        }
    }
}