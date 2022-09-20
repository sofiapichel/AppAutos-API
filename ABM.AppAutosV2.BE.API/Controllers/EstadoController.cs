using ABM.AppAutos.BE.Models.DTO;
using ABM.AppAutos.BE.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoService _EstadoService;
        public EstadoController(IEstadoService EstadoService)
        {
            _EstadoService = EstadoService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(EstadoDTO model)
        {
            var resultado = await _EstadoService.Insert(model);

            return Ok(resultado);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> Update(EstadoDTO model)
        {
            var resultado = await _EstadoService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _EstadoService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var resultado = await _EstadoService.GetById(id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _EstadoService.GetAll();

            return Ok(resultado);
        }

    }
}
