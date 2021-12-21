using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace RocketSilo.Api;

internal partial class Client : IClient
{
    internal Client(HttpClient httpClient, Uri baseUri, string? token = null)
    {
        this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        this.baseUri = baseUri ?? throw new ArgumentNullException(nameof(baseUri));
        this.token = token;
    }

    private readonly HttpClient httpClient;
    private readonly Uri baseUri;
    private readonly string? token;

    private static readonly Regex UrlParseRegex = new(@"\/(:[a-z|A-Z]*)\/?");

    private static readonly JsonSerializerOptions SerializerOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

    private async Task<TResponse> SendAsync<TRequest, TResponse>(TRequest request) where TRequest: IRequest<TResponse> where TResponse: IResponse
    {
        Attribute? requestUrlAttribute = Attribute.GetCustomAttribute(request.GetType(), typeof(RequestUrlAttribute));
        if (requestUrlAttribute is not RequestUrlAttribute requestUrl)
            throw new InvalidOperationException($"Request type {request.GetType()} does not have a RequestUrlAttribute");

        MatchCollection matches = UrlParseRegex.Matches(requestUrl.Url);

        List<string> urlTokens = new();

        if (matches.Any())
        {
            foreach (Match match in matches)
            {
                string urlToken = match.Groups[1].Value;
                urlTokens.Add(urlToken);
            }
        }

        Dictionary<string, string> urlsTokensDictionary = new();

        if (urlTokens.Any())
        {
            foreach (string urlToken in urlTokens)
            {
                string propertyName = urlToken[1..];
                propertyName = char.ToUpperInvariant(propertyName[0]) + propertyName[1..];
                PropertyInfo? propertyInfo = request.GetType().GetProperty(propertyName);
                string? value = propertyInfo?.GetValue(request)?.ToString();
                if (value is not null)
                {
                    urlsTokensDictionary.Add(urlToken, value);
                }
            }
        }

        string url = requestUrl.Url;

        if (urlsTokensDictionary.Any())
        {
            foreach ((string? key, string? value) in urlsTokensDictionary)
            {
                url = url.Replace(key, value);
            }
        }

        HttpRequestMessage requestMessage = new();
        requestMessage.Headers.Add("Authorization", $"Bearer {token}");
        requestMessage.Headers.Add("Accept", "application/json");
        requestMessage.RequestUri = new Uri(baseUri, url);

        requestMessage.Method = requestUrl.RequestMethod switch
        {
            RequestMethod.GET => HttpMethod.Get,
            RequestMethod.POST => HttpMethod.Post,
            RequestMethod.PUT => HttpMethod.Put,
            RequestMethod.DELETE => HttpMethod.Delete,
            _ => throw new NotImplementedException()
        };

        if(requestMessage.Method == HttpMethod.Post || requestMessage.Method == HttpMethod.Put)
        {
            requestMessage.Content = new StringContent(JsonSerializer.Serialize(request, SerializerOptions), System.Text.Encoding.UTF8, "application/json");
        }

        return await SendAndDeserializeAsync<TResponse>(requestMessage);
    }

    private async Task<TResponse> SendAndDeserializeAsync<TResponse>(HttpRequestMessage requestMessage)
    {
        HttpResponseMessage responseMessage = await httpClient.SendAsync(requestMessage);
        byte[] bytes = await responseMessage.Content.ReadAsByteArrayAsync();
        TResponse? responseObject = JsonSerializer.Deserialize<TResponse>(bytes, SerializerOptions);
        if (responseObject is null)
            throw new NullReferenceException();
        return responseObject;
    }
}