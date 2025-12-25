using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

                if (!int.TryParse(p[idIndex], out int id))
                    continue;

                list.Add(new Retailer
                {
                    Id = id,
                    Name = p[nameIndex],
                    Address = p[addressIndex],
                    Phone = p[phoneIndex],
                    Note = p[noteIndex]
                });
            }

            return list;
        }

        public void SaveToCsv(string path, List<Retailer> retailers)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Идентификатор фирмы реализатора;Наименование фирмы;Адрес;Телефон;Примечание");

            foreach (var r in retailers)
            {
                sb.AppendLine($"{r.Id};{r.Name};{r.Address};{r.Phone};{r.Note}");
            }

            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }
    }
}
