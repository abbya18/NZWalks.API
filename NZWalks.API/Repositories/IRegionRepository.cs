using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();   // Get all the regions back using this method

        // Get a single region back
        Task<Region?>GetByIdAsync(Guid id);

        Task<Region>CreateAsync(Region region);

        Task<Region?>UpdateAsync(Guid id, Region region);

        Task<Region?> DeleteAsync(Guid id);
    }
}
