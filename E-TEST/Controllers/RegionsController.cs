using E_TEST.Models;
using E_TEST.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace E_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionService regionService;
        public RegionsController(IRegionService _regionService)
        {
            regionService = _regionService;
        }

        [HttpGet]
        [Route("GetRegions")]
        public IEnumerable<Region> GetRegions()
        {
            var data = regionService.GetRegions();
            return data;
        }

        [HttpGet]
        [Route("GetRegionsByParentId")]
        public IEnumerable<Region> GetRegionsByParentId(int parentId)
        {
            var data = regionService.GetRegionsByParentId(parentId);
            return data;
        }
    }
}
