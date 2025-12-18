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
            => computers.Min(c => c.Price);

        public static decimal MaxPrice(List<Computer> computers)
            => computers.Max(c => c.Price);

        public static decimal AveragePrice(List<Computer> computers)
            => computers.Average(c => c.Price);

        public static decimal SumPrice(List<Computer> computers)
            => computers.Sum(c => c.Price);
    }
}
