
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The color of the issue type.
    /// </summary>
    public enum IssueTypeColor
    {
        /// <summary>
        /// 
        /// </summary>
        Gray,
        /// <summary>
        /// 
        /// </summary>
        Blue,
        /// <summary>
        /// 
        /// </summary>
        Green,
        /// <summary>
        /// 
        /// </summary>
        Yellow,
        /// <summary>
        /// 
        /// </summary>
        Orange,
        /// <summary>
        /// 
        /// </summary>
        Red,
        /// <summary>
        /// 
        /// </summary>
        Pink,
        /// <summary>
        /// 
        /// </summary>
        Purple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssueTypeColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueTypeColor value)
        {
            return value switch
            {
                IssueTypeColor.Gray => "gray",
                IssueTypeColor.Blue => "blue",
                IssueTypeColor.Green => "green",
                IssueTypeColor.Yellow => "yellow",
                IssueTypeColor.Orange => "orange",
                IssueTypeColor.Red => "red",
                IssueTypeColor.Pink => "pink",
                IssueTypeColor.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueTypeColor? ToEnum(string value)
        {
            return value switch
            {
                "gray" => IssueTypeColor.Gray,
                "blue" => IssueTypeColor.Blue,
                "green" => IssueTypeColor.Green,
                "yellow" => IssueTypeColor.Yellow,
                "orange" => IssueTypeColor.Orange,
                "red" => IssueTypeColor.Red,
                "pink" => IssueTypeColor.Pink,
                "purple" => IssueTypeColor.Purple,
                _ => null,
            };
        }
    }
}