
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
            typeof(global::Meshy.JsonConverters.TaskStatusJsonConverter),

            typeof(global::Meshy.JsonConverters.TaskStatusNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.AiModelJsonConverter),

            typeof(global::Meshy.JsonConverters.AiModelNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ModelTypeJsonConverter),

            typeof(global::Meshy.JsonConverters.ModelTypeNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.TopologyJsonConverter),

            typeof(global::Meshy.JsonConverters.TopologyNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.SymmetryModeJsonConverter),

            typeof(global::Meshy.JsonConverters.SymmetryModeNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.PoseModeJsonConverter),

            typeof(global::Meshy.JsonConverters.PoseModeNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.TargetFormat3DJsonConverter),

            typeof(global::Meshy.JsonConverters.TargetFormat3DNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.TargetFormatRemeshJsonConverter),

            typeof(global::Meshy.JsonConverters.TargetFormatRemeshNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.OriginAtJsonConverter),

            typeof(global::Meshy.JsonConverters.OriginAtNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ImageAiModelJsonConverter),

            typeof(global::Meshy.JsonConverters.ImageAiModelNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.AspectRatioJsonConverter),

            typeof(global::Meshy.JsonConverters.AspectRatioNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.TextTo3DPreviewRequestModeJsonConverter),

            typeof(global::Meshy.JsonConverters.TextTo3DPreviewRequestModeNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.TextTo3DPreviewRequestArtStyleJsonConverter),

            typeof(global::Meshy.JsonConverters.TextTo3DPreviewRequestArtStyleNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.TextTo3DRefineRequestModeJsonConverter),

            typeof(global::Meshy.JsonConverters.TextTo3DRefineRequestModeNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.TextToImageRequestPoseModeJsonConverter),

            typeof(global::Meshy.JsonConverters.TextToImageRequestPoseModeNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.RemeshTaskStatusJsonConverter),

            typeof(global::Meshy.JsonConverters.RemeshTaskStatusNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.AnimationPostProcessOperationTypeJsonConverter),

            typeof(global::Meshy.JsonConverters.AnimationPostProcessOperationTypeNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.CreateTextTo3DTaskRequestDiscriminatorModeJsonConverter),

            typeof(global::Meshy.JsonConverters.CreateTextTo3DTaskRequestDiscriminatorModeNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ListTextTo3DTasksSortByJsonConverter),

            typeof(global::Meshy.JsonConverters.ListTextTo3DTasksSortByNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ListImageTo3DTasksSortByJsonConverter),

            typeof(global::Meshy.JsonConverters.ListImageTo3DTasksSortByNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ListMultiImageTo3DTasksSortByJsonConverter),

            typeof(global::Meshy.JsonConverters.ListMultiImageTo3DTasksSortByNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ListTextToImageTasksSortByJsonConverter),

            typeof(global::Meshy.JsonConverters.ListTextToImageTasksSortByNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ListImageToImageTasksSortByJsonConverter),

            typeof(global::Meshy.JsonConverters.ListImageToImageTasksSortByNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ListRemeshTasksSortByJsonConverter),

            typeof(global::Meshy.JsonConverters.ListRemeshTasksSortByNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.ListRetextureTasksSortByJsonConverter),

            typeof(global::Meshy.JsonConverters.ListRetextureTasksSortByNullableJsonConverter),

            typeof(global::Meshy.JsonConverters.CreateTextTo3DTaskRequestJsonConverter),

            typeof(global::Meshy.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.CreateTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TaskError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextureUrlSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ModelUrls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ModelUrlsRemesh))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ModelUrlsImageTo3D))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AiModel), TypeInfoPropertyName = "AiModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ModelType), TypeInfoPropertyName = "ModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.Topology), TypeInfoPropertyName = "Topology2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.SymmetryMode), TypeInfoPropertyName = "SymmetryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.PoseMode), TypeInfoPropertyName = "PoseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TargetFormat3D), TypeInfoPropertyName = "TargetFormat3D2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TargetFormatRemesh), TypeInfoPropertyName = "TargetFormatRemesh2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.OriginAt), TypeInfoPropertyName = "OriginAt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ImageAiModel), TypeInfoPropertyName = "ImageAiModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextTo3DPreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextTo3DPreviewRequestMode), TypeInfoPropertyName = "TextTo3DPreviewRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextTo3DPreviewRequestArtStyle), TypeInfoPropertyName = "TextTo3DPreviewRequestArtStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.TargetFormat3D>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextTo3DRefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextTo3DRefineRequestMode), TypeInfoPropertyName = "TextTo3DRefineRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextTo3DTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.TextureUrlSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ImageTo3DRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ImageTo3DTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.MultiImageTo3DRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextToImageRequestPoseMode), TypeInfoPropertyName = "TextToImageRequestPoseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.TextToImageTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ImageToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ImageToImageTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.RemeshRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.TargetFormatRemesh>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.RemeshTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.RemeshTaskStatus), TypeInfoPropertyName = "RemeshTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.RetextureRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.RetextureTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.RiggingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.BasicAnimations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.RiggingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.RiggingTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AnimationPostProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AnimationPostProcessOperationType), TypeInfoPropertyName = "AnimationPostProcessOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AnimationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AnimationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.AnimationTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.BalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.CreateTextTo3DTaskRequest), TypeInfoPropertyName = "CreateTextTo3DTaskRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.CreateTextTo3DTaskRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.CreateTextTo3DTaskRequestDiscriminatorMode), TypeInfoPropertyName = "CreateTextTo3DTaskRequestDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListTextTo3DTasksSortBy), TypeInfoPropertyName = "ListTextTo3DTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListImageTo3DTasksSortBy), TypeInfoPropertyName = "ListImageTo3DTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListMultiImageTo3DTasksSortBy), TypeInfoPropertyName = "ListMultiImageTo3DTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListTextToImageTasksSortBy), TypeInfoPropertyName = "ListTextToImageTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListImageToImageTasksSortBy), TypeInfoPropertyName = "ListImageToImageTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListRemeshTasksSortBy), TypeInfoPropertyName = "ListRemeshTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshy.ListRetextureTasksSortBy), TypeInfoPropertyName = "ListRetextureTasksSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.TextTo3DTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.ImageTo3DTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.TextToImageTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.ImageToImageTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.RemeshTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshy.RetextureTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.TargetFormat3D>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.TextureUrlSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.TargetFormatRemesh>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.TextTo3DTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.ImageTo3DTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.TextToImageTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.ImageToImageTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.RemeshTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshy.RetextureTask>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}