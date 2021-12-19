using RocketSilo.Api.FlightPlans;

namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol/flight-plans")]
public class GetAllActiveFlightPlansInSystemRequest : IRequest<GetAllActiveFlightPlansInSystemResponse>
{
    public string SystemSymbol { get; }
    public GetAllActiveFlightPlansInSystemRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetAllActiveFlightPlansInSystemResponse : IResponse
{
    public IEnumerable<FlightPlan> FlightPlans { get; set; }
}