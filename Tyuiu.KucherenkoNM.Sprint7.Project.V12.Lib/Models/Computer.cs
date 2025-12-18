using System;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string EvmType { get; set; } 
        public int ManufacturerId { get; set; } 
        public int RetailerId { get; set; }
        public int ProcessorId { get; set; }
        public string StorageType { get; set; } 
        public DateTime ReleaseDate { get; set; } 
        public decimal Price { get; set; }  
    }
}
