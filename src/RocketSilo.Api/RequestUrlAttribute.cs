namespace RocketSilo.Api;

[AttributeUsage(AttributeTargets.Class)]
public class RequestUrlAttribute : Attribute
{
    public RequestUrlAttribute(string url, RequestMethod requestMethod = RequestMethod.GET)
    {
        Url = url;
        RequestMethod = requestMethod;
    }
    
    public string Url { get; }
    public RequestMethod RequestMethod { get; }
}