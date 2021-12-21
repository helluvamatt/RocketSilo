namespace RocketSilo.Api;

public class RocketSiloConfig
{
    /// <summary>
    /// The default BaseUrl for SpaceTraders.io
    /// </summary>
    public const string DefaultBaseUrl = "https://api.spacetraders.io";

    /// <summary>
    /// Represents the base url for the API
    /// </summary>
    public string BaseUrl { get; set; } = null!;

    /// <summary>
    /// Represents the base url for the API as a <see cref="Uri" />
    /// </summary>
    public Uri BaseUri => new(BaseUrl);

    /// <summary>
    /// Attempts to validate the configuration
    /// </summary>
    /// <returns>True if the configuration is valid, false otherwise</returns>
    public bool Validate()
    {
        return !string.IsNullOrWhiteSpace(BaseUrl) && Uri.TryCreate(BaseUrl, UriKind.Absolute, out _);
    }
}
