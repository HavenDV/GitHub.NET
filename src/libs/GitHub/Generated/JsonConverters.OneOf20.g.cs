#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class OneOfJsonConverter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : global::System.Text.Json.Serialization.JsonConverter<global::System.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>
    {
        /// <inheritdoc />
        public override global::System.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            T1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T4? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T5? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T6? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T7? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T8? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T9? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T10? value10 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                value10 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T11? value11 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                value11 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T12? value12 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                value12 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T13? value13 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                value13 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T14? value14 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T14).Name}");
                value14 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T15? value15 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T15).Name}");
                value15 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T16? value16 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T16).Name}");
                value16 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T17? value17 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T17).Name}");
                value17 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T18? value18 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T18).Name}");
                value18 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T19? value19 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T19).Name}");
                value19 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            T20? value20 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T20).Name}");
                value20 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::System.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(
                value1,

                value2,

                value3,

                value4,

                value5,

                value6,

                value7,

                value8,

                value9,

                value10,

                value11,

                value12,

                value13,

                value14,

                value15,

                value16,

                value17,

                value18,

                value19,

                value20
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(T1).Name}, {typeof(T2).Name}, {typeof(T3).Name}, {typeof(T4).Name}, {typeof(T5).Name}, {typeof(T6).Name}, {typeof(T7).Name}, {typeof(T8).Name}, {typeof(T9).Name}, {typeof(T10).Name}, {typeof(T11).Name}, {typeof(T12).Name}, {typeof(T13).Name}, {typeof(T14).Name}, {typeof(T15).Name}, {typeof(T16).Name}, {typeof(T17).Name}, {typeof(T18).Name}, {typeof(T19).Name}, {typeof(T20).Name}>");
            }

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value10 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value11 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value12 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value13 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value14 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T14).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value15 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T15).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value16 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T16).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value17 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T17).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value18 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T18).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value19 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T19).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value20 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T20).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::System.OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(T1).Name}, {typeof(T2).Name}, {typeof(T3).Name}, {typeof(T4).Name}, {typeof(T5).Name}, {typeof(T6).Name}, {typeof(T7).Name}, {typeof(T8).Name}, {typeof(T9).Name}, {typeof(T10).Name}, {typeof(T11).Name}, {typeof(T12).Name}, {typeof(T13).Name}, {typeof(T14).Name}, {typeof(T15).Name}, {typeof(T16).Name}, {typeof(T17).Name}, {typeof(T18).Name}, {typeof(T19).Name}, {typeof(T20).Name}> object.");
            }

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }

            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }

            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }

            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }

            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }

            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }

            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }

            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }

            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }

            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }

            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeInfo);
            }

            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeInfo);
            }

            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeInfo);
            }

            else if (value.IsValue14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeInfo);
            }

            else if (value.IsValue15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, typeInfo);
            }

            else if (value.IsValue16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, typeInfo);
            }

            else if (value.IsValue17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value17, typeInfo);
            }

            else if (value.IsValue18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value18, typeInfo);
            }

            else if (value.IsValue19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value19, typeInfo);
            }

            else if (value.IsValue20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(T20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<T20?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(T20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value20, typeInfo);
            }
        }
    }
}