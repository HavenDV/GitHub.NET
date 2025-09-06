
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The status of the artifact (e.g., active, inactive).<br/>
    /// Default Value: active<br/>
    /// Example: active
    /// </summary>
    public enum OrgsCreateArtifactStorageRecordsRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Eol,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsCreateArtifactStorageRecordsRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsCreateArtifactStorageRecordsRequestStatus value)
        {
            return value switch
            {
                OrgsCreateArtifactStorageRecordsRequestStatus.Active => "active",
                OrgsCreateArtifactStorageRecordsRequestStatus.Eol => "eol",
                OrgsCreateArtifactStorageRecordsRequestStatus.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsCreateArtifactStorageRecordsRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => OrgsCreateArtifactStorageRecordsRequestStatus.Active,
                "eol" => OrgsCreateArtifactStorageRecordsRequestStatus.Eol,
                "deleted" => OrgsCreateArtifactStorageRecordsRequestStatus.Deleted,
                _ => null,
            };
        }
    }
}