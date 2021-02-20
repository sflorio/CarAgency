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
    public class ConceptosFinancierosController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public ConceptosFinancierosController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/ConceptosFinancieros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConceptoFinanciero>>> GetConceptoFinancieros()
        {
            var localidads = await _context.ConceptosFinancieros.ToListAsync<Domain.Models.Finanzas.ConceptoFinanciero>();

            return _mapper.Map<List<Domain.Models.Finanzas.ConceptoFinanciero>,List<Domain.DTO.Finanzas.ConceptoFinanciero>>(localidads);
        }

        // GET: api/ConceptosFinancieros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConceptoFinanciero>> GetConceptoFinanciero(int id)
        {
            var conceptoFinanciero = await _context.ConceptosFinancieros.FindAsync(id);

            if (conceptoFinanciero == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Finanzas.ConceptoFinanciero, Domain.DTO.Finanzas.ConceptoFinanciero>(conceptoFinanciero);
        }

        // PUT: api/ConceptosFinancieros/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConceptoFinanciero(int id, ConceptoFinanciero conceptoFinanciero)
        {
            if (id != conceptoFinanciero.ConceptoFinancieroId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Finanzas.ConceptoFinanciero>(conceptoFinanciero)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConceptoFinancieroExists(id))
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

        // POST: api/ConceptosFinancieros
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ConceptoFinanciero>> PostConceptoFinanciero(ConceptoFinanciero conceptoFinanciero)
        {
            Domain.Models.Finanzas.ConceptoFinanciero objeConceptoFinanciero = _mapper.Map<Domain.Models.Finanzas.ConceptoFinanciero>(conceptoFinanciero);

            _context.ConceptosFinancieros.Add(objeConceptoFinanciero);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetConceptoFinanciero", new { id = conceptoFinanciero.ConceptoFinancieroId }, conceptoFinanciero);
        }

        // DELETE: api/ConceptosFinancieros/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ConceptoFinanciero>> DeleteConceptoFinanciero(int id)
        {
            var conceptoFinanciero = await _context.ConceptosFinancieros.FindAsync(id);
            if (conceptoFinanciero == null)
            {
                return NotFound();
            }

            _context.ConceptosFinancieros.Remove(conceptoFinanciero);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Finanzas.ConceptoFinanciero>(conceptoFinanciero);
        }

        private bool ConceptoFinancieroExists(int id)
        {
            return _context.ConceptosFinancieros.Any(e => e.ConceptoFinancieroId == id);
        }
    }
}
