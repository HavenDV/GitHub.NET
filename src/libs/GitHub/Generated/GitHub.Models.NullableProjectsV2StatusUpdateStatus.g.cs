
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The current status.
    /// </summary>
    public enum NullableProjectsV2StatusUpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        INACTIVE,
        /// <summary>
        /// 
        /// </summary>
        ONTRACK,
        /// <summary>
        /// 
        /// </summary>
        ATRISK,
        /// <summary>
        /// 
        /// </summary>
        OFFTRACK,
        /// <summary>
        /// 
        /// </summary>
        COMPLETE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableProjectsV2StatusUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableProjectsV2StatusUpdateStatus value)
        {
            return value switch
            {
                NullableProjectsV2StatusUpdateStatus.INACTIVE => "INACTIVE",
                NullableProjectsV2StatusUpdateStatus.ONTRACK => "ON_TRACK",
                NullableProjectsV2StatusUpdateStatus.ATRISK => "AT_RISK",
                NullableProjectsV2StatusUpdateStatus.OFFTRACK => "OFF_TRACK",
                NullableProjectsV2StatusUpdateStatus.COMPLETE => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableProjectsV2StatusUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => NullableProjectsV2StatusUpdateStatus.INACTIVE,
                "ON_TRACK" => NullableProjectsV2StatusUpdateStatus.ONTRACK,
                "AT_RISK" => NullableProjectsV2StatusUpdateStatus.ATRISK,
                "OFF_TRACK" => NullableProjectsV2StatusUpdateStatus.OFFTRACK,
                "COMPLETE" => NullableProjectsV2StatusUpdateStatus.COMPLETE,
                _ => null,
            };
        }
    }
}