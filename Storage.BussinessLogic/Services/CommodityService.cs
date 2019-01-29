using Storage.Models.DataModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Storage.BusinessLogic.Services;

namespace Storage.BusinessLogic.Services
{
    public interface IProductService
    {
        void Add(Commodity category);

        void Update(Commodity category);

        void Delete(int id);

        List<Commodity> GetAll();

        Commodity Get(int id);
    }

    public class ProductService : ServiceBase, IProductService
    {
        private const string FilePath = @"\bin\Data\Products.txt";

        private List<Commodity> _products;

        public ProductService()
        {
            var savedData = ReadData();

            _products =
                savedData != null
                ? savedData
                : new List<Commodity>();
        }

        public void Add(Commodity product)
        {
            int id = GetMaxId(_products
                                    .OfType<Commodity>()
                                    .ToList());

            product.Id = id + 1;

            _products.Add(product);

            SaveChanges();
        }

        public void Delete(int id)
        {
            var product = Get(id);

            if (product != null)
            {
                _products.Remove(product);
            }

            SaveChanges();
        }

        public Commodity Get(int id)
        {
            return _products
                        .FirstOrDefault(x => x.Id == id);
        }

        public List<Commodity> GetAll()
        {
            return _products;
        }

        public void Update(Commodity product)
        {
            var oldCategory = Get(product.Id);

            oldCategory.Name = product.Name;

            SaveChanges();
        }

        private List<Commodity> ReadData()
        {
            var data = File.ReadAllText(GetStoragePath(FilePath));

            return JsonConvert.DeserializeObject<List<Commodity>>(data);
        }

        private void SaveChanges()
        {
            var data = JsonConvert.SerializeObject(_products);

            File.WriteAllText(GetStoragePath(FilePath), data);
        }
    }
}
