
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The data type of the issue field<br/>
    /// Example: text
    /// </summary>
    public enum IssueFieldValueDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        SingleSelect,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Date,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssueFieldValueDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueFieldValueDataType value)
        {
            return value switch
            {
                IssueFieldValueDataType.Text => "text",
                IssueFieldValueDataType.SingleSelect => "single_select",
                IssueFieldValueDataType.Number => "number",
                IssueFieldValueDataType.Date => "date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueFieldValueDataType? ToEnum(string value)
        {
            return value switch
            {
                "text" => IssueFieldValueDataType.Text,
                "single_select" => IssueFieldValueDataType.SingleSelect,
                "number" => IssueFieldValueDataType.Number,
                "date" => IssueFieldValueDataType.Date,
                _ => null,
            };
        }
    }
}