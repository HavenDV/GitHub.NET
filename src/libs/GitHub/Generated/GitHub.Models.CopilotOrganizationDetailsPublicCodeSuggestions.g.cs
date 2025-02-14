
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The organization policy for allowing or blocking suggestions matching public code (duplication detection filter).
    /// </summary>
    public enum CopilotOrganizationDetailsPublicCodeSuggestions
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Unconfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotOrganizationDetailsPublicCodeSuggestionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotOrganizationDetailsPublicCodeSuggestions value)
        {
            return value switch
            {
                CopilotOrganizationDetailsPublicCodeSuggestions.Allow => "allow",
                CopilotOrganizationDetailsPublicCodeSuggestions.Block => "block",
                CopilotOrganizationDetailsPublicCodeSuggestions.Unconfigured => "unconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsPublicCodeSuggestions? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CopilotOrganizationDetailsPublicCodeSuggestions.Allow,
                "block" => CopilotOrganizationDetailsPublicCodeSuggestions.Block,
                "unconfigured" => CopilotOrganizationDetailsPublicCodeSuggestions.Unconfigured,
                _ => null,
            };
        }
    }
}