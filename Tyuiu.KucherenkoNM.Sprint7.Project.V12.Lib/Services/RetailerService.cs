using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class RetailerService
    {
        public List<Retailer> LoadFromCsv(string path)
        {
            var list = new List<Retailer>();
            var lines = File.ReadAllLines(path);

            if (lines.Length < 2)
                return list;

            var headers = lines[0].Split(';');

            int idIndex = headers.ToList().IndexOf("Идентификатор фирмы реализатора");
            int nameIndex = headers.ToList().IndexOf("Наименование фирмы");
            int addressIndex = headers.ToList().IndexOf("Адрес");
            int phoneIndex = headers.ToList().IndexOf("Телефон");
            int noteIndex = headers.ToList().IndexOf("Примечание");

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var p = lines[i].Split(';');

                if (p.Length <= new[] { idIndex, nameIndex, addressIndex, phoneIndex, noteIndex }.Max())
                    continue;

                if (!int.TryParse(p[idIndex], out int id))
                    continue;

                list.Add(new Retailer
                {
                    RetailerId = id,
                    Name = p[nameIndex],
                    Address = p[addressIndex],
                    Phone = p[phoneIndex],
                    Note = p[noteIndex]
                });
            }

            return list;
        }

        public List<Retailer> Add(List<Retailer> retailers, Retailer retailer)
        {
            retailers.Add(retailer);
            return retailers;
        }

        public List<Retailer> Remove(List<Retailer> retailers, int id)
        {
            return retailers.Where(r => r.RetailerId != id).ToList();
        }
    }
}
