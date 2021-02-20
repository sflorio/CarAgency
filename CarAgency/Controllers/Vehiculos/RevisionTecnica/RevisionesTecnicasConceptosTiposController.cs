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
    public class RevisionTecnicaConceptosTiposController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public RevisionTecnicaConceptosTiposController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/RevisionTecnicaConceptosTipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RevisionTecnicaConceptoTipo>>> GetRevisionTecnicaConceptosTipos()
        {
            var revisionTecnicaConceptosTipos = await _context.RevisionTecnicaConceptoTipos.ToListAsync<Domain.Models.Vehiculos.RevisionTecnicaConceptoTipo>();

            return _mapper.Map<List<Domain.DTO.Vehiculos.RevisionTecnicaConceptoTipo>>(revisionTecnicaConceptosTipos);
        }

        // GET: api/RevisionTecnicaConceptosTipos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RevisionTecnicaConceptoTipo>> GetRevisionTecnicaConceptoTipo(int id)
        {
            var revisionTecnicaConceptoTipos = await _context.RevisionTecnicaConceptoTipos.FindAsync(id);

            if (revisionTecnicaConceptoTipos == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.DTO.Vehiculos.RevisionTecnicaConceptoTipo>(revisionTecnicaConceptoTipos);
        }

        // PUT: api/RevisionTecnicaConceptosTipos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRevisionTecnicaConceptoTipo(int id, RevisionTecnicaConceptoTipo revisionTecnicaConceptoTipo)
        {
            if (id != revisionTecnicaConceptoTipo.RevisionTecnicaConceptoTipoId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Vehiculos.RevisionTecnicaConceptoTipo>(revisionTecnicaConceptoTipo)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RevisionTecnicaConceptoTipoExists(id))
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

        // POST: api/RevisionTecnicaConceptosTipos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RevisionTecnicaConceptoTipo>> PostRevisionTecnicaConceptoTipo(RevisionTecnicaConceptoTipo revisionTecnicaConcepto)
        {
            Domain.Models.Vehiculos.RevisionTecnicaConceptoTipo objRevisionTecnicaConceptoTipo = _mapper.Map<Domain.Models.Vehiculos.RevisionTecnicaConceptoTipo>(revisionTecnicaConcepto);

            _context.RevisionTecnicaConceptoTipos.Add(objRevisionTecnicaConceptoTipo);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetRevisionTecnicaConceptoTipo", new { id = revisionTecnicaConcepto.RevisionTecnicaConceptoTipoId }, revisionTecnicaConcepto);
        }

        // DELETE: api/RevisionTecnicaConceptosTipos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RevisionTecnicaConceptoTipo>> DeleteRevisionTecnicaConceptoTipo(int id)
        {
            var revisionTecnicaConceptoTipo = await _context.RevisionTecnicaConceptoTipos.FindAsync(id);
            if (revisionTecnicaConceptoTipo == null)
            {
                return NotFound();
            }

            _context.RevisionTecnicaConceptoTipos.Remove(revisionTecnicaConceptoTipo);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Vehiculos.RevisionTecnicaConceptoTipo>(revisionTecnicaConceptoTipo);
        }

        private bool RevisionTecnicaConceptoTipoExists(int id)
        {
            return _context.RevisionTecnicaConceptoTipos.Any(e => e.RevisionTecnicaConceptoTipoId == id);
        }
    }
}
