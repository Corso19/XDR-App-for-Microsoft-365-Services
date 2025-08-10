using Microsoft.Graph.Models;
using AlertStatus = IncidentResponseAPI.Constants.AlertStatus;

namespace IncidentResponseAPI.Models;

public class AlertsModel
{
    public int Id { get; set; }
    public string Title { get; set; } 
    public string Description { get; set; }
    public string Severity { get; set; }
    public DateTime CreatedAt { get; set; }
    public AlertStatus Status { get; set; }
    
    // Navigation properties
    public int EventId { get; set; }
    public Event Event { get; set; }
}