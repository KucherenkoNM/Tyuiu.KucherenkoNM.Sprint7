using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class ProcessorService
    {
        public List<Processor> LoadFromCsv(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var result = new List<Processor>();

            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var row = line.Split(';');

                result.Add(new Processor
                {
                    Id = int.Parse(row[0]),
                    Name = row[1],
                    Manufacturer = row[2],
                    Cores = int.Parse(row[3])
                });
            }

            return result;
        }

        public List<Processor> Filter(
            List<Processor> source,
            string searchText,
            string manufacturer,
            int? coresFrom,
            int? coresTo)
        {
            var query = source.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var text = searchText.ToLower();
                query = query.Where(p =>
                    p.Name.ToLower().Contains(text) ||
                    p.Manufacturer.ToLower().Contains(text) ||
                    p.Cores.ToString().Contains(text));
            }

            if (!string.IsNullOrWhiteSpace(manufacturer))
                query = query.Where(p => p.Manufacturer == manufacturer);

            if (coresFrom.HasValue)
                query = query.Where(p => p.Cores >= coresFrom.Value);

            if (coresTo.HasValue)
                query = query.Where(p => p.Cores <= coresTo.Value);

            return query.ToList();
        }
    }
}
