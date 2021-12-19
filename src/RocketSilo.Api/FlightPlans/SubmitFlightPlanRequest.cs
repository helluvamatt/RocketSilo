namespace RocketSilo.Api.FlightPlans;

[RequestUrl("/my/flight-plans", RequestMethod.POST)]
public class SubmitFlightPlanRequest : IRequest<SubmitFlightPlanResponse>
{
    public SubmitFlightPlanRequest(string shipId, string destination)
    {
        ShipId = shipId;
        Destination = destination;
    }
    public string ShipId { get; }
    public string Destination { get; }
}

public class SubmitFlightPlanResponse : IResponse
{
    public FlightPlan FlightPlan { get; set; }
}