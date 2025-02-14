
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The organization policy for allowing or disallowing Copilot Chat in the IDE.
    /// </summary>
    public enum CopilotOrganizationDetailsIdeChat
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Unconfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotOrganizationDetailsIdeChatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotOrganizationDetailsIdeChat value)
        {
            return value switch
            {
                CopilotOrganizationDetailsIdeChat.Enabled => "enabled",
                CopilotOrganizationDetailsIdeChat.Disabled => "disabled",
                CopilotOrganizationDetailsIdeChat.Unconfigured => "unconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsIdeChat? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CopilotOrganizationDetailsIdeChat.Enabled,
                "disabled" => CopilotOrganizationDetailsIdeChat.Disabled,
                "unconfigured" => CopilotOrganizationDetailsIdeChat.Unconfigured,
                _ => null,
            };
        }
    }
}