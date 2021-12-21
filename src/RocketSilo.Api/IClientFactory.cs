namespace RocketSilo.Api
{
    public interface IClientFactory
    {
        /// <summary>
        /// Claim a username and obtain a user token for use with the API
        /// </summary>
        /// <param name="username">Username to claim</param>
        /// <returns>A token representing the claimed user</returns>
        Task<string> ClaimUserAsync(string username);

        /// <summary>
        /// Get an API client which will use the given token
        /// </summary>
        /// <param name="token">User token</param>
        /// <returns>IClient implementation</returns>
        IClient GetClient(string token);
    }
}