using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarAgency.Data;
using Domain.DTO.Finanzas;
using AutoMapper;
namespace CarAgency.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TiposOperacionController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public TiposOperacionController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/TipoOperaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoOperacion>>> GetTipoOperaciones()
        {
            var tipoOperacions = await _context.TiposOperaciones.ToListAsync<Domain.Models.Finanzas.TipoOperacion>();

            return _mapper.Map<List<Domain.Models.Finanzas.TipoOperacion>,List<Domain.DTO.Finanzas.TipoOperacion>>(tipoOperacions);
        }

        // GET: api/TipoOperaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoOperacion>> GetTipoOperacion(int id)
        {
            var tipoOperacion = await _context.TiposOperaciones.FindAsync(id);

            if (tipoOperacion == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Finanzas.TipoOperacion, Domain.DTO.Finanzas.TipoOperacion>(tipoOperacion);
        }

        // PUT: api/TipoOperaciones/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoOperacion(int id, TipoOperacion tipoOperacion)
        {
            if (id != tipoOperacion.TipoOperacionId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Finanzas.TipoOperacion>(tipoOperacion)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoOperacionExists(id))
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

        // POST: api/TipoOperaciones
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TipoOperacion>> PostTipoOperacion(TipoOperacion tipoOperacion)
        {
            Domain.Models.Finanzas.TipoOperacion objeTipoOperacion = _mapper.Map<Domain.Models.Finanzas.TipoOperacion>(tipoOperacion);

            _context.TiposOperaciones.Add(objeTipoOperacion);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetTipoOperacion", new { id = tipoOperacion.TipoOperacionId }, tipoOperacion);
        }

        // DELETE: api/TipoOperaciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoOperacion>> DeleteTipoOperacion(int id)
        {
            var tipoOperacion = await _context.TiposOperaciones.FindAsync(id);
            if (tipoOperacion == null)
            {
                return NotFound();
            }

            _context.TiposOperaciones.Remove(tipoOperacion);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Finanzas.TipoOperacion>(tipoOperacion);
        }

        private bool TipoOperacionExists(int id)
        {
            return _context.TiposOperaciones.Any(e => e.TipoOperacionId == id);
        }
    }
}
