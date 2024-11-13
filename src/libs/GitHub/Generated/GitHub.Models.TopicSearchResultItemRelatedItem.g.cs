
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSearchResultItemRelatedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_relation")]
        public global::GitHub.TopicSearchResultItemRelatedItemTopicRelation? TopicRelation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemRelatedItem" /> class.
        /// </summary>
        /// <param name="topicRelation"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TopicSearchResultItemRelatedItem(
            global::GitHub.TopicSearchResultItemRelatedItemTopicRelation? topicRelation)
        {
            this.TopicRelation = topicRelation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemRelatedItem" /> class.
        /// </summary>
        public TopicSearchResultItemRelatedItem()
        {
        }
    }
}