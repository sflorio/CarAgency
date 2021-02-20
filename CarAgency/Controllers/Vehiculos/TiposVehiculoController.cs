using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarAgency.Data;
using Domain.DTO.Vehiculos;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace CarAgency.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TiposVehiculoController : ControllerBase
    {

        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public TiposVehiculoController(CarAgencyDBContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }


        // GET: api/TipoVehiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoVehiculo>>> GetTipoVehiculos()
        {
            var response = await _context.TipoVehiculos.ToListAsync();

            return _mapper.Map<List<Domain.DTO.Vehiculos.TipoVehiculo>>(response);
        }

        // GET: api/TipoVehiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoVehiculo>> GetTipoVehiculo(int id)
        {
            var TipoVehiculo = await _context.TipoVehiculos.FindAsync(id);

            if (TipoVehiculo == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.DTO.Vehiculos.TipoVehiculo>(TipoVehiculo);
        }

        // PUT: api/TipoVehiculos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoVehiculo(int id, TipoVehiculo TipoVehiculo)
        {
            if (id != TipoVehiculo.TipoVehiculoId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Vehiculos.TipoVehiculo>(TipoVehiculo)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoVehiculoExists(id))
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

        // POST: api/TipoVehiculos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TipoVehiculo>> PostTipoVehiculo(TipoVehiculo TipoVehiculo)
        {
            var oTipoVehiculo = _mapper.Map<Domain.Models.Vehiculos.TipoVehiculo>(TipoVehiculo);
            _context.TipoVehiculos.Add(oTipoVehiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoVehiculo", new { id = TipoVehiculo.TipoVehiculoId }, oTipoVehiculo);
        }

        // DELETE: api/TipoVehiculos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoVehiculo>> DeleteTipoVehiculo(int id)
        {
            var TipoVehiculo = await _context.TipoVehiculos.FindAsync(id);
            if (TipoVehiculo == null)
            {
                return NotFound();
            }

            _context.TipoVehiculos.Remove(TipoVehiculo);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Vehiculos.TipoVehiculo>(TipoVehiculo);
        }

        private bool TipoVehiculoExists(int id)
        {
            return _context.TipoVehiculos.Any(e => e.TipoVehiculoId == id);
        }
    }
}
