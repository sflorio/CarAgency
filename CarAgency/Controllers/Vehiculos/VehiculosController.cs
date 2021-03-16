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
using Domain.Models.Personas;
using Domain.Models;
namespace CarAgency.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private readonly CarAgencyDBContext _context;
        private readonly IMapper _mapper;
        public VehiculosController(CarAgencyDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Vehiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculos()
        {
            var vehiculos = await _context.Vehiculos.ToListAsync<Domain.Models.Vehiculos.Vehiculo>();

            return _mapper.Map<List<Domain.Models.Vehiculos.Vehiculo>,List<Domain.DTO.Vehiculos.Vehiculo>>(vehiculos);
        }

        [HttpGet("list-view/{page}/{quantity}")]
        public async Task<ActionResult<IEnumerable<VehiculoViewDTO>>> GetListViewVehiculos(int page, int quantity)
        {
            var vehiculos = await _context.Vehiculos
                                            .Include(e => e.Procedencia)
                                            .Include(e => e.Marca)
                                            .Include( e => e.Modelo)
                                            .Include(e => e.Titular)
                                            .Skip( ( page -1 ) * quantity)
                                            .Take(quantity)
                                            .OrderByDescending(e => e.VehiculoId)
                                            .Where(e=> e.Active == true )
                                            .ToListAsync<Domain.Models.Vehiculos.Vehiculo>();

            return _mapper.Map<List<Domain.DTO.Vehiculos.VehiculoViewDTO>>(vehiculos);
        }

        // GET: api/Vehiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiculo>> GetVehiculo(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);

            if (vehiculo == null)
            {
                return NotFound();
            }

            return _mapper.Map<Domain.Models.Vehiculos.Vehiculo, Domain.DTO.Vehiculos.Vehiculo>(vehiculo);
        }

        // PUT: api/Vehiculos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculo(int id, Vehiculo vehiculo)
        {
            if (id != vehiculo.VehiculoId)
            {
                return BadRequest();
            }

            _context.Entry(_mapper.Map<Domain.DTO.Vehiculos.Vehiculo>(vehiculo)).State = EntityState.Modified;

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
        public async Task<ActionResult<Vehiculo>> PostVehiculo(Vehiculo vehiculo)
        {
            Domain.Models.Vehiculos.Vehiculo objeVehiculo = _mapper.Map<Domain.Models.Vehiculos.Vehiculo>(vehiculo);

            var marca = await _context.Marcas.FindAsync(objeVehiculo.Marca.MarcaId);
            var modelo = await _context.Modelos.FindAsync(objeVehiculo.Modelo.ModeloId);
            var procedencia = await _context.Procedencias.FindAsync(objeVehiculo.Procedencia.ProcedenciaId);

            objeVehiculo.Marca = marca;
            objeVehiculo.Modelo = modelo;
            objeVehiculo.Procedencia = procedencia;

            var pais = await _context.Paises.FindAsync(objeVehiculo.Titular.Direccion.Pais.PaisId);
            var provinicia = await _context.Provincias.FindAsync(objeVehiculo.Titular.Direccion.Provincia.ProvinciaId);
            var departamento = await _context.Partidos.FindAsync(objeVehiculo.Titular.Direccion.Partido.PartidoId);
            var localidad = await _context.Localidades.FindAsync(objeVehiculo.Titular.Direccion.Localidad.LocalidadId);

            
            objeVehiculo.Titular.Direccion.Pais = pais;
            objeVehiculo.Titular.Direccion.Provincia = provinicia;
            objeVehiculo.Titular.Direccion.Partido = departamento;
            objeVehiculo.Titular.Direccion.Localidad = localidad;
            
            var usuario = "seba";
            objeVehiculo.Titular.InitializeAddProperties(usuario);
            objeVehiculo.InitializeAddProperties(usuario);


            _context.Personas.Add((Persona)objeVehiculo.Titular);
            _context.Vehiculos.Add(objeVehiculo);
            
            await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetVehiculo", new { id = vehiculo.VehiculoId }, vehiculo);
        }

        // DELETE: api/Vehiculos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vehiculo>> DeleteVehiculo(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            _context.Vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();

            return _mapper.Map<Domain.DTO.Vehiculos.Vehiculo>(vehiculo);
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculos.Any(e => e.VehiculoId == id);
        }
    }
}
