namespace HealthKitReport;

public record WeightItem
{
    public DateTime Timestamp { get; init; }
    public Double Value  { get; init; }
}