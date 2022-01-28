using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public SellProductUseCase(IProductRepository productRepository, IRecordTransactionUseCase  recordTransactionUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }



        public void Execute(string cashier,int productId, int quantity)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;
            recordTransactionUseCase.Execute(cashier, productId, quantity);
            product.Quantity = product.Quantity - quantity;
            productRepository.UpdateProduct(product);
           
        }

       
    }
}
