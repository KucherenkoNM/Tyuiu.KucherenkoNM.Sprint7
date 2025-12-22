using System;
using System.Collections.Generic;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class ComputerService
    {
        public List<Computer> LoadFromCsv(string filePath)
        {
            var rows = CsvService.Read(filePath);
            var result = new List<Computer>();

            foreach (var row in rows)
            {
                var computer = new Computer
                {
                    ComputerId = int.Parse(row[0]),
                    EvmType = row[1],
                    ManufacturerId = int.Parse(row[2]),
                    RetailerId = int.Parse(row[3]),
                    ProcessorId = int.Parse(row[4]),
                    StorageType = row[5],
                    ReleaseDate = DateTime.Parse(row[6]),
                    Price = decimal.Parse(row[7])
                };

                result.Add(computer);
            }

            return result;
        }

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
            return computers.Where(c => c.EvmType == evmType).ToList();
        }

        public List<Computer> SortByPrice(List<Computer> computers)
        {
            return computers.OrderBy(c => c.Price).ToList();
        }

        public List<Computer> FilterByPrice(List<Computer> computers, decimal minPrice)
        {
            return computers.Where(c => c.Price >= minPrice).ToList();
        }
    }
}
