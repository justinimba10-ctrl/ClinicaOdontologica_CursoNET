using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaOdontologica.Modelos;

namespace ClinicaOdontologica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleCitasController : ControllerBase
    {
        private readonly ClinicaOdontologicaAPIContext _context;

        public DetalleCitasController(ClinicaOdontologicaAPIContext context)
        {
            _context = context;
        }

        // GET: api/DetalleCitas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleCita>>> GetDetalleCitas()
        {
            // Nota: Si en tu DbContext la propiedad se llama DetallesCita, cámbialo aquí
            return await _context.DetalleCitas.ToListAsync();
        }

        // GET: api/DetalleCitas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleCita>> GetDetalleCita(int id)
        {
            var detalle = await _context.DetalleCitas.FindAsync(id);

            if (detalle == null)
            {
                return NotFound();
            }

            return detalle;
        }

        // PUT: api/DetalleCitas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleCita(int id, DetalleCita detalleCita)
        {
            // Se usa idDetalleCita (o la propiedad Key que tengas en el modelo DetalleCita.cs)
            if (id != detalleCita.detalleCita)
            {
                return BadRequest();
            }

            _context.Entry(detalleCita).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleCitaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DetalleCitas
        [HttpPost]
        public async Task<ActionResult<DetalleCita>> PostDetalleCita(DetalleCita detalleCita)
        {
            _context.DetalleCitas.Add(detalleCita);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDetalleCita), new { id = detalleCita.detalleCita }, detalleCita);
        }

        // DELETE: api/DetalleCitas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleCita(int id)
        {
            var detalle = await _context.DetalleCitas.FindAsync(id);
            if (detalle == null)
            {
                return NotFound();
            }

            _context.DetalleCitas.Remove(detalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleCitaExists(int id)
        {
            return _context.DetalleCitas.Any(e => e.detalleCita == id);
        }
    }
}