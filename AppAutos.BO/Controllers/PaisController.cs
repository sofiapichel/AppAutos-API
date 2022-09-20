using ABM.AppAutos.BE.Models.DTO;
using ABM.AppAutos.BE.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly IPaisService _PaisService;
        public PaisController(IPaisService PaisService)
        {
            _PaisService = PaisService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(PaisDTO model)
        {
            var resultado = await _PaisService.Insert(model);

            return Ok(resultado);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> Update(PaisDTO model)
        {
            var resultado = await _PaisService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _PaisService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var resultado = await _PaisService.GetById(id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _PaisService.GetAll();

            return Ok(resultado);
        }

    }
}
