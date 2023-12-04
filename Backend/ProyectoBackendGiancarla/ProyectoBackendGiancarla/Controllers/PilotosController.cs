using Microsoft.AspNetCore.Mvc;
using ProyectoBackendGiancarla.Context;
using ProyectoBackendGiancarla.Models;

namespace ProyectoBackendGiancarla.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PilotosController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public PilotosController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarHPilotos")]
        public async Task<IActionResult> MostrarPilotos()
        {
            List<Piloto> pilotos = aplicacionContext.Piloto.OrderByDescending(pilotos => pilotos.numeroLicencia).ToList();
            return StatusCode(StatusCodes.Status200OK, pilotos);

        }
        [HttpPost]
        [Route("CrearHPilotos")]
        public async Task<IActionResult> CrearPilotos([FromBody] Piloto piloto)
        {
            aplicacionContext.Piloto.Add(piloto);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarPilotos")]
        public async Task<IActionResult> EditarPilotos([FromBody] Piloto piloto)
        {
            aplicacionContext.Piloto.Update(piloto);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarPilotos/")]
        public async Task<IActionResult> EliminarPilotos(int id)
        {
            Piloto piloto = aplicacionContext.Piloto.Find(id);
            aplicacionContext.Piloto.Remove(piloto);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }


    }
}
