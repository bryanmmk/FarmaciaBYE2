using Microsoft.AspNetCore.Mvc;
using FarmaciaBYE2.Adaptors.SQLServerDataAccess.Contexts;
using FarmaciaBYE2.Core.Application.UseCases;
using FarmaciaBYE2.Core.Infraestructure.Repository.Concrete;
using System.Collections.Generic;
using FarmaciaBYE2.Core.Domain.Models;
using System;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaBYE2BD.Ports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        public ProveedorUseCase CreateService()
        {
            FarmaciaBD db = new FarmaciaBD();
            ProveedorRepository repository = new  ProveedorRepository(db);
            ProveedorUseCase service = new ProveedorUseCase(repository);
            return service;
        }

        // GET: api/<ProveedorController>
        [HttpGet]
        public ActionResult<IEnumerable<Proveedor>> Get()
        {
            ProveedorUseCase service = CreateService();
            return Ok(service.GetAll());
        }

        // GET api/<ProveedorController>/5
        [HttpGet("{id}")]
        public ActionResult<Proveedor> Get(Guid id)
        {
            ProveedorUseCase service = CreateService();
            return Ok(service.GetById(id));
        }

        // POST api/<ProveedorController>
        [HttpPost]
        public ActionResult<Proveedor> Post([FromBody] Proveedor proveedor)
        {
            ProveedorUseCase service = CreateService();
            var result = service.Create(proveedor);
            return Ok(result);
        }

        // PUT api/<ProveedorController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Proveedor proveedor)
        {
            ProveedorUseCase service = CreateService();
            proveedor.ID_Proveedor = id;
            service.Update(proveedor);
            return Ok("Editado exitosamente");

        }

        // DELETE api/<ProveedorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            ProveedorUseCase service = CreateService();
            service.Delete(id);
            return Ok("Eliminado exitosamente");
        }
    }
}
