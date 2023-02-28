using api_librerias_paco.Models;
using api_librerias_paco.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_librerias_paco.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibroClienteController : ControllerBase
    {
        private readonly LibreriaContext _dbContext;
        private readonly LibroClienteService _libroClienteService;

    public LibroClienteController(LibreriaContext dbContext)
    {
        _dbContext = dbContext;
        _libroClienteService = new LibroClienteService(_dbContext);
    }

        [HttpGet("{idCliente}")]
        public async Task<ActionResult<List<LibroCliente>>> GetLibrosCliente(int idCliente)
        {
            var librosCliente = await _libroClienteService.GetLibrosCliente(idCliente);

            if (librosCliente == null)
            {
                return NotFound();
            }

            return librosCliente;
        }

        [HttpPost]
        public async Task<ActionResult> AddLibroCliente(LibroCliente libroCliente)
        {
            await _libroClienteService.AddLibroCliente(libroCliente);

            return Ok();
        }

        [HttpPut("{idCliente}/{idLibro}")]
        public async Task<ActionResult> UpdateLibroCliente(int idCliente, int idLibro, string nombreLibro)
        {
            await _libroClienteService.UpdateLibroCliente(idCliente, idLibro, nombreLibro);

            return Ok();
        }

        [HttpDelete("{idCliente}/{idLibro}")]
        public async Task<ActionResult> DeleteLibroCliente(int idCliente, int idLibro)
        {
            await _libroClienteService.DeleteLibroCliente(idCliente, idLibro);

            return Ok();
        }
    }


}
