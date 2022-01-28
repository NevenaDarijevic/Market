using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface ITransactionsForTodayUseCase
    {
        IEnumerable<Transaction> Execute(string cashier);
    }
}