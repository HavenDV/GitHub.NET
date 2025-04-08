
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CampaignsCreateCampaignRequestCodeScanningAlert
    {
        /// <summary>
        /// The repository id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryId { get; set; }

        /// <summary>
        /// The alert numbers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> AlertNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsCreateCampaignRequestCodeScanningAlert" /> class.
        /// </summary>
        /// <param name="repositoryId">
        /// The repository id
        /// </param>
        /// <param name="alertNumbers">
        /// The alert numbers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignsCreateCampaignRequestCodeScanningAlert(
            int repositoryId,
            global::System.Collections.Generic.IList<int> alertNumbers)
        {
            this.RepositoryId = repositoryId;
            this.AlertNumbers = alertNumbers ?? throw new global::System.ArgumentNullException(nameof(alertNumbers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsCreateCampaignRequestCodeScanningAlert" /> class.
        /// </summary>
        public CampaignsCreateCampaignRequestCodeScanningAlert()
        {
        }
    }
}