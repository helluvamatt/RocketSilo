namespace RocketSilo.Api.FlightPlans;

[RequestUrl("/my/flight-plans/:flightPlanId")]
public class GetFlightPlanRequest : IApiRequest<GetFlightPlanResponse>
{
    public GetFlightPlanRequest(string flightPlanId)
    {
        FlightPlanId = flightPlanId;
    }

    public string FlightPlanId { get; }
}

public class GetFlightPlanResponse : IApiResponse
{
    public FlightPlan FlightPlan { get; set; } = null!;
}