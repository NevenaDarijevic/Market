using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
     public void SaveTransaction(string cashier,int productId,string productName, double price, int beforeQuantity,int soldQuantity);
    public IEnumerable<Transaction> GetByDay(string cashier,DateTime dateTime);
      public  IEnumerable<Transaction> GetAll(string cashier);
        IEnumerable<Transaction> GetByDateRange(string cashier, DateTime start, DateTime end);
    }
}
