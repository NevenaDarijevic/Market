using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductsUseCases;

namespace UseCases
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {


        private readonly ITransactionRepository transactionRepository;
        private readonly IGetProductByIdUseCase getProductByIdUseCase;

        public RecordTransactionUseCase(ITransactionRepository transactionRepository, IGetProductByIdUseCase getProductByIdUseCase)
        {

            this.transactionRepository = transactionRepository;
            this.getProductByIdUseCase = getProductByIdUseCase;
        }
        public void Execute(string cashier,int productId, int quantity)
        {
            var product = getProductByIdUseCase.Execute(productId);
            transactionRepository.SaveTransaction(cashier, productId, product.Name, product.Price.Value, product.Quantity.Value, quantity); //because double?

        }
    }
}
