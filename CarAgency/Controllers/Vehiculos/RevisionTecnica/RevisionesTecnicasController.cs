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
    public class RevisionesTecnicasController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public RevisionesTecnicasController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/RevisionesTecnicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RevisionTecnica>>> GetRevisionesTecnicas()
        {
            var revisionTecnicas = await _context.RevisionesTecnicas.ToListAsync<Domain.Models.Vehiculos.RevisionTecnica>();

            return _mapper.Map<List<Domain.Models.Vehiculos.RevisionTecnica>,List<Domain.DTO.Vehiculos.RevisionTecnica>>(revisionTecnicas);
        }

        // GET: api/RevisionesTecnicas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RevisionTecnica>> GetRevisionTecnica(int id)
        {
            var revisionTecnica = await _context.RevisionesTecnicas.FindAsync(id);

            if (revisionTecnica == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Vehiculos.RevisionTecnica, Domain.DTO.Vehiculos.RevisionTecnica>(revisionTecnica);
        }

        // PUT: api/RevisionesTecnicas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRevisionTecnica(int id, RevisionTecnica revisionTecnica)
        {
            if (id != revisionTecnica.RevisionTecnicaId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Vehiculos.RevisionTecnica>(revisionTecnica)).State = EntityState.Modified;

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

        // POST: api/RevisionesTecnicas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RevisionTecnica>> PostRevisionTecnica(RevisionTecnica revisionTecnica)
        {
            Domain.Models.Vehiculos.RevisionTecnica objRevisionTecnica = _mapper.Map<Domain.Models.Vehiculos.RevisionTecnica>(revisionTecnica);

            _context.RevisionesTecnicas.Add(objRevisionTecnica);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetRevisionTecnica", new { id = revisionTecnica.RevisionTecnicaId }, revisionTecnica);
        }

        // DELETE: api/RevisionesTecnicas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RevisionTecnica>> DeleteRevisionTecnica(int id)
        {
            var revisionTecnica = await _context.RevisionesTecnicas.FindAsync(id);
            if (revisionTecnica == null)
            {
                return NotFound();
            }

            _context.RevisionesTecnicas.Remove(revisionTecnica);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Vehiculos.RevisionTecnica>(revisionTecnica);
        }

        private bool RevisionTecnicaExists(int id)
        {
            return _context.RevisionesTecnicas.Any(e => e.RevisionTecnicaId == id);
        }
    }
}
