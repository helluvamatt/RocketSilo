namespace RocketSilo.Api;

public enum RequestMethod
{
    GET,
    POST,
    PUT,
    DELETE
}

public interface IRequest<T> where T : IResponse
{
}

public interface IResponse
{
}