using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.BussinessLogic.Services
{
    public interface IPurchaseSevice
    {
        List<Purchase> GetList();
    }
    class PurchaseService : IPurchaseSevice
    {
        public List<Purchase> GetList()
        {
            var purchaseList = new List<Purchase>
            {
                new Purchase
                {
                    GoodId =1,
                    Amount =1,
                    date= DateTime.Now
                },

                new Purchase
                {
                    GoodId =2,
                    Amount =1,
                    date= DateTime.Now
                }
            };

            return purchaseList;
        }
    }
}
