using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL.Interfaces;
using OnlineShop.DAL.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISuppliersRepository _suppliersRepository;
        public SuppliersController(ISuppliersRepository suppliersRepository)
        {
            _suppliersRepository = suppliersRepository;
        }

        // GET: api/<SuppliersController>
        [HttpGet]
        public IActionResult Get()
        {
            var suppliers = _suppliersRepository.GetAll();

            return Ok(suppliers);
        }

        // GET api/<SuppliersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var supplier = _suppliersRepository.Get(id);
            return Ok(supplier);
        }

        // POST api/<SuppliersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SuppliersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SuppliersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
