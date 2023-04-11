using Microsoft.AspNetCore.Mvc;
using OnlineShop.BL.Contract;
using OnlineShop.BL.Dtos.Suppliers;
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
        private readonly ISupplierService supplierService;
        public SuppliersController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }

        // GET: api/<SuppliersController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.supplierService.GetAll();

            return Ok(result);
        }

        // GET api/<SuppliersController>/5
        [HttpGet("{id}")]
        public IActionResult GetEntity(int id)
        {
            var result = this.supplierService.GetById(id);
            
            if (result.Success) 
                return Ok(result);
            else
                return BadRequest(result);
        }

        // POST api/<SuppliersController>
        [HttpPost("SaveSuppliers")]
        public IActionResult Post([FromBody] SuppliersSaveDto suppliersSaveDto)
        {
            var result = this.supplierService.SaveSupplier(suppliersSaveDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // PUT api/<SuppliersController>/5
        [HttpPut("UpdateSuppliers")]
        public IActionResult Put([FromBody] SuppliersUpdateDto suppliersUpdateDto)
        {
            var result = this.supplierService.UpdateSupplier(suppliersUpdateDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }


        // DELETE api/<SuppliersController>/5
        [HttpPut("DeleteSuppliers")]
        public IActionResult RemoveSupplier([FromBody] SuppliersRemoveDto suppliersRemoveDto)
        {
            var result = this.supplierService.DeleteSuppliers(suppliersRemoveDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

    }
}
