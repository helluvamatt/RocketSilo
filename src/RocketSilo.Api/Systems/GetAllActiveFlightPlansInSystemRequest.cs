using RocketSilo.Api.FlightPlans;

namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol/flight-plans")]
public class GetAllActiveFlightPlansInSystemRequest : IApiRequest<GetAllActiveFlightPlansInSystemResponse>
{
    public string SystemSymbol { get; }
    public GetAllActiveFlightPlansInSystemRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetAllActiveFlightPlansInSystemResponse : IApiResponse
{
    public IEnumerable<FlightPlan> FlightPlans { get; set; } = Enumerable.Empty<FlightPlan>();
}