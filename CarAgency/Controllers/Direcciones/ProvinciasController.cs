﻿using System;
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
    public class ProvinciasController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public ProvinciasController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Provincias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincia>>> GetProvincias()
        {
            var provincias = await _context.Provincias.ToListAsync<Domain.Models.Direcciones.Provincia>();

            return _mapper.Map<List<Domain.Models.Direcciones.Provincia>,List<Domain.DTO.Direcciones.Provincia>>(provincias);
        }

        // GET: api/Provincias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provincia>> GetProvincia(int id)
        {
            var provincia = await _context.Provincias.FindAsync(id);

            if (provincia == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Direcciones.Provincia, Domain.DTO.Direcciones.Provincia>(provincia);
        }

        // PUT: api/Provincias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvincia(int id, Provincia provincia)
        {
            if (id != provincia.ProvinciaId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Direcciones.Provincia>(provincia)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinciaExists(id))
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

        // POST: api/Provincias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Provincia>> PostProvincia(Provincia provincia)
        {
            Domain.Models.Direcciones.Provincia objeProvincia = _mapper.Map<Domain.Models.Direcciones.Provincia>(provincia);

            _context.Provincias.Add(objeProvincia);
             await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetProvincia", new { id = provincia.ProvinciaId }, provincia);
        }

        // DELETE: api/Provincias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Provincia>> DeleteProvincia(int id)
        {
            var provincia = await _context.Provincias.FindAsync(id);
            if (provincia == null)
            {
                return NotFound();
            }

            _context.Provincias.Remove(provincia);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Direcciones.Provincia>(provincia);
        }

        private bool ProvinciaExists(int id)
        {
            return _context.Provincias.Any(e => e.ProvinciaId == id);
        }
    }
}
