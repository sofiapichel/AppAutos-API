using ABM.AppAutos.BE.Models.DTO;
using ABM.AppAutos.BE.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaService _MarcaService;
        public MarcaController(
            IMarcaService MarcaService)
        {
            _MarcaService = MarcaService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(MarcaDTO model)
        {
            var resultado = await _MarcaService.Insert(model);

            return Ok(resultado);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> Update(MarcaDTO model)
        {
            var resultado = await _MarcaService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _MarcaService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var resultado = await _MarcaService.GetById(id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _MarcaService.GetAll();

            return Ok(resultado);
        }

    }
}
