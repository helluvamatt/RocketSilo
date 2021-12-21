using Microsoft.Extensions.Options;
using RocketSilo.Api.Users;

namespace RocketSilo.Api;

/// <summary>
/// Provides a default implementation of <see cref="IClientFactory" />
/// </summary>
public class ClientFactory : IClientFactory
{
    private readonly HttpClient httpClient;
    private readonly IOptions<RocketSiloConfig> options;

    public ClientFactory(HttpClient httpClient, IOptions<RocketSiloConfig> options)
    {
        this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        this.options = options ?? throw new ArgumentNullException(nameof(options));
    }

    /// <inheritdoc />
    public async Task<string> ClaimUserAsync(string username)
    {
        IClient c = new Client(httpClient, options.Value.BaseUri);
        ClaimAUsernameResponse response = await c.ClaimAUsernameAsync(new ClaimAUsernameRequest(username));
        return response.Token;
    }

    /// <inheritdoc />
    public IClient GetClient(string token)
    {
        return new Client(httpClient, options.Value.BaseUri, token);
    }
}