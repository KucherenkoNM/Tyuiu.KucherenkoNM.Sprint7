using System.Collections.Generic;
using System.Linq;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public class RetailerService
    {
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
