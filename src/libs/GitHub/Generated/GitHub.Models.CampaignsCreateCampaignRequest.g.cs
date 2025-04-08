
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CampaignsCreateCampaignRequest
    {
        /// <summary>
        /// The name of the campaign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description for the campaign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

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
        /// The end date and time of the campaign. The date must be in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ends_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndsAt { get; set; }

        /// <summary>
        /// The contact link of the campaign. Must be a URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_link")]
        public string? ContactLink { get; set; }

        /// <summary>
        /// The code scanning alerts to include in this campaign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.CampaignsCreateCampaignRequestCodeScanningAlert> CodeScanningAlerts { get; set; }

        /// <summary>
        /// If true, will automatically generate issues for the campaign. The default is false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_issues")]
        public bool? GenerateIssues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsCreateCampaignRequest" /> class.
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
        /// The end date and time of the campaign. The date must be in the future.
        /// </param>
        /// <param name="contactLink">
        /// The contact link of the campaign. Must be a URI.
        /// </param>
        /// <param name="codeScanningAlerts">
        /// The code scanning alerts to include in this campaign
        /// </param>
        /// <param name="generateIssues">
        /// If true, will automatically generate issues for the campaign. The default is false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignsCreateCampaignRequest(
            string name,
            string description,
            global::System.DateTime endsAt,
            global::System.Collections.Generic.IList<global::GitHub.CampaignsCreateCampaignRequestCodeScanningAlert> codeScanningAlerts,
            global::System.Collections.Generic.IList<string>? managers,
            global::System.Collections.Generic.IList<string>? teamManagers,
            string? contactLink,
            bool? generateIssues)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.EndsAt = endsAt;
            this.CodeScanningAlerts = codeScanningAlerts ?? throw new global::System.ArgumentNullException(nameof(codeScanningAlerts));
            this.Managers = managers;
            this.TeamManagers = teamManagers;
            this.ContactLink = contactLink;
            this.GenerateIssues = generateIssues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsCreateCampaignRequest" /> class.
        /// </summary>
        public CampaignsCreateCampaignRequest()
        {
        }
    }
}