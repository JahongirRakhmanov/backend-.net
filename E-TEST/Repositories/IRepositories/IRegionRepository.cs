using E_TEST.Models;

namespace E_TEST.Repositories.IRepositories
{
    public interface IRegionRepository : IDisposable
    {
        IEnumerable<Region> GetRegions();
        IEnumerable<Region> GetRegionsByParentId(int parentId);
    }
}
