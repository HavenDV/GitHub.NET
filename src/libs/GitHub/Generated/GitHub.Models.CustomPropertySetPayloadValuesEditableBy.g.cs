
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Who can edit the values of the property<br/>
    /// Example: org_actors
    /// </summary>
    public enum CustomPropertySetPayloadValuesEditableBy
    {
        /// <summary>
        /// 
        /// </summary>
        OrgActors,
        /// <summary>
        /// 
        /// </summary>
        OrgAndRepoActors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomPropertySetPayloadValuesEditableByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomPropertySetPayloadValuesEditableBy value)
        {
            return value switch
            {
                CustomPropertySetPayloadValuesEditableBy.OrgActors => "org_actors",
                CustomPropertySetPayloadValuesEditableBy.OrgAndRepoActors => "org_and_repo_actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomPropertySetPayloadValuesEditableBy? ToEnum(string value)
        {
            return value switch
            {
                "org_actors" => CustomPropertySetPayloadValuesEditableBy.OrgActors,
                "org_and_repo_actors" => CustomPropertySetPayloadValuesEditableBy.OrgAndRepoActors,
                _ => null,
            };
        }
    }
}