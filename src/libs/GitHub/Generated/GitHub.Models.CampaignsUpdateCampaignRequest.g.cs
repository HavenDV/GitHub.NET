
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CampaignsUpdateCampaignRequest
    {
        /// <summary>
        /// The name of the campaign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description for the campaign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The logins of the users to set as the campaign managers. At this time, only a single manager can be supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managers")]
        public global::System.Collections.Generic.IList<string>? Managers { get; set; }

        /// <summary>
        /// The slugs of the teams to set as the campaign managers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_managers")]
        public global::System.Collections.Generic.IList<string>? TeamManagers { get; set; }

        /// <summary>
        /// The end date and time of the campaign, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ends_at")]
        public global::System.DateTime? EndsAt { get; set; }

        /// <summary>
        /// The contact link of the campaign. Must be a URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_link")]
        public string? ContactLink { get; set; }

        /// <summary>
        /// Indicates whether a campaign is open or closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CampaignStateJsonConverter))]
        public global::GitHub.CampaignState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsUpdateCampaignRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the campaign
        /// </param>
        /// <param name="description">
        /// A description for the campaign
        /// </param>
        /// <param name="managers">
        /// The logins of the users to set as the campaign managers. At this time, only a single manager can be supplied.
        /// </param>
        /// <param name="teamManagers">
        /// The slugs of the teams to set as the campaign managers.
        /// </param>
        /// <param name="endsAt">
        /// The end date and time of the campaign, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="contactLink">
        /// The contact link of the campaign. Must be a URI.
        /// </param>
        /// <param name="state">
        /// Indicates whether a campaign is open or closed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignsUpdateCampaignRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? managers,
            global::System.Collections.Generic.IList<string>? teamManagers,
            global::System.DateTime? endsAt,
            string? contactLink,
            global::GitHub.CampaignState? state)
        {
            this.Name = name;
            this.Description = description;
            this.Managers = managers;
            this.TeamManagers = teamManagers;
            this.EndsAt = endsAt;
            this.ContactLink = contactLink;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsUpdateCampaignRequest" /> class.
        /// </summary>
        public CampaignsUpdateCampaignRequest()
        {
        }
    }
}