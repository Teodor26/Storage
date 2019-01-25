using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.BussinessLogic.Services
{

    public interface ICommodity
    {
        List<Commodity> GetList();
    }

   public class CommodityService : ICommodity
    {
        public List<Commodity> GetList()
        {
            var productList = new List<Commodity>
            {
                new Commodity
                {
                    Id = 1,
                    Name = "Potatoes"
                },
                new Commodity
                {
                    Id =2,
                    Name = "Apple"
                }
            };

            return productList;
        }
    }
}
