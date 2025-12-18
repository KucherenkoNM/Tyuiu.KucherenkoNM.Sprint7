using System.Collections.Generic;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class ComputerService
    {
        public List<Computer> Add(List<Computer> computers, Computer computer)
        {
            computers.Add(computer);
            return computers;
        }

        public List<Computer> Remove(List<Computer> computers, int computerId)
        {
            return computers.Where(c => c.ComputerId != computerId).ToList();
        }

        public List<Computer> SearchByType(List<Computer> computers, string evmType)
        {
            return computers
                .Where(c => c.EvmType == evmType)
                .ToList();
        }

        public List<Computer> SortByPrice(List<Computer> computers)
        {
            return computers
                .OrderBy(c => c.Price)
                .ToList();
        }

        public List<Computer> FilterByPrice(List<Computer> computers, decimal minPrice)
        {
            return computers
                .Where(c => c.Price >= minPrice)
                .ToList();
        }
    }
}
