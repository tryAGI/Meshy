#nullable enable

namespace Meshy
{
    public partial interface IImageTo3dClient
    {
        /// <summary>
        /// List Image to 3D tasks
        /// </summary>
        /// <param name="pageNum">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Meshy.ImageTo3DTask>> ListImageTo3DTasksAsync(
            int? pageNum = default,
            int? pageSize = default,
            global::Meshy.ListImageTo3DTasksSortBy? sortBy = default,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Image to 3D tasks
        /// </summary>
        /// <param name="pageNum">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Meshy.ImageTo3DTask>>> ListImageTo3DTasksAsResponseAsync(
            int? pageNum = default,
            int? pageSize = default,
            global::Meshy.ListImageTo3DTasksSortBy? sortBy = default,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}