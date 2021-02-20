using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Domain.DTO.Vehiculos;
using Microsoft.EntityFrameworkCore;
using CarAgency.Data;

namespace CarAgency.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProcedenciaController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public ProcedenciaController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Procedencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Procedencia>>> GetProcedencia()
        {
            var Procedencia = await _context.Procedencias.ToListAsync<Domain.Models.Vehiculos.Procedencia>();

            return _mapper.Map<List<Domain.Models.Vehiculos.Procedencia>, List<Domain.DTO.Vehiculos.Procedencia>>(Procedencia);
        }

        // GET: api/Procedencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Procedencia>> GetVehiculo(int id)
        {
            var procedencia = await _context.Procedencias.FindAsync(id);

            if (procedencia == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Vehiculos.Procedencia, Domain.DTO.Vehiculos.Procedencia>(procedencia);
        }

        // PUT: api/Procedencia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculo(int id, Procedencia procedencia)
        {
            if (id != procedencia.ProcedenciaId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Vehiculos.Procedencia>(procedencia)).State = EntityState.Modified;

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

        // POST: api/Procedencia
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Procedencia>> PostVehiculo(Procedencia procedencia)
        {
            Domain.Models.Vehiculos.Procedencia objeVehiculo = _mapper.Map<Domain.Models.Vehiculos.Procedencia>(procedencia);

            _context.Procedencias.Add(objeVehiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProcedencia", new { id = procedencia.ProcedenciaId }, procedencia);
        }

        // DELETE: api/Procedencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Procedencia>> DeleteVehiculo(int id)
        {
            var procedencia = await _context.Procedencias.FindAsync(id);
            if (procedencia == null)
            {
                return NotFound();
            }

            _context.Procedencias.Remove(procedencia);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Vehiculos.Procedencia>(procedencia);
        }

        private bool VehiculoExists(int id)
        {
            return _context.Procedencias.Any(e => e.ProcedenciaId == id);
        }
    }
}
