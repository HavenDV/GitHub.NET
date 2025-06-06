#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public class UsersGetByIdResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.UsersGetByIdResponse>
    {
        /// <inheritdoc />
        public override global::GitHub.UsersGetByIdResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::GitHub.PrivateUser? privateUser = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.PrivateUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.PrivateUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.PrivateUser).Name}");
                privateUser = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.PublicUser? publicUser = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.PublicUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.PublicUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.PublicUser).Name}");
                publicUser = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::GitHub.UsersGetByIdResponse(
                privateUser,
                publicUser
                );

            if (privateUser != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.PrivateUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.PrivateUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.PrivateUser).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (publicUser != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.PublicUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.PublicUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.PublicUser).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.UsersGetByIdResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPrivateUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.PrivateUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.PrivateUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.PrivateUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateUser, typeInfo);
            }
            else if (value.IsPublicUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.PublicUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.PublicUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.PublicUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PublicUser, typeInfo);
            }
        }
    }
}