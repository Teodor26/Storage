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

    class CommodityService : ICommodity
    {
        public List<Commodity> GetList()
        {
           
        }
    }
}
