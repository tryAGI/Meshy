#nullable enable

namespace Meshy
{
    public partial interface IImageToImageClient
    {
        /// <summary>
        /// Retrieve an Image to Image task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.ImageToImageTask> GetImageToImageTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}