using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.Direcciones;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CarAgency.Data.Seeds
{
    public class SeedDirecciones
    {
        public SeedDirecciones() {
        }

        public List<Provincia> GetProvinciasSeeds() {
            List<Provincia> provincias = new List<Provincia>();
            var path = @"C:\Proyectos\CarAgency\CarAgency\Resources\Seeds\Provincias.json";// _configuration.GetValue<string>("Resources");

            using (StreamReader reader = new StreamReader(path)) {

                string json = reader.ReadToEnd();
                provincias = JsonConvert.DeserializeObject<List<Provincia>>(json);

            }

            return provincias;
        }
    }
}
