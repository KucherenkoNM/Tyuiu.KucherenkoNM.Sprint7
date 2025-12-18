using System.Collections.Generic;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public static class ChartDataService
    {
        public static Dictionary<string, int> CountByEvmType(List<Computer> computers)
        {
            return computers
                .GroupBy(c => c.EvmType)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
