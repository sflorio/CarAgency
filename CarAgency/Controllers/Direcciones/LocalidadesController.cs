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
    public class LocalidadesController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public LocalidadesController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Localidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Localidad>>> GetLocalidades()
        {
            var localidads = await _context.Localidades.ToListAsync<Domain.Models.Direcciones.Localidad>();

            return _mapper.Map<List<Domain.Models.Direcciones.Localidad>,List<Domain.DTO.Direcciones.Localidad>>(localidads);
        }

        // GET: api/Localidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Localidad>> GetLocalidad(int id)
        {
            var localidad = await _context.Localidades.FindAsync(id);

            if (localidad == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Direcciones.Localidad, Domain.DTO.Direcciones.Localidad>(localidad);
        }

        // PUT: api/Localidades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalidad(int id, Localidad localidad)
        {
            if (id != localidad.LocalidadId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Direcciones.Localidad>(localidad)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalidadExists(id))
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

        // POST: api/Localidades
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Localidad>> PostLocalidad(Localidad localidad)
        {
            Domain.Models.Direcciones.Localidad objeLocalidad = _mapper.Map<Domain.Models.Direcciones.Localidad>(localidad);

            _context.Localidades.Add(objeLocalidad);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetLocalidad", new { id = localidad.LocalidadId }, localidad);
        }

        // DELETE: api/Localidades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Localidad>> DeleteLocalidad(int id)
        {
            var localidad = await _context.Direcciones.FindAsync(id);
            if (localidad == null)
            {
                return NotFound();
            }

            _context.Direcciones.Remove(localidad);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Direcciones.Localidad>(localidad);
        }

        private bool LocalidadExists(int id)
        {
            return _context.Localidades.Any(e => e.LocalidadId == id);
        }
    }
}
