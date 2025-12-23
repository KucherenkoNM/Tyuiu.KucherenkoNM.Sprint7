using System.Collections.Generic;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public static class StatisticsService
    {
        public static int Count(List<Computer> computers)
            => computers.Count;

        public static decimal MinPrice(List<Computer> computers)
            => computers.Any() ? computers.Min(c => c.Price) : 0;

        public static decimal MaxPrice(List<Computer> computers)
            => computers.Any() ? computers.Max(c => c.Price) : 0;

        public static decimal AveragePrice(List<Computer> computers)
            => computers.Any() ? computers.Average(c => c.Price) : 0;

        public static decimal SumPrice(List<Computer> computers)
            => computers.Any() ? computers.Sum(c => c.Price) : 0;
    }
}
