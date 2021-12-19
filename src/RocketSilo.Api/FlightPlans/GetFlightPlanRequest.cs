namespace RocketSilo.Api.FlightPlans;

[RequestUrl("/my/flight-plans/:flightPlanId")]
public class GetFlightPlanRequest : IRequest<GetFlightPlanResponse>
{
    public GetFlightPlanRequest(string flightPlanId)
    {
        FlightPlanId = flightPlanId;
    }

    public string FlightPlanId { get; }
}

public class GetFlightPlanResponse : IResponse
{
    public FlightPlan FlightPlan { get; set; }
}