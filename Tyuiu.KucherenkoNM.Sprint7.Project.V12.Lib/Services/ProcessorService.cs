using System.Collections.Generic;
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
            return processors.Where(p => p.ProcessorId != id).ToList();
        }
    }
}
