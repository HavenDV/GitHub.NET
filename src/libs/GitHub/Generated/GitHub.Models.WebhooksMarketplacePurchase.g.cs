
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksMarketplacePurchase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhooksMarketplacePurchaseAccount Account { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? NextBillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_free_trial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnFreeTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhooksMarketplacePurchasePlan Plan { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhooksMarketplacePurchase" /> class.
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
        public WebhooksMarketplacePurchase(
            global::GitHub.WebhooksMarketplacePurchaseAccount account,
            string billingCycle,
            string? freeTrialEndsOn,
            string? nextBillingDate,
            bool onFreeTrial,
            global::GitHub.WebhooksMarketplacePurchasePlan plan,
            int unitCount)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.BillingCycle = billingCycle ?? throw new global::System.ArgumentNullException(nameof(billingCycle));
            this.FreeTrialEndsOn = freeTrialEndsOn ?? throw new global::System.ArgumentNullException(nameof(freeTrialEndsOn));
            this.NextBillingDate = nextBillingDate ?? throw new global::System.ArgumentNullException(nameof(nextBillingDate));
            this.OnFreeTrial = onFreeTrial;
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.UnitCount = unitCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksMarketplacePurchase" /> class.
        /// </summary>
        public WebhooksMarketplacePurchase()
        {
        }
    }
}