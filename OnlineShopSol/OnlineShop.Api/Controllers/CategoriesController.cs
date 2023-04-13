using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using OnlineShop.DAL.Model;

namespace OnlineShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesRepository _CategoriesRepository;
        public CategoriesController(ICategoriesRepository CategoriesRepository)
        {
            _CategoriesRepository = CategoriesRepository;
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public IActionResult Get()
        {
            var Categories = _CategoriesRepository.GetEntities();

            return Ok(Categories);
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public IActionResult GetEntity(int id)
        {
            var supplier = _CategoriesRepository.Get(id);
            return Ok(supplier);
        }

        // POST api/<CategoriesController>
        [HttpPost("SaveCategories")]
        public IActionResult Post([FromBody] Categories Categories)
        {
            _CategoriesRepository.Save(Categories);
            return Ok();
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("UpdateCategories")]
        public IActionResult Put([FromBody] Categories Categories)
        {
            _CategoriesRepository.Update(Categories);
            return Ok();
        }


        // DELETE api/<CategoriesController>/5
        [HttpPost("DeleteCategories")]
        public IActionResult Remove([FromBody] Categories Categories)
        {
            _CategoriesRepository.Delete(Categories);
            return Ok();
        }

    }
}
