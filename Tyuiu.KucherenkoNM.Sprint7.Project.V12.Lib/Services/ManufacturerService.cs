using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenкоNM.Sprint7.Project.V12.Lib.Services
{
    public class ManufacturerService
    {
        public List<Manufacturer> LoadFromCsv(string path)
        {
            var list = new List<Manufacturer>();
            var lines = File.ReadAllLines(path);

            var headers = lines[0].Split(';').ToList();

            int idIndex = headers.IndexOf("Идентификатор фирмы-изготовителя");
            int nameIndex = headers.IndexOf("Наименование фирмы");
            int countryIndex = headers.IndexOf("Страна");

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                var p = lines[i].Split(';');

                if (p.Length <= countryIndex) continue;

                list.Add(new Manufacturer
                {
                    Id = int.Parse(p[idIndex]),
                    Name = p[nameIndex],
                    Country = p[countryIndex]
                });
            }

            return list;
        }

        public void SaveToCsv(List<Manufacturer> manufacturers, string path)
        {
            var lines = new List<string>
            {
                "Идентификатор фирмы-изготовителя;Наименование фирмы;Страна"
            };

            foreach (var m in manufacturers)
            {
                lines.Add($"{m.Id};{m.Name};{m.Country}");
            }

            File.WriteAllLines(path, lines);
        }
    }
}
