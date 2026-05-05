#nullable enable

namespace Meshy
{
    public partial interface ITextTo3dClient
    {
        /// <summary>
        /// Create a Text to 3D task (preview or refine)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateTextTo3DTaskAsync(

            global::Meshy.CreateTextTo3DTaskRequest request,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Text to 3D task (preview or refine)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.AutoSDKHttpResponse<global::Meshy.CreateTaskResponse>> CreateTextTo3DTaskAsResponseAsync(

            global::Meshy.CreateTextTo3DTaskRequest request,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Text to 3D task (preview or refine)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateTextTo3DTaskAsync(
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}