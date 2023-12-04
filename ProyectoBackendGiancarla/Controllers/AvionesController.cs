﻿using Microsoft.AspNetCore.Mvc;
using ProyectoBackendGiancarla.Context;
using ProyectoBackendGiancarla.Models;

namespace ProyectoBackendGiancarla.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvionesController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public AvionesController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarAviones")]
        public async Task<IActionResult> MostrarAviones()
        {
            List<Avion> avions = aplicacionContext.Avion.OrderByDescending(avions => avions.idAvion).ToList();
            return StatusCode(StatusCodes.Status200OK, avions);

        }
        [HttpPost]
        [Route("CrearAviones")]
        public async Task<IActionResult> CrearAviones([FromBody] Avion avion)
        {
            aplicacionContext.Avion.Add(avion);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarAviones")]
        public async Task<IActionResult> EditarAviones([FromBody] Avion avion)
        {
            aplicacionContext.Avion.Update(avion);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarAviones/")]
        public async Task<IActionResult> EliminarAviones(int id)
        {
            Avion avion = aplicacionContext.Avion.Find(id);
            aplicacionContext.Avion.Remove(avion);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }


    }
}
