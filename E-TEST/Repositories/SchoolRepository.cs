using E_TEST.DB;
using E_TEST.Models;
using E_TEST.Repositories.IRepositories;
using System.Linq;

namespace E_TEST.Repositories
{
    public class SchoolRepository : ISchoolRepository, IDisposable
    {
        private readonly DataBaseContext context;

        public SchoolRepository(DataBaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<School> GetSchools()
        {
            return context.branches.OrderBy(x => x.short_name_lat).ToList();
        }

        public School GetSchoolById(int id)
        {
            return context.branches.Find(id);
        }

        public IEnumerable<School> GetSchoolsByRegionId(int regionId)
        {
            List<int> regions = context.regions.Where(x => x.parent_id == regionId).Select(x=>x.id).ToList();
            return from data in context.branches
                   where regions.Contains(data.region_id) && data.company_id == 25
                   orderby data.short_name_lat
                   select data;
                   
        }

        public IEnumerable<School> GetSchoolsByOrganizationId(int organizationId)
        {
            return context.branches.Where(x => x.organization_id == organizationId).OrderBy(x => x.short_name_lat).ToList();
        }

        public IEnumerable<School> GetSchoolsByCompanyId(int companyId)
        {
            return context.branches.Where(x => x.company_id == companyId).OrderBy(x => x.short_name_lat).ToList();
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
