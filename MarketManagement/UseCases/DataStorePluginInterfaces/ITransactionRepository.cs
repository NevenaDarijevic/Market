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
      void SaveTranaction(string cashier,int productId,string productName, double price, int beforeQuantity,int soldQuantity);
        IEnumerable<Transaction> GetByDay(string cashier,DateTime dateTime);
        IEnumerable<Transaction> GetAll(string cashier);
    }
}
