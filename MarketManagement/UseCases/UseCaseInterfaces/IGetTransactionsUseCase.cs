using CoreBusiness;
using System;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashier, DateTime start, DateTime end);
    }
}