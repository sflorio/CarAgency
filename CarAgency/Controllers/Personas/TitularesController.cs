using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarAgency.Data;
using Domain.DTO.Personas;
using AutoMapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarAgency.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public PersonasController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Titulares
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetTitulares()
        {
            var personas = await _context.Personas.ToListAsync<Domain.Models.Personas.Persona>();

            return _mapper.Map<List<Domain.DTO.Personas.Persona>>(personas);
        }

        // GET: Titulares/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetTitular(int id)
        {
            var persona = await _context.Personas.FindAsync(id);

            if (persona == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.DTO.Personas.Persona>(persona);
        }

        // PUT: Personas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersona(int id, Persona persona)
        {
            if (id != persona.PersonaId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Personas.Titular>(persona)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoExists(id))
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

        // POST: Persona
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(Persona persona)
        {
            Domain.Models.Personas.Persona objeVehiculo = _mapper.Map<Domain.Models.Personas.Persona>(persona);

            _context.Personas.Add(objeVehiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersona", new { id = persona.PersonaId }, persona);
        }

        // DELETE: Persona/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Persona>> DeletePersona(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Personas.Persona>(persona);
        }

        private bool VehiculoExists(int id)
        {
            return _context.Personas.Any(e => e.PersonaId == id);
        }
    }
}
