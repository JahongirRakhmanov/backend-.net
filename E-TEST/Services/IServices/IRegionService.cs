using E_TEST.Models;

namespace E_TEST.Services.IServices
{
    public interface IRegionService
    {
        IEnumerable<Region> GetRegions();
        IEnumerable<Region> GetRegionsByParentId(int parentId);
    }
}
