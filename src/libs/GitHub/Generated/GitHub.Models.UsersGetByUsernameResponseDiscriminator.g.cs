
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersGetByUsernameResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_view_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.UsersGetByUsernameResponseDiscriminatorUserViewTypeJsonConverter))]
        public global::GitHub.UsersGetByUsernameResponseDiscriminatorUserViewType? UserViewType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersGetByUsernameResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="userViewType"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsersGetByUsernameResponseDiscriminator(
            global::GitHub.UsersGetByUsernameResponseDiscriminatorUserViewType? userViewType)
        {
            this.UserViewType = userViewType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersGetByUsernameResponseDiscriminator" /> class.
        /// </summary>
        public UsersGetByUsernameResponseDiscriminator()
        {
        }
    }
}