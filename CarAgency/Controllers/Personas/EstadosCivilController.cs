using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarAgency.Data;
using Domain.DTO.Personas;
using AutoMapper;
namespace CarAgency.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EstadosCivilesController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public EstadosCivilesController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/EstadosCiviles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoCivil>>> GetEstadosCiviles()
        {
            var estadosCiviles = await _context.EstadosCiviles.ToListAsync<Domain.Models.Personas.EstadoCivil>();

            return _mapper.Map<List<Domain.Models.Personas.EstadoCivil>,List<Domain.DTO.Personas.EstadoCivil>>(estadosCiviles);
        }

        // GET: api/EstadosCiviles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoCivil>> GetEstadoCivil(int id)
        {
            var estadoCivil = await _context.EstadosCiviles.FindAsync(id);

            if (estadoCivil == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Personas.EstadoCivil, Domain.DTO.Personas.EstadoCivil>(estadoCivil);
        }

        // PUT: api/EstadosCiviles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoCivil(int id, EstadoCivil estadoCivil)
        {
            if (id != estadoCivil.EstadoCivilId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Personas.EstadoCivil>(estadoCivil)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoCivilExists(id))
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

        // POST: api/EstadosCiviles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EstadoCivil>> PostEstadoCivil(EstadoCivil estadoCivil)
        {
            Domain.Models.Personas.EstadoCivil objeEstadoCivil = _mapper.Map<Domain.Models.Personas.EstadoCivil>(estadoCivil);

            _context.EstadosCiviles.Add(objeEstadoCivil);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetEstadoCivil", new { id = estadoCivil.EstadoCivilId }, estadoCivil);
        }

        // DELETE: api/EstadosCiviles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EstadoCivil>> DeleteEstadoCivil(int id)
        {
            var estadoCivil = await _context.EstadosCiviles.FindAsync(id);
            if (estadoCivil == null)
            {
                return NotFound();
            }

            _context.EstadosCiviles.Remove(estadoCivil);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Personas.EstadoCivil>(estadoCivil);
        }

        private bool EstadoCivilExists(int id)
        {
            return _context.EstadosCiviles.Any(e => e.EstadoCivilId == id);
        }
    }
}
