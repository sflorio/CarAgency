using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarAgency.Data;
using Domain.DTO.Direcciones;
using AutoMapper;
namespace CarAgency.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PartidosController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public PartidosController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Partidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partido>>> GetPartidos()
        {
            var partidos = await _context.Partidos.ToListAsync<Domain.Models.Direcciones.Partido>();

            return _mapper.Map<List<Domain.Models.Direcciones.Partido>,List<Domain.DTO.Direcciones.Partido>>(partidos);
        }

        [HttpGet("Provincia/{ProvinciaId}")]
        public async Task<ActionResult<IEnumerable<Partido>>> GetPartidosByProvincia(int ProvinciaId)
        {
            var partidos = await _context.Partidos.Where( e => e.Provincia.ProvinciaId == ProvinciaId).ToListAsync<Domain.Models.Direcciones.Partido>();

            return _mapper.Map<List<Domain.Models.Direcciones.Partido>, List<Domain.DTO.Direcciones.Partido>>(partidos);
        }

        // GET: api/Partidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Partido>> GetPartido(int id)
        {
            var partido = await _context.Partidos.FindAsync(id);

            if (partido == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Direcciones.Partido, Domain.DTO.Direcciones.Partido>(partido);
        }

        // PUT: api/Partidos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartido(int id, Partido partido)
        {
            if (id != partido.PartidoId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Direcciones.Partido>(partido)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartidoExists(id))
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

        // POST: api/Partidos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Partido>> PostPartido(Partido partido)
        {
            Domain.Models.Direcciones.Partido objePartido = _mapper.Map<Domain.Models.Direcciones.Partido>(partido);

            _context.Partidos.Add(objePartido);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetPartido", new { id = partido.PartidoId }, partido);
        }

        // DELETE: api/Partidos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Partido>> DeletePartido(int id)
        {
            var partido = await _context.Partidos.FindAsync(id);
            if (partido == null)
            {
                return NotFound();
            }

            _context.Partidos.Remove(partido);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Direcciones.Partido>(partido);
        }

        private bool PartidoExists(int id)
        {
            return _context.Partidos.Any(e => e.PartidoId == id);
        }
    }
}
