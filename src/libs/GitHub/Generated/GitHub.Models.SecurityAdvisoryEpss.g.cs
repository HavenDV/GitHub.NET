
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The EPSS scores as calculated by the [Exploit Prediction Scoring System](https://www.first.org/epss).<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class SecurityAdvisoryEpss
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        public double? Percentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public double? Percentile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAdvisoryEpss" /> class.
        /// </summary>
        /// <param name="percentage"></param>
        /// <param name="percentile"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SecurityAdvisoryEpss(
            double? percentage,
            double? percentile)
        {
            this.Percentage = percentage;
            this.Percentile = percentile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAdvisoryEpss" /> class.
        /// </summary>
        public SecurityAdvisoryEpss()
        {
        }
    }
}