#nullable enable

namespace Meshy
{
    public partial interface IImageTo3dClient
    {
        /// <summary>
        /// Delete an Image to 3D task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteImageTo3DTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}