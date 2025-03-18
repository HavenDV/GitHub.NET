
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Color for the issue type.
    /// </summary>
    public enum OrganizationUpdateIssueTypeColor
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
    public static class OrganizationUpdateIssueTypeColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationUpdateIssueTypeColor value)
        {
            return value switch
            {
                OrganizationUpdateIssueTypeColor.Gray => "gray",
                OrganizationUpdateIssueTypeColor.Blue => "blue",
                OrganizationUpdateIssueTypeColor.Green => "green",
                OrganizationUpdateIssueTypeColor.Yellow => "yellow",
                OrganizationUpdateIssueTypeColor.Orange => "orange",
                OrganizationUpdateIssueTypeColor.Red => "red",
                OrganizationUpdateIssueTypeColor.Pink => "pink",
                OrganizationUpdateIssueTypeColor.Purple => "purple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationUpdateIssueTypeColor? ToEnum(string value)
        {
            return value switch
            {
                "gray" => OrganizationUpdateIssueTypeColor.Gray,
                "blue" => OrganizationUpdateIssueTypeColor.Blue,
                "green" => OrganizationUpdateIssueTypeColor.Green,
                "yellow" => OrganizationUpdateIssueTypeColor.Yellow,
                "orange" => OrganizationUpdateIssueTypeColor.Orange,
                "red" => OrganizationUpdateIssueTypeColor.Red,
                "pink" => OrganizationUpdateIssueTypeColor.Pink,
                "purple" => OrganizationUpdateIssueTypeColor.Purple,
                _ => null,
            };
        }
    }
}