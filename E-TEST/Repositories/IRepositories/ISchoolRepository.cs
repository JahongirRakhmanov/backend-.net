using E_TEST.Models;

namespace E_TEST.Repositories.IRepositories
{
    public interface ISchoolRepository : IDisposable
    {
        IEnumerable<School> GetSchools();
        School GetSchoolById(int id);
        IEnumerable<School> GetSchoolsByRegionId(int regionId);
        IEnumerable<School> GetSchoolsByOrganizationId(int organizationId);
        IEnumerable<School> GetSchoolsByCompanyId(int companyId);
    }
}
