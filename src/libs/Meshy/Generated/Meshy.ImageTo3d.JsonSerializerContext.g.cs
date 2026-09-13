
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Meshy
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.CreateTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TaskError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextureUrlSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ModelUrlsImageTo3D))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AiModel), TypeInfoPropertyName = "AiModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ModelType), TypeInfoPropertyName = "ModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.Topology), TypeInfoPropertyName = "Topology2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.SymmetryMode), TypeInfoPropertyName = "SymmetryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.PoseMode), TypeInfoPropertyName = "PoseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TargetFormat3D), TypeInfoPropertyName = "TargetFormat3D2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.OriginAt), TypeInfoPropertyName = "OriginAt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.TargetFormat3D>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.TextureUrlSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ImageTo3DRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ImageTo3DTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListImageTo3DTasksSortBy), TypeInfoPropertyName = "ListImageTo3DTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.ImageTo3DTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TaskStatus?), TypeInfoPropertyName = "NullableTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AiModel?), TypeInfoPropertyName = "NullableAiModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ModelType?), TypeInfoPropertyName = "NullableModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.Topology?), TypeInfoPropertyName = "NullableTopology2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.SymmetryMode?), TypeInfoPropertyName = "NullableSymmetryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.PoseMode?), TypeInfoPropertyName = "NullablePoseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TargetFormat3D?), TypeInfoPropertyName = "NullableTargetFormat3D2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.OriginAt?), TypeInfoPropertyName = "NullableOriginAt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListImageTo3DTasksSortBy?), TypeInfoPropertyName = "NullableListImageTo3DTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.TargetFormat3D>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.TextureUrlSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.ImageTo3DTask>))]
    internal sealed partial class ImageTo3dSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageTo3dSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImageTo3dSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImageTo3dSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Meshy.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Meshy.TaskStatus)

                    || typeToConvert == typeof(global::Meshy.TaskStatus?)

                    || typeToConvert == typeof(global::Meshy.AiModel)

                    || typeToConvert == typeof(global::Meshy.AiModel?)

                    || typeToConvert == typeof(global::Meshy.ModelType)

                    || typeToConvert == typeof(global::Meshy.ModelType?)

                    || typeToConvert == typeof(global::Meshy.Topology)

                    || typeToConvert == typeof(global::Meshy.Topology?)

                    || typeToConvert == typeof(global::Meshy.SymmetryMode)

                    || typeToConvert == typeof(global::Meshy.SymmetryMode?)

                    || typeToConvert == typeof(global::Meshy.PoseMode)

                    || typeToConvert == typeof(global::Meshy.PoseMode?)

                    || typeToConvert == typeof(global::Meshy.TargetFormat3D)

                    || typeToConvert == typeof(global::Meshy.TargetFormat3D?)

                    || typeToConvert == typeof(global::Meshy.OriginAt)

                    || typeToConvert == typeof(global::Meshy.OriginAt?)

                    || typeToConvert == typeof(global::Meshy.ListImageTo3DTasksSortBy)

                    || typeToConvert == typeof(global::Meshy.ListImageTo3DTasksSortBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Meshy.TaskStatus))
                {
                    return new global::Meshy.JsonConverters.TaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.TaskStatus?))
                {
                    return new global::Meshy.JsonConverters.TaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.AiModel))
                {
                    return new global::Meshy.JsonConverters.AiModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.AiModel?))
                {
                    return new global::Meshy.JsonConverters.AiModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.ModelType))
                {
                    return new global::Meshy.JsonConverters.ModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.ModelType?))
                {
                    return new global::Meshy.JsonConverters.ModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.Topology))
                {
                    return new global::Meshy.JsonConverters.TopologyJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.Topology?))
                {
                    return new global::Meshy.JsonConverters.TopologyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.SymmetryMode))
                {
                    return new global::Meshy.JsonConverters.SymmetryModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.SymmetryMode?))
                {
                    return new global::Meshy.JsonConverters.SymmetryModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.PoseMode))
                {
                    return new global::Meshy.JsonConverters.PoseModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.PoseMode?))
                {
                    return new global::Meshy.JsonConverters.PoseModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.TargetFormat3D))
                {
                    return new global::Meshy.JsonConverters.TargetFormat3DJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.TargetFormat3D?))
                {
                    return new global::Meshy.JsonConverters.TargetFormat3DNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.OriginAt))
                {
                    return new global::Meshy.JsonConverters.OriginAtJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.OriginAt?))
                {
                    return new global::Meshy.JsonConverters.OriginAtNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.ListImageTo3DTasksSortBy))
                {
                    return new global::Meshy.JsonConverters.ListImageTo3DTasksSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Meshy.ListImageTo3DTasksSortBy?))
                {
                    return new global::Meshy.JsonConverters.ListImageTo3DTasksSortByNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ImageTo3dSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}