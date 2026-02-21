namespace CrimeHeatmap.API.Models;

public class CrimeReport
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CrimeType { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Address { get; set; }
    public string? PhotoPath { get; set; }
    public string Status { get; set; } = "Pending";
    public DateTime ReportedAt { get; set; } = DateTime.UtcNow;
    public bool IsAnonymous { get; set; } = true;
}
