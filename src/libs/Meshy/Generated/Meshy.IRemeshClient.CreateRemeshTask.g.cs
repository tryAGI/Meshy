#nullable enable

namespace Meshy
{
    public partial interface IRemeshClient
    {
        /// <summary>
        /// Create a Remesh task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateRemeshTaskAsync(

            global::Meshy.RemeshRequest request,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Remesh task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.AutoSDKHttpResponse<global::Meshy.CreateTaskResponse>> CreateRemeshTaskAsResponseAsync(

            global::Meshy.RemeshRequest request,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Remesh task
        /// </summary>
        /// <param name="inputTaskId">
        /// ID of completed task to remesh
        /// </param>
        /// <param name="modelUrl">
        /// Public URL or data URI (.glb/.gltf/.obj/.fbx/.stl)
        /// </param>
        /// <param name="targetFormats">
        /// Default Value: [glb]
        /// </param>
        /// <param name="topology">
        /// Default Value: triangle
        /// </param>
        /// <param name="targetPolycount">
        /// Default Value: 30000
        /// </param>
        /// <param name="resizeHeight">
        /// Resize to height in meters (0 = no resize)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="autoSize">
        /// Default Value: false
        /// </param>
        /// <param name="originAt"></param>
        /// <param name="convertFormatOnly">
        /// Only convert format, skip remesh processing
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateRemeshTaskAsync(
            string? inputTaskId = default,
            string? modelUrl = default,
            global::System.Collections.Generic.IList<global::Meshy.TargetFormatRemesh>? targetFormats = default,
            global::Meshy.Topology? topology = default,
            int? targetPolycount = default,
            double? resizeHeight = default,
            bool? autoSize = default,
            global::Meshy.OriginAt? originAt = default,
            bool? convertFormatOnly = default,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}