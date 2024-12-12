
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of the value for the property<br/>
    /// Example: single_select
    /// </summary>
    public enum CustomPropertySetPayloadValueType
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
    public static class CustomPropertySetPayloadValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomPropertySetPayloadValueType value)
        {
            return value switch
            {
                CustomPropertySetPayloadValueType.String => "string",
                CustomPropertySetPayloadValueType.SingleSelect => "single_select",
                CustomPropertySetPayloadValueType.MultiSelect => "multi_select",
                CustomPropertySetPayloadValueType.TrueFalse => "true_false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomPropertySetPayloadValueType? ToEnum(string value)
        {
            return value switch
            {
                "string" => CustomPropertySetPayloadValueType.String,
                "single_select" => CustomPropertySetPayloadValueType.SingleSelect,
                "multi_select" => CustomPropertySetPayloadValueType.MultiSelect,
                "true_false" => CustomPropertySetPayloadValueType.TrueFalse,
                _ => null,
            };
        }
    }
}