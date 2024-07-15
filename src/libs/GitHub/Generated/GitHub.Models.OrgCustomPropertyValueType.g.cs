
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of the value for the property<br/>
    /// Example: single_select
    /// </summary>
    public enum OrgCustomPropertyValueType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        SingleSelect,
        /// <summary>
        /// 
        /// </summary>
        MultiSelect,
        /// <summary>
        /// 
        /// </summary>
        TrueFalse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgCustomPropertyValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgCustomPropertyValueType value)
        {
            return value switch
            {
                OrgCustomPropertyValueType.String => "string",
                OrgCustomPropertyValueType.SingleSelect => "single_select",
                OrgCustomPropertyValueType.MultiSelect => "multi_select",
                OrgCustomPropertyValueType.TrueFalse => "true_false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgCustomPropertyValueType? ToEnum(string value)
        {
            return value switch
            {
                "string" => OrgCustomPropertyValueType.String,
                "single_select" => OrgCustomPropertyValueType.SingleSelect,
                "multi_select" => OrgCustomPropertyValueType.MultiSelect,
                "true_false" => OrgCustomPropertyValueType.TrueFalse,
                _ => null,
            };
        }
    }
}