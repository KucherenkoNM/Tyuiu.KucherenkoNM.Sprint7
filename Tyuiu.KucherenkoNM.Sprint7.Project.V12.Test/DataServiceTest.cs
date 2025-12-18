using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Test
{
    [TestClass]
    public class ComputerServiceTests
    {
        [TestMethod]
        public void AddComputer_ShouldIncreaseCount()
        {
            var service = new ComputerService();
            var computers = new List<Computer>();

            var computer = new Computer
            {
                ComputerId = 1,
                EvmType = "Ноутбук",
                ManufacturerId = 101,
                ProcessorId = 1,
                RetailerId = 201,
                Price = 75000,
                ReleaseDate = DateTime.Now
            };

            service.Add(computers, computer);

            Assert.AreEqual(1, computers.Count);
        }

        [TestMethod]
        public void SortByPrice_ShouldReturnSortedList()
        {
            var service = new ComputerService();
            var computers = new List<Computer>
            {
                new Computer { ComputerId = 1, Price = 90000 },
                new Computer { ComputerId = 2, Price = 60000 },
                new Computer { ComputerId = 3, Price = 120000 }
            };

            var sorted = service.SortByPrice(computers);

            Assert.AreEqual(60000, sorted[0].Price);
            Assert.AreEqual(120000, sorted[2].Price);
        }

        [TestMethod]
        public void AveragePrice_ShouldReturnCorrectValue()
        {
            var computers = new List<Computer>
            {
                new Computer { Price = 50000 },
                new Computer { Price = 100000 }
            };

            var average = StatisticsService.AveragePrice(computers);

            Assert.AreEqual(75000, average);
        }

        [TestMethod]
        public void CountByEvmType_ShouldGroupCorrectly()
        {
            var computers = new List<Computer>
            {
                new Computer { EvmType = "ПК" },
                new Computer { EvmType = "Ноутбук" },
                new Computer { EvmType = "Ноутбук" }
            };

            var result = ChartDataService.CountByEvmType(computers);

            Assert.AreEqual(1, result["ПК"]);
            Assert.AreEqual(2, result["Ноутбук"]);
        }
    }
}
