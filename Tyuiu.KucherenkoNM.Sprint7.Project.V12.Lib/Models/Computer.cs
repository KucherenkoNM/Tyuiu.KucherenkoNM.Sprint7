namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string EvmType { get; set; }
        public int ManufacturerId { get; set; }
        public int RetailerId { get; set; }
        public int ProcessorId { get; set; }
        public string StorageType { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }
}
