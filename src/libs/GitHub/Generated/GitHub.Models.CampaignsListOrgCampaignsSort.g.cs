
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum CampaignsListOrgCampaignsSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
        /// <summary>
        /// 
        /// </summary>
        EndsAt,
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignsListOrgCampaignsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignsListOrgCampaignsSort value)
        {
            return value switch
            {
                CampaignsListOrgCampaignsSort.Created => "created",
                CampaignsListOrgCampaignsSort.Updated => "updated",
                CampaignsListOrgCampaignsSort.EndsAt => "ends_at",
                CampaignsListOrgCampaignsSort.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignsListOrgCampaignsSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => CampaignsListOrgCampaignsSort.Created,
                "updated" => CampaignsListOrgCampaignsSort.Updated,
                "ends_at" => CampaignsListOrgCampaignsSort.EndsAt,
                "published" => CampaignsListOrgCampaignsSort.Published,
                _ => null,
            };
        }
    }
}