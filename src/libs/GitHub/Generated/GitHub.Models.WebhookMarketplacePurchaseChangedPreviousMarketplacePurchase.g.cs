
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchaseAccount Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_cycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_trial_ends_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? FreeTrialEndsOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_billing_date")]
        public string? NextBillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_free_trial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool? OnFreeTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnitCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="billingCycle"></param>
        /// <param name="freeTrialEndsOn"></param>
        /// <param name="nextBillingDate"></param>
        /// <param name="onFreeTrial"></param>
        /// <param name="plan"></param>
        /// <param name="unitCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase(
            global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchaseAccount account,
            string billingCycle,
            string? freeTrialEndsOn,
            bool? onFreeTrial,
            global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan plan,
            int unitCount,
            string? nextBillingDate)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.BillingCycle = billingCycle ?? throw new global::System.ArgumentNullException(nameof(billingCycle));
            this.FreeTrialEndsOn = freeTrialEndsOn ?? throw new global::System.ArgumentNullException(nameof(freeTrialEndsOn));
            this.OnFreeTrial = onFreeTrial;
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.UnitCount = unitCount;
            this.NextBillingDate = nextBillingDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase" /> class.
        /// </summary>
        public WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase()
        {
        }
    }
}