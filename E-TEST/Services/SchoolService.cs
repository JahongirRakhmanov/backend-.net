using E_TEST.Models;
using E_TEST.Repositories.IRepositories;
using E_TEST.Services.IServices;

namespace E_TEST.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolRepo;

        public SchoolService(ISchoolRepository schoolRepo)
        {
            _schoolRepo = schoolRepo;
        }
        public School GetSchoolById(int id)
        {
            var result = _schoolRepo.GetSchoolById(id);
            return result;
        }
        public IEnumerable<School> GetSchools()
        {
            var result = _schoolRepo.GetSchools();
            return result;
        }
        public IEnumerable<School> GetSchoolsByCompanyId(int companyId)
        {
            var result = _schoolRepo.GetSchoolsByCompanyId(companyId);
            return result;
        }
        public IEnumerable<School> GetSchoolsByOrganizationId(int organizationId)
        {
            var result = _schoolRepo.GetSchoolsByOrganizationId(organizationId);
            return result;
        }
        public IEnumerable<School> GetSchoolsByRegionId(int regionId)
        {
            var result = _schoolRepo.GetSchoolsByRegionId(regionId);
            return result;
        }

    }
}