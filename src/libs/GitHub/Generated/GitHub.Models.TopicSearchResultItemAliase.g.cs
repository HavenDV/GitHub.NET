
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSearchResultItemAliase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_relation")]
        public global::GitHub.TopicSearchResultItemAliaseTopicRelation? TopicRelation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemAliase" /> class.
        /// </summary>
        /// <param name="topicRelation"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TopicSearchResultItemAliase(
            global::GitHub.TopicSearchResultItemAliaseTopicRelation? topicRelation)
        {
            this.TopicRelation = topicRelation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemAliase" /> class.
        /// </summary>
        public TopicSearchResultItemAliase()
        {
        }
    }
}