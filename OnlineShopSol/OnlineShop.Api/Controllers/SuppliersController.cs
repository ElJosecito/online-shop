using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            // GET: api/<DepartmentController>
            [HttpGet]
            public IEnumerable<Suppliers>Get()
            {
                return _suppliersRepository.GetAll();
            }

            // GET api/<DepartmentController>/5
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var suppliers = _suppliersRepository.GetEntity(id);
                return Ok(suppliers);
            }

            // POST api/<DepartmentController>
            [HttpPost("SaveSuppliers")]
            public IActionResult Post([FromBody] Suppliers suppliers)
            {
                _suppliersRepository.Add(suppliers);
                return Ok();
            }

            // POST api/<DepartmentController>
            [HttpPost("UpdateSuppliers")]
            public IActionResult Put([FromBody] Suppliers suppliers)
            {
                _suppliersRepository.Update(suppliers);
                return Ok();
            }


            [HttpPost("RemoveSuppliers")]
            public IActionResult Remove([FromBody] Suppliers suppliers)
            {
                _suppliersRepository.Delete(suppliers);
                return Ok();
            }
        }
}

