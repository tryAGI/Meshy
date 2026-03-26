#nullable enable

namespace Meshy
{
    public partial interface IRemeshClient
    {
        /// <summary>
        /// Retrieve a Remesh task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.RemeshTask> GetRemeshTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}