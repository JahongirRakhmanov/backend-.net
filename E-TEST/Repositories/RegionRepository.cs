using E_TEST.DB;
using E_TEST.Models;
using E_TEST.Repositories.IRepositories;

namespace E_TEST.Repositories
{
    public class RegionRepository : IRegionRepository, IDisposable
    {
        private readonly DataBaseContext context;

        public RegionRepository(DataBaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Region> GetRegions()
        {
            return context.regions.Where(x => x.id < 15).OrderBy(x => x.id).ToList();
        }

        public IEnumerable<Region> GetRegionsByParentId(int parentId)
        {
            return context.regions.Where(x=> x.parent_id == parentId).OrderBy(x => x.region_lat).ToList();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
