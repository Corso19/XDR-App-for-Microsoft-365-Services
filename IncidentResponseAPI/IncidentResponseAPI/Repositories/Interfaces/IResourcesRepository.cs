using IncidentResponseAPI.Models;
using Microsoft.Graph.Models;

namespace IncidentResponseAPI.Repositories.Interfaces;

public interface IResourcesRepository : IDisposable
{
    Task<IEnumerable<ResourcesModel>>
    
}