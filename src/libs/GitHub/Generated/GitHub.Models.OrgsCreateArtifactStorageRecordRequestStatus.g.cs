
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The status of the artifact (e.g., active, inactive).<br/>
    /// Default Value: active<br/>
    /// Example: active
    /// </summary>
    public enum OrgsCreateArtifactStorageRecordRequestStatus
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
    public static class OrgsCreateArtifactStorageRecordRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsCreateArtifactStorageRecordRequestStatus value)
        {
            return value switch
            {
                OrgsCreateArtifactStorageRecordRequestStatus.Active => "active",
                OrgsCreateArtifactStorageRecordRequestStatus.Eol => "eol",
                OrgsCreateArtifactStorageRecordRequestStatus.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsCreateArtifactStorageRecordRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => OrgsCreateArtifactStorageRecordRequestStatus.Active,
                "eol" => OrgsCreateArtifactStorageRecordRequestStatus.Eol,
                "deleted" => OrgsCreateArtifactStorageRecordRequestStatus.Deleted,
                _ => null,
            };
        }
    }
}