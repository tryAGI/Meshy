#nullable enable

namespace Meshy
{
    public partial interface ITextToImageClient
    {
        /// <summary>
        /// Delete a Text to Image task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTextToImageTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}