using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using RocketSilo.Api.Users;

namespace RocketSilo.Api;

public partial class Client
{
    public async Task<string> CreateNewUser(string username)
    {
        Client c = new();
        ClaimAUsernameResponse response = await c.ClaimAUsername(new ClaimAUsernameRequest(username));
        return response.Token;
    }

    public static Client CreateClient(string token)
    {
        return new Client(token);
    }
    
    private Client(string token)
    {
        this.token = token;
    }

    private Client() 
    { 
        this.token = string.Empty;
    }
    
    private static readonly HttpClient HttpClient = new();
    private const string BaseUrl = "https://api.spacetraders.io";
    private readonly string token;

    private static readonly Regex _urlParseRegex = new(@"\/(:[a-z|A-Z]*)\/?");
    
    private static readonly JsonSerializerOptions SerializerOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

    private async Task<TResponse> SendAsync<TRequest, TResponse>(TRequest request) where TRequest: IRequest<TResponse> where TResponse: IResponse
    {
        Attribute? requestUrlAttribute = Attribute.GetCustomAttribute(request.GetType(), typeof(RequestUrlAttribute));
        if (requestUrlAttribute is not RequestUrlAttribute requestUrl)
            throw new InvalidOperationException($"Request type {request.GetType()} does not have a RequestUrlAttribute");
        
        MatchCollection matches = _urlParseRegex.Matches(requestUrl.Url);

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
        requestMessage.RequestUri = new Uri($"{BaseUrl}{url}");
            
            
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

    private static async Task<TResponse> SendAndDeserializeAsync<TResponse>(HttpRequestMessage requestMessage)
    {
        HttpResponseMessage responseMessage = await HttpClient.SendAsync(requestMessage);
        byte[] bytes = await responseMessage.Content.ReadAsByteArrayAsync();
        TResponse? responseObject = JsonSerializer.Deserialize<TResponse>(bytes, SerializerOptions);
        if (responseObject is null)
            throw new NullReferenceException();
        return responseObject;
    }
}