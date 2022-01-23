using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            //defuaault values
            products = new List<Product>
            {
                new Product
                {
                    ProductId=1, CategoryId=1, Name="Product1", Quantity=3, Price=1230.4
                },
                 new Product
                {
                    ProductId=2, CategoryId=1, Name="Product2", Quantity=5, Price=1230.4
                },
                  new Product
                {
                    ProductId=3, CategoryId=2, Name="Product3", Quantity=3, Price=4444
                },

            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
