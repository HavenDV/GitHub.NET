
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Color for the issue type.
    /// </summary>
    public enum OrganizationCreateIssueTypeColor
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
    public static class OrganizationCreateIssueTypeColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationCreateIssueTypeColor value)
        {
            return value switch
            {
                OrganizationCreateIssueTypeColor.Gray => "gray",
                OrganizationCreateIssueTypeColor.Blue => "blue",
                OrganizationCreateIssueTypeColor.Green => "green",
                OrganizationCreateIssueTypeColor.Yellow => "yellow",
                OrganizationCreateIssueTypeColor.Orange => "orange",
                OrganizationCreateIssueTypeColor.Red => "red",
                OrganizationCreateIssueTypeColor.Pink => "pink",
                OrganizationCreateIssueTypeColor.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationCreateIssueTypeColor? ToEnum(string value)
        {
            return value switch
            {
                "gray" => OrganizationCreateIssueTypeColor.Gray,
                "blue" => OrganizationCreateIssueTypeColor.Blue,
                "green" => OrganizationCreateIssueTypeColor.Green,
                "yellow" => OrganizationCreateIssueTypeColor.Yellow,
                "orange" => OrganizationCreateIssueTypeColor.Orange,
                "red" => OrganizationCreateIssueTypeColor.Red,
                "pink" => OrganizationCreateIssueTypeColor.Pink,
                "purple" => OrganizationCreateIssueTypeColor.Purple,
                _ => null,
            };
        }
    }
}