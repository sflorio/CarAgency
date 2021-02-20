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
    public class DireccionesController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public DireccionesController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Direccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Direccion>>> GetDireccions()
        {
            var vehiculos = await _context.Direcciones.ToListAsync<Domain.Models.Direcciones.Direccion>();

            return _mapper.Map<List<Domain.Models.Direcciones.Direccion>,List<Domain.DTO.Direcciones.Direccion>>(vehiculos);
        }

        // GET: api/Direccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Direccion>> GetDireccion(int id)
        {
            var direccion = await _context.Direcciones.FindAsync(id);

            if (direccion == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Direcciones.Direccion, Domain.DTO.Direcciones.Direccion>(direccion);
        }

        // PUT: api/Direccions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDireccion(int id, Direccion direccion)
        {
            if (id != direccion.DireccionId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Direcciones.Direccion>(direccion)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DireccionExists(id))
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

        // POST: api/Direccions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Direccion>> PostDireccion(Direccion direccion)
        {
            Domain.Models.Direcciones.Direccion objeDireccion = _mapper.Map<Domain.Models.Direcciones.Direccion>(direccion);

            _context.Direcciones.Add(objeDireccion);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetDireccion", new { id = direccion.DireccionId }, direccion);
        }

        // DELETE: api/Direccions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Direccion>> DeleteDireccion(int id)
        {
            var direccion = await _context.Direcciones.FindAsync(id);
            if (direccion == null)
            {
                return NotFound();
            }

            _context.Direcciones.Remove(direccion);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Direcciones.Direccion>(direccion);
        }

        private bool DireccionExists(int id)
        {
            return _context.Direcciones.Any(e => e.DireccionId == id);
        }
    }
}
