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
    public class PaisesController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public PaisesController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Vehiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pais>>> GetPaises()
        {
            var vehiculos = await _context.Paises.ToListAsync<Domain.Models.Direcciones.Pais>();

            return _mapper.Map<List<Domain.Models.Direcciones.Pais>,List<Domain.DTO.Direcciones.Pais>>(vehiculos);
        }

        // GET: api/Vehiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pais>> GetPais(int id)
        {
            var pais = await _context.Paises.FindAsync(id);

            if (pais == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Direcciones.Pais, Domain.DTO.Direcciones.Pais>(pais);
        }

        // PUT: api/Vehiculos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPais(int id, Pais pais)
        {
            if (id != pais.PaisId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Direcciones.Pais>(pais)).State = EntityState.Modified;

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

        // POST: api/Vehiculos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pais>> PostPais(Pais pais)
        {
            Domain.Models.Direcciones.Pais objePais = _mapper.Map<Domain.Models.Direcciones.Pais>(pais);

            _context.Paises.Add(objePais);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetPais", new { id = pais.PaisId }, pais);
        }

        // DELETE: api/Vehiculos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pais>> DeletePais(int id)
        {
            var pais = await _context.Paises.FindAsync(id);
            if (pais == null)
            {
                return NotFound();
            }

            _context.Paises.Remove(pais);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Direcciones.Pais>(pais);
        }

        private bool VehiculoExists(int id)
        {
            return _context.Paises.Any(e => e.PaisId == id);
        }
    }
}
