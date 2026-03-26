#nullable enable

namespace Meshy
{
    public partial interface ITextTo3dClient
    {
        /// <summary>
        /// Create a Text to 3D task (preview or refine)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateTextTo3DTaskAsync(

            global::Meshy.CreateTextTo3DTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Text to 3D task (preview or refine)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.CreateTaskResponse> CreateTextTo3DTaskAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}