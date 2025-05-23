
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The Copilot plan of the organization, or the parent enterprise, when applicable.
    /// </summary>
    public enum CopilotOrganizationDetailsPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        Business,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotOrganizationDetailsPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotOrganizationDetailsPlanType value)
        {
            return value switch
            {
                CopilotOrganizationDetailsPlanType.Business => "business",
                CopilotOrganizationDetailsPlanType.Enterprise => "enterprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsPlanType? ToEnum(string value)
        {
            return value switch
            {
                "business" => CopilotOrganizationDetailsPlanType.Business,
                "enterprise" => CopilotOrganizationDetailsPlanType.Enterprise,
                _ => null,
            };
        }
    }
}