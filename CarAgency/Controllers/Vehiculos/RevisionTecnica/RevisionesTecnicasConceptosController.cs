using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarAgency.Data;
using Domain.DTO.Vehiculos;
using AutoMapper;
namespace CarAgency.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RevisionTecnicaConceptosController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public RevisionTecnicaConceptosController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/RevisionTecnicaConceptos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RevisionTecnicaConcepto>>> GetRevisionTecnicaConceptos()
        {
            var revisionTecnicaConceptos = await _context.RevisionTecnicaConceptos.ToListAsync<Domain.Models.Vehiculos.RevisionTecnicaConcepto>();

            return _mapper.Map<List<Domain.Models.Vehiculos.RevisionTecnicaConcepto>,List<Domain.DTO.Vehiculos.RevisionTecnicaConcepto>>(revisionTecnicaConceptos);
        }

        // GET: api/RevisionTecnicaConceptos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RevisionTecnicaConcepto>> GetRevisionTecnica(int id)
        {
            var revisionTecnicaConcepto = await _context.RevisionTecnicaConceptos.FindAsync(id);

            if (revisionTecnicaConcepto == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Vehiculos.RevisionTecnicaConcepto, Domain.DTO.Vehiculos.RevisionTecnicaConcepto>(revisionTecnicaConcepto);
        }

        // PUT: api/RevisionTecnicaConceptos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRevisionTecnica(int id, RevisionTecnicaConcepto revisionTecnicaConcepto)
        {
            if (id != revisionTecnicaConcepto.RevisionTecnicaConceptoId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Vehiculos.RevisionTecnicaConcepto>(revisionTecnicaConcepto)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RevisionTecnicaExists(id))
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

        // POST: api/RevisionTecnicaConceptos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RevisionTecnica>> PostRevisionTecnica(RevisionTecnicaConcepto revisionTecnicaConcepto)
        {
            Domain.Models.Vehiculos.RevisionTecnicaConcepto objRevisionTecnica = _mapper.Map<Domain.Models.Vehiculos.RevisionTecnicaConcepto>(revisionTecnicaConcepto);

            _context.RevisionTecnicaConceptos.Add(objRevisionTecnica);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetRevisionTecnicaConcepto", new { id = revisionTecnicaConcepto.RevisionTecnicaConceptoId }, revisionTecnicaConcepto);
        }

        // DELETE: api/RevisionTecnicaConceptos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RevisionTecnicaConcepto>> DeleteRevisionTecnica(int id)
        {
            var revisionTecnicaConcepto = await _context.RevisionTecnicaConceptos.FindAsync(id);
            if (revisionTecnicaConcepto == null)
            {
                return NotFound();
            }

            _context.RevisionTecnicaConceptos.Remove(revisionTecnicaConcepto);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Vehiculos.RevisionTecnicaConcepto>(revisionTecnicaConcepto);
        }

        private bool RevisionTecnicaExists(int id)
        {
            return _context.RevisionTecnicaConceptos.Any(e => e.RevisionTecnicaConceptoId == id);
        }
    }
}
