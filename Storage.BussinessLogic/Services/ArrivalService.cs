using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.BussinessLogic.Services
{
    public interface IArrivalService
    {
        List<Arrival> GetList();
    }
    public class ArrivalService: IArrivalService
    {
        
        List<Arrival> IArrivalService.GetList()
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
