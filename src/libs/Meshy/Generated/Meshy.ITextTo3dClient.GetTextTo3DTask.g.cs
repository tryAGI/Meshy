#nullable enable

namespace Meshy
{
    public partial interface ITextTo3dClient
    {
        /// <summary>
        /// Retrieve a Text to 3D task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.TextTo3DTask> GetTextTo3DTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}