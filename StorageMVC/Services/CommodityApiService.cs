using StorageMVC.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Storage.Services
{
    public interface ICommodityApiSrvice
    {
        Task<List<Commodity>> Getlist();
    }
    public class CommodityApiService:ICommodityApiSrvice
    {

        public async Task<List<Commodity>> Getlist()
        {
            HttpClient client = new HttpClient();

            string apiEndpoint = Properties.Settings.Default.ApiEndpoint;

            client.BaseAddress = new Uri("");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                List<Commodity> commodities = new List<Commodity>();

            var response = await client.GetAsync("commodities");

            if(response.IsSuccessStatusCode)
            {
                commodities = await response.Content.ReadAsAsync<List<Commodity>>();
            }

            return commodities;

        }
    }
}