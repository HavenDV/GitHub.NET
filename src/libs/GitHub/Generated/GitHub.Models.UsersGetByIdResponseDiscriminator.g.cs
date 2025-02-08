
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersGetByIdResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_view_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.UsersGetByIdResponseDiscriminatorUserViewTypeJsonConverter))]
        public global::GitHub.UsersGetByIdResponseDiscriminatorUserViewType? UserViewType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersGetByIdResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="userViewType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersGetByIdResponseDiscriminator(
            global::GitHub.UsersGetByIdResponseDiscriminatorUserViewType? userViewType)
        {
            this.UserViewType = userViewType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersGetByIdResponseDiscriminator" /> class.
        /// </summary>
        public UsersGetByIdResponseDiscriminator()
        {
        }
    }
}