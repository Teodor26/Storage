using Storage.Models.DataModels;
using System;
using System.Collections.Generic;

namespace Storage.BussinessLogic.Services
{
    public interface IPurchaseService
    {
        List<Purchase> GetList();
    }
    public class PurchaseService : IPurchaseService
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
