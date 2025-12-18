using System;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }       // идентификатор ПК
        public string EvmType { get; set; }        // тип ЭВМ
        public int ManufacturerId { get; set; }    // связь с производителем
        public int RetailerId { get; set; }        // связь с реализатором
        public int ProcessorId { get; set; }       // связь с процессором
        public string StorageType { get; set; }    // тип накопителя
        public DateTime ReleaseDate { get; set; }  // дата выпуска
        public decimal Price { get; set; }         // цена
    }
}
