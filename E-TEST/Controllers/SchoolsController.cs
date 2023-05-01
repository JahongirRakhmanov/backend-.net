using E_TEST.Models;
using E_TEST.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace E_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly ISchoolService schoolService;
        public SchoolsController(ISchoolService _schoolService)
        {
            schoolService = _schoolService;
        }

        [HttpGet]
        [Route("GetSchools")]
        public IEnumerable<School> GetSchools()
        {
            var data = schoolService.GetSchools();
            return data;
        }

        [HttpGet]
        [Route("GetSchoolById")]
        public School GetSchoolById(int schoolId)
        {
            var data = schoolService.GetSchoolById(schoolId);
            return data;
        }

        [HttpGet]
        [Route("GetSchoolsByRegionId")]
        public IEnumerable<School> GetSchoolsByRegionId(int regionId)
        {
            var data = schoolService.GetSchoolsByRegionId(regionId);
            return data;
        }

        [HttpGet]
        [Route("GetSchoolsByOrganizationId")]
        public IEnumerable<School> GetSchoolsByOrganizationId(int organizationId)
        {
            var data = schoolService.GetSchoolsByOrganizationId(organizationId);
            return data;
        }

        [HttpGet]
        [Route("GetSchoolsByCompanyId")]
        public IEnumerable<School> GetSchoolsByCompanyId(int companyId)
        {
            var data = schoolService.GetSchoolsByCompanyId(companyId);
            return data;
        }
    }
}
