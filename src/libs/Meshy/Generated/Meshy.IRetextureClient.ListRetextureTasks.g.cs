#nullable enable

namespace Meshy
{
    public partial interface IRetextureClient
    {
        /// <summary>
        /// List Retexture tasks
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Meshy.RetextureTask>> ListRetextureTasksAsync(
            int? pageNum = default,
            int? pageSize = default,
            global::Meshy.ListRetextureTasksSortBy? sortBy = default,
            global::Meshy.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}