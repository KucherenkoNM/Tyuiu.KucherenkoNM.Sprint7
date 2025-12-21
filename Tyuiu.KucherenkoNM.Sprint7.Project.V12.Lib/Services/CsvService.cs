using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public static class CsvService
    {
        public static List<string[]> Read(string filePath)
        {
            return File.ReadAllLines(filePath)
                .Skip(1)
                .Select(line => line.Split(','))
                .ToList();
        }

        public static void Write(string filePath, string header, List<string> lines)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine(header);

            foreach (var line in lines)
                writer.WriteLine(line);
        }
    }
}
