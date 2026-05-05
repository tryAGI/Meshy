#nullable enable

namespace Meshy
{
    public partial interface ITextToImageClient
    {
        /// <summary>
        /// Create a Text to Image task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateTextToImageTaskAsync(

            global::Meshy.TextToImageRequest request,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Text to Image task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.AutoSDKHttpResponse<global::Meshy.CreateTaskResponse>> CreateTextToImageTaskAsResponseAsync(

            global::Meshy.TextToImageRequest request,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Text to Image task
        /// </summary>
        /// <param name="aiModel"></param>
        /// <param name="prompt">
        /// Text description for image generation
        /// </param>
        /// <param name="generateMultiView">
        /// Generate multi-angle views (cannot use with aspect_ratio)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="poseMode"></param>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateTextToImageTaskAsync(
            global::Meshy.ImageAiModel aiModel,
            string prompt,
            bool? generateMultiView = default,
            global::Meshy.TextToImageRequestPoseMode? poseMode = default,
            global::Meshy.AspectRatio? aspectRatio = default,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}