using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class ComputerService
    {
        public List<Computer> LoadFromCsv(string filePath)
        {
            var result = new List<Computer>();

            if (!File.Exists(filePath))
                return result;

            var lines = File.ReadAllLines(filePath);
            if (lines.Length < 2)
                return result;

            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var row = line.Split(';');
                if (row.Length < 8)
                    continue;

                result.Add(new Computer
                {
                    Id = int.Parse(row[0]),
                    EvmType = row[1],
                    ManufacturerId = int.Parse(row[2]),
                    RetailerId = int.Parse(row[3]),
                    ProcessorId = int.Parse(row[4]),
                    StorageType = row[5],
                    ReleaseDate = DateTime.ParseExact(row[6], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    Price = decimal.Parse(row[7], CultureInfo.InvariantCulture)
                });
            }

            return result;
        }

        public void SaveToCsv(string filePath, List<Computer> computers)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine("Идентификатор ПК;Тип ЭВМ;Идентификатор фирмы-изготовителя;Идентификатор фирмы-реализатора;Идентификатор процессора;Тип накопителя;Дата выпуска;Цена");

            foreach (var c in computers)
            {
                sw.WriteLine(string.Join(";",
                    c.Id,
                    c.EvmType,
                    c.ManufacturerId,
                    c.RetailerId,
                    c.ProcessorId,
                    c.StorageType,
                    c.ReleaseDate.ToString("dd.MM.yyyy"),
                    c.Price.ToString(CultureInfo.InvariantCulture)
                ));
            }
        }

        public List<Computer> Add(List<Computer> computers, Computer computer)
        {
            computers.Add(computer);
            return computers;
        }

        public List<Computer> Remove(List<Computer> computers, int id)
        {
            return computers.Where(c => c.Id != id).ToList();
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
