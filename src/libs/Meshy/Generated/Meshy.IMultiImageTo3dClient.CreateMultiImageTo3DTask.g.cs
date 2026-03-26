#nullable enable

namespace Meshy
{
    public partial interface IMultiImageTo3dClient
    {
        /// <summary>
        /// Create a Multi-Image to 3D task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateMultiImageTo3DTaskAsync(

            global::Meshy.MultiImageTo3DRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Multi-Image to 3D task
        /// </summary>
        /// <param name="imageUrls">
        /// 1-4 images (URLs or base64 data URIs)
        /// </param>
        /// <param name="aiModel">
        /// Default Value: latest
        /// </param>
        /// <param name="topology">
        /// Default Value: triangle
        /// </param>
        /// <param name="targetPolycount">
        /// Default Value: 30000
        /// </param>
        /// <param name="symmetryMode">
        /// Default Value: auto
        /// </param>
        /// <param name="shouldRemesh">
        /// Default Value: false
        /// </param>
        /// <param name="savePreRemeshedModel">
        /// Default Value: false
        /// </param>
        /// <param name="shouldTexture">
        /// Default Value: true
        /// </param>
        /// <param name="enablePbr">
        /// Default Value: false
        /// </param>
        /// <param name="poseMode"></param>
        /// <param name="texturePrompt"></param>
        /// <param name="textureImageUrl"></param>
        /// <param name="moderation">
        /// Default Value: false
        /// </param>
        /// <param name="imageEnhancement">
        /// Default Value: true
        /// </param>
        /// <param name="removeLighting">
        /// Default Value: true
        /// </param>
        /// <param name="targetFormats"></param>
        /// <param name="autoSize">
        /// Default Value: false
        /// </param>
        /// <param name="originAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateMultiImageTo3DTaskAsync(
            global::System.Collections.Generic.IList<string> imageUrls,
            global::Meshy.AiModel? aiModel = default,
            global::Meshy.Topology? topology = default,
            int? targetPolycount = default,
            global::Meshy.SymmetryMode? symmetryMode = default,
            bool? shouldRemesh = default,
            bool? savePreRemeshedModel = default,
            bool? shouldTexture = default,
            bool? enablePbr = default,
            global::Meshy.PoseMode? poseMode = default,
            string? texturePrompt = default,
            string? textureImageUrl = default,
            bool? moderation = default,
            bool? imageEnhancement = default,
            bool? removeLighting = default,
            global::System.Collections.Generic.IList<global::Meshy.TargetFormat3D>? targetFormats = default,
            bool? autoSize = default,
            global::Meshy.OriginAt? originAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}