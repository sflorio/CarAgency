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
    public class CuentasController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public CuentasController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Cuentas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cuenta>>> GetCuentas()
        {
            var cuentas = await _context.Cuentas.ToListAsync<Domain.Models.Finanzas.Cuenta>();

            return _mapper.Map<List<Domain.Models.Finanzas.Cuenta>,List<Domain.DTO.Finanzas.Cuenta>>(cuentas);
        }

        // GET: api/Cuentas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cuenta>> GetCuenta(int id)
        {
            var cuenta = await _context.Cuentas.FindAsync(id);

            if (cuenta == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Finanzas.Cuenta, Domain.DTO.Finanzas.Cuenta>(cuenta);
        }

        // PUT: api/Cuentas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuenta(int id, Cuenta cuenta)
        {
            if (id != cuenta.CuentaId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Finanzas.Cuenta>(cuenta)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuentaExists(id))
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

        // POST: api/Cuentas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cuenta>> PostCuenta(Cuenta cuenta)
        {
            Domain.Models.Finanzas.Cuenta objeCuenta = _mapper.Map<Domain.Models.Finanzas.Cuenta>(cuenta);

            _context.Cuentas.Add(objeCuenta);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetCuenta", new { id = cuenta.CuentaId }, cuenta);
        }

        // DELETE: api/Cuentas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cuenta>> DeleteCuenta(int id)
        {
            var cuenta = await _context.Cuentas.FindAsync(id);
            if (cuenta == null)
            {
                return NotFound();
            }

            _context.Cuentas.Remove(cuenta);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Finanzas.Cuenta>(cuenta);
        }

        private bool CuentaExists(int id)
        {
            return _context.Cuentas.Any(e => e.CuentaId == id);
        }
    }
}
