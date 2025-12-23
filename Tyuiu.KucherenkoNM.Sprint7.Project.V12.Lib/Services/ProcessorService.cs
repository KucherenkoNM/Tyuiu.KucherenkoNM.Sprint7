using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class ProcessorService
    {
        public List<Processor> Add(List<Processor> processors, Processor processor)
        {
            processors.Add(processor);
            return processors;
        }

        public List<Processor> Remove(List<Processor> processors, int id)
        {
            return processors.Where(p => p.Id != id).ToList();
        }

        public List<Processor> LoadFromCsv(string path)
        {
            var list = new List<Processor>();
            var lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++)
            {
                var p = lines[i].Split(';');

                list.Add(new Processor
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    Manufacturer = p[2],
                    Cores = int.Parse(p[3])
                });
            }

            return list;
        }
    }
}
