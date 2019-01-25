using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.BussinessLogic.Services
{
    public interface IArrival
    {
        List<Arrival> GetList();
    }
    public class ArrivalService:IArrival
    {
        
        List<Arrival> IArrival.GetList()
        {
            var arrivalList = new List<Arrival>
            {
                new Arrival
                {
                    GoodId = 1,
                    Amount = 3,
                    date = DateTime.Now

                },
                new Arrival
                {
                    GoodId = 2,
                    Amount = 5,
                    date = DateTime.Now
                }

            };
            return arrivalList;
        }
    }
}
