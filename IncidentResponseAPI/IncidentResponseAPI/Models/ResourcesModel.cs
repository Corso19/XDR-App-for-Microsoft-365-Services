using Microsoft.Graph.Models;

namespace IncidentResponseAPI.Models;

public class ResourcesModel
{
    public int Id { get; set; }
    public string Type { get; set; } //"Email", "Teams", "SharePoint"
    public string Details { get; set; } // details about the resource
    public DateTime DetectedAt {get; set;}
    
    public string Location { get; set; } // Location of the resource, e.g., "SharePoint Site", "Email Folder", etc.
    
    //Specific properties based on resource type
    public string Subject { get; set; } // For Email
    public string Sender { get; set; } // For Email
    public string Recipients { get; set; } // For Email
    public string FileURL { get; set; } // For SharePoint
    public string OriginalItemId { get; set; }
    
    //Navigation properties
    public int EventId { get; set; }
    public Event Event { get; set; }
}