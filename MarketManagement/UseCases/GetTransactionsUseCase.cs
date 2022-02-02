using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetTransactionsUseCase : IGetTransactionsUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public GetTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }



        public IEnumerable<Transaction> Execute(string cashier, DateTime start, DateTime end)
        {
            return transactionRepository.GetByDateRange(cashier, start, end);
        }
    }
}
