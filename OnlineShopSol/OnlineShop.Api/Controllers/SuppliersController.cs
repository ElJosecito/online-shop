using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL.Entities;
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
            var suppliers = _suppliersRepository.GetEntities();

            return Ok(suppliers);
        }

        // GET api/<SuppliersController>/5
        [HttpGet("{id}")]
        public IActionResult GetEntity(int id)
        {
            var supplier = _suppliersRepository.Get(id);
            return Ok(supplier);
        }

        // POST api/<SuppliersController>
        [HttpPost("SaveSuppliers")]
        public IActionResult Post([FromBody] Suppliers suppliers)
        {
            _suppliersRepository.Save(suppliers);
            return Ok();
        }

        // PUT api/<SuppliersController>/5
        [HttpPut("UpdateSuppliers")]
        public IActionResult Put([FromBody] Suppliers suppliers)
        {
            _suppliersRepository.Update(suppliers);
            return Ok();
        }


        // DELETE api/<SuppliersController>/5
        [HttpPost("DeleteSuppliers")]
        public IActionResult Remove([FromBody] Suppliers suppliers)
        {
            _suppliersRepository.Delete(suppliers);
            return Ok();
        }

    }
}
