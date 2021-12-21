namespace RocketSilo.Api;

public enum RequestMethod
{
    GET,
    POST,
    PUT,
    DELETE
}

public interface IApiRequest<T> where T : IApiResponse
{
}

public interface IApiResponse
{
}