
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum CampaignsListOrgCampaignsDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignsListOrgCampaignsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignsListOrgCampaignsDirection value)
        {
            return value switch
            {
                CampaignsListOrgCampaignsDirection.Asc => "asc",
                CampaignsListOrgCampaignsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignsListOrgCampaignsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => CampaignsListOrgCampaignsDirection.Asc,
                "desc" => CampaignsListOrgCampaignsDirection.Desc,
                _ => null,
            };
        }
    }
}