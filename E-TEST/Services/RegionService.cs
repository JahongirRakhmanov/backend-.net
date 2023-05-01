using E_TEST.Models;
using E_TEST.Repositories.IRepositories;
using E_TEST.Services.IServices;

namespace E_TEST.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRegionRepository _regionRepo;

        public RegionService(IRegionRepository regionRepo)
        {
            _regionRepo = regionRepo;
        }

        public IEnumerable<Region> GetRegions()
        {
            var result = _regionRepo.GetRegions();
            return result;
        }

        public IEnumerable<Region> GetRegionsByParentId(int parentId)
        {
            var result = _regionRepo.GetRegionsByParentId(parentId);
            return result;
        }
    }
}
