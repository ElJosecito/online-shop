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
            private readonly ISuppliersRepository _suppliersRepositories;

            public SuppliersController(ISuppliersRepository suppliersRepository)
            {
                _suppliersRepositories = suppliersRepository;
            }
            // GET: api/<DepartmentController>
            [HttpGet]
            public IActionResult Get()
            {
                var suppliers = _suppliersRepositories.GetEntities();
                return Ok(suppliers);
            }

            // GET api/<DepartmentController>/5
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var suppliers = _suppliersRepositories.GetEntity(id);

                return Ok(suppliers);
            }

            // POST api/<DepartmentController>
            [HttpPost("SaveSuppliers")]
            public IActionResult Post([FromBody] Suppliers suppliers)
            {
                _suppliersRepositories.Add(suppliers);
                return Ok();
            }

            // POST api/<DepartmentController>
            [HttpPost("UpdateSuppliers")]
            public IActionResult Put([FromBody] Suppliers suppliers)
            {
                _suppliersRepositories.Update(suppliers);
                return Ok();
            }


            [HttpPost("RemoveSuppliers")]
            public IActionResult Remove([FromBody] Suppliers suppliers)
            {
                _suppliersRepositories.Delete(suppliers);
                return Ok();
            }
        }
}

