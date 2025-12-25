#nullable disable
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class DataManager
    {

        public List<Computer> Computers { get; } = new();
        public List<Processor> Processors { get; } = new();
        public List<Manufacturer> Manufacturers { get; } = new();
        public List<Retailer> Retailers { get; } = new();

        public string ComputersPath { get; set; }
        public string ProcessorsPath { get; set; }
        public string ManufacturersPath { get; set; }
        public string RetailersPath { get; set; }

        int NewId(IEnumerable<int> ids) => ids.Any() ? ids.Max() + 1 : 1;

        public void LoadAll()
        {
            if (!string.IsNullOrWhiteSpace(ComputersPath)) LoadComputers(ComputersPath);
            if (!string.IsNullOrWhiteSpace(ProcessorsPath)) LoadProcessors(ProcessorsPath);
            if (!string.IsNullOrWhiteSpace(ManufacturersPath)) LoadManufacturers(ManufacturersPath);
            if (!string.IsNullOrWhiteSpace(RetailersPath)) LoadRetailers(RetailersPath);
        }

        public void SaveAll()
        {
            if (!string.IsNullOrWhiteSpace(ComputersPath)) SaveComputers(ComputersPath);
            if (!string.IsNullOrWhiteSpace(ProcessorsPath)) SaveProcessors(ProcessorsPath);
            if (!string.IsNullOrWhiteSpace(ManufacturersPath)) SaveManufacturers(ManufacturersPath);
            if (!string.IsNullOrWhiteSpace(RetailersPath)) SaveRetailers(RetailersPath);
        }

        public void LoadComputers(string path)
        {
            ComputersPath = path;
            Computers.Clear();
            if (!File.Exists(path)) return;

            foreach (var line in File.ReadAllLines(path).Skip(1))
            {
                var p = line.Split(';');
                if (p.Length < 8) continue;

                Computers.Add(new Computer
                {
                    Id = int.Parse(p[0]),
                    EvmType = p[1],
                    ManufacturerId = int.Parse(p[2]),
                    RetailerId = int.Parse(p[3]),
                    ProcessorId = int.Parse(p[4]),
                    StorageType = p[5],
                    ReleaseDate = DateTime.Parse(p[6]),
                    Price = decimal.Parse(p[7], CultureInfo.InvariantCulture)
                });
            }
        }

        public void SaveComputers(string path)
        {
            ComputersPath = path;
            File.WriteAllLines(path,
                new[] { "Id;EvmType;ManufacturerId;RetailerId;ProcessorId;StorageType;ReleaseDate;Price" }
                .Concat(Computers.Select(c =>
                    $"{c.Id};{c.EvmType};{c.ManufacturerId};{c.RetailerId};{c.ProcessorId};{c.StorageType};{c.ReleaseDate:dd.MM.yyyy};{c.Price.ToString(CultureInfo.InvariantCulture)}")));
        }

        public void LoadProcessors(string path)
        {
            ProcessorsPath = path;
            Processors.Clear();
            if (!File.Exists(path)) return;

            foreach (var line in File.ReadAllLines(path).Skip(1))
            {
                var p = line.Split(';');
                if (p.Length < 4) continue;

                Processors.Add(new Processor
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    Manufacturer = p[2],
                    Cores = int.Parse(p[3])
                });
            }
        }

        public void SaveProcessors(string path)
        {
            ProcessorsPath = path;
            File.WriteAllLines(path,
                new[] { "Id;Name;Manufacturer;Cores" }
                .Concat(Processors.Select(p =>
                    $"{p.Id};{p.Name};{p.Manufacturer};{p.Cores}")));
        }

        public void LoadManufacturers(string path)
        {
            ManufacturersPath = path;
            Manufacturers.Clear();
            if (!File.Exists(path)) return;

            foreach (var line in File.ReadAllLines(path).Skip(1))
            {
                var p = line.Split(';');
                if (p.Length < 3) continue;

                Manufacturers.Add(new Manufacturer
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    Country = p[2]
                });
            }
        }

        public void SaveManufacturers(string path)
        {
            ManufacturersPath = path;
            File.WriteAllLines(path,
                new[] { "Id;Name;Country" }
                .Concat(Manufacturers.Select(m =>
                    $"{m.Id};{m.Name};{m.Country}")));
        }

        public List<Retailer> LoadRetailers(string path)
        {
            RetailersPath = path;
            Retailers.Clear();
            if (!File.Exists(path)) return Retailers;

            foreach (var line in File.ReadAllLines(path).Skip(1))
            {
                var p = line.Split(';');
                if (p.Length < 5) continue;

                Retailers.Add(new Retailer
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    Address = p[2],
                    Phone = p[3],
                    Note = p[4]
                });
            }
            return Retailers;
        }

        public void SaveRetailers(string path)
        {
            RetailersPath = path;
            File.WriteAllLines(path,
                new[] { "Id;Name;Address;Phone;Note" }
                .Concat(Retailers.Select(r =>
                    $"{r.Id};{r.Name};{r.Address};{r.Phone};{r.Note}")));
        }
    }
}
