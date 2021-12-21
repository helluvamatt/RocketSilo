namespace RocketSilo.Api;

// ReSharper disable four InconsistentNaming
public enum RequestMethod
{
    GET,
    POST,
    PUT,
    DELETE
}

// ReSharper disable once UnusedTypeParameter
public interface IApiRequest<T> where T : IApiResponse
{
}

public interface IApiResponse
{
}