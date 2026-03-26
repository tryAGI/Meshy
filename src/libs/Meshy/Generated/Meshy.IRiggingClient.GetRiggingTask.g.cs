#nullable enable

namespace Meshy
{
    public partial interface IRiggingClient
    {
        /// <summary>
        /// Retrieve a Rigging task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.RiggingTask> GetRiggingTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}