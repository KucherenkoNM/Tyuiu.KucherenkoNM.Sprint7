using System.Collections.Generic;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class ManufacturerService
    {
        public List<Manufacturer> Add(List<Manufacturer> manufacturers, Manufacturer manufacturer)
        {
            manufacturers.Add(manufacturer);
            return manufacturers;
        }

        public List<Manufacturer> Remove(List<Manufacturer> manufacturers, int id)
        {
            return manufacturers.Where(m => m.ManufacturerId != id).ToList();
        }
    }
}
