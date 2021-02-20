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
    public class TiposDocumentoController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public TiposDocumentoController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/TipoDocumentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoDocumento>>> GetTipoDocumentos()
        {
            var tipoDocumentos = await _context.TipoDocumentos.ToListAsync<Domain.Models.Personas.TipoDocumento>();

            return _mapper.Map<List<Domain.Models.Personas.TipoDocumento>,List<Domain.DTO.Personas.TipoDocumento>>(tipoDocumentos);
        }

        // GET: api/TipoDocumentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoDocumento>> GetTipoDocumento(int id)
        {
            var vehiculo = await _context.TipoDocumentos.FindAsync(id);

            if (vehiculo == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Personas.TipoDocumento, Domain.DTO.Personas.TipoDocumento>(vehiculo);
        }

        // PUT: api/TipoDocumentos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoDocumento(int id, TipoDocumento vehiculo)
        {
            if (id != vehiculo.TipoDocumentoId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Personas.TipoDocumento>(vehiculo)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDocumentoExists(id))
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

        // POST: api/TipoDocumentos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TipoDocumento>> PostTipoDocumento(TipoDocumento vehiculo)
        {
            Domain.Models.Personas.TipoDocumento objeTipoDocumento = _mapper.Map<Domain.Models.Personas.TipoDocumento>(vehiculo);

            _context.TipoDocumentos.Add(objeTipoDocumento);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetTipoDocumento", new { id = vehiculo.TipoDocumentoId }, vehiculo);
        }

        // DELETE: api/TipoDocumentos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoDocumento>> DeleteTipoDocumento(int id)
        {
            var vehiculo = await _context.TipoDocumentos.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            _context.TipoDocumentos.Remove(vehiculo);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Personas.TipoDocumento>(vehiculo);
        }

        private bool TipoDocumentoExists(int id)
        {
            return _context.TipoDocumentos.Any(e => e.TipoDocumentoId == id);
        }
    }
}
