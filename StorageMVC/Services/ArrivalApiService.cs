using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Storage.Services
{
    public interface IArrivalApiService
    {
        Task<List<Arrival>> GetList();
    }
    public class ArrivalApiService:IArrivalApiService
    {

    }
}