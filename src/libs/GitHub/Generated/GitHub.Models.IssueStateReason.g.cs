
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The reason for the current state<br/>
    /// Example: not_planned
    /// </summary>
    public enum IssueStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Reopened,
        /// <summary>
        /// 
        /// </summary>
        NotPlanned,
        /// <summary>
        /// 
        /// </summary>
        Duplicate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssueStateReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueStateReason value)
        {
            return value switch
            {
                IssueStateReason.Completed => "completed",
                IssueStateReason.Reopened => "reopened",
                IssueStateReason.NotPlanned => "not_planned",
                IssueStateReason.Duplicate => "duplicate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueStateReason? ToEnum(string value)
        {
            return value switch
            {
                "completed" => IssueStateReason.Completed,
                "reopened" => IssueStateReason.Reopened,
                "not_planned" => IssueStateReason.NotPlanned,
                "duplicate" => IssueStateReason.Duplicate,
                _ => null,
            };
        }
    }
}