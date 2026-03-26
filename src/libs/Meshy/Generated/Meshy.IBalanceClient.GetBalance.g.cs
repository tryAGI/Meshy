#nullable enable

namespace Meshy
{
    public partial interface IBalanceClient
    {
        /// <summary>
        /// Get credit balance
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshy.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshy.BalanceResponse> GetBalanceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}