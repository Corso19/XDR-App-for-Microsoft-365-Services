using Microsoft.Graph.Models;

namespace IncidentResponseAPI.Models;

public class EntitiesModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Identifier { get; set; } // Email, UPN, object ID
    public DateTime DetectedAt { get; set; }
    
    //Navigation properties
    public int EventId { get; set; }
    public Event Event { get; set; }
}