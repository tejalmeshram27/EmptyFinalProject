using EmptyFinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmptyFinalProject.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISportsRepo _sportsRepo;

        public SearchController(ISportsRepo sportsRepo)
        {
            _sportsRepo = sportsRepo;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            var allPaintings = _sportsRepo.AllSports;
            return Ok(allPaintings);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (!_sportsRepo.AllSports.Any(p => p.SportsId == id))
                return NotFound();
            return Ok(_sportsRepo.AllSports.Where(p => p.SportsId == id));
        }

        [HttpPost]
        public IActionResult SearchSports([FromBody] string searchQuery)
        {
            IEnumerable<Sports> sports = new List<Sports>();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                sports = _sportsRepo.SearchSports(searchQuery);
            }

            return new JsonResult (sports);
        }

    }
}
