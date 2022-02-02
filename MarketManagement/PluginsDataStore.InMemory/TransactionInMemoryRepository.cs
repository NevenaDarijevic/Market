using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class TransactionInMemoryRepository : ITransactionRepository
    {
        private List<Transaction> transactions;

        public TransactionInMemoryRepository()
        {
            transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> GetAll(string cashier)
        {
            if (string.IsNullOrWhiteSpace(cashier)) return transactions;
            else
            {
                return transactions.Where(x =>string.Equals(x.Cashier, cashier, StringComparison.OrdinalIgnoreCase));
            }
           
        }

        public IEnumerable<Transaction> GetByDateRange(string cashier, DateTime start, DateTime end)
        {
            if (string.IsNullOrWhiteSpace(cashier))
            {
                return transactions.Where(x => x.Time >= start.Date && x.Time <= end.Date.AddDays(1).Date);
            }
            else
            {
                return transactions.Where(x => x.Time >= start.Date && x.Time <= end.Date.AddDays(1).Date && string.Equals(x.Cashier, cashier, StringComparison.OrdinalIgnoreCase));
            }
        }

        public IEnumerable<Transaction> GetByDay(string cashier,DateTime dateTime)
        {
            if (string.IsNullOrWhiteSpace(cashier))
            {
                return transactions.Where(x => x.Time.Date == dateTime.Date);
            }
            else
            {
                return transactions.Where(x => x.Time.Date == dateTime.Date && string.Equals(x.Cashier, cashier, StringComparison.OrdinalIgnoreCase));
            }
           
        }

        public void SaveTransaction(string cashier,int productId,string productName, double price,int beforeQuantity, int soldQuantity)
        {
            int newId=0;
            if(transactions!=null && transactions.Count > 0)
            {
                newId = transactions.Max(x => x.TransactionId)+1;

            }
            else
            {
                newId = 1;
            }
            

            transactions.Add(new Transaction
            {
                ProductId = productId,
                ProductName=productName,
                SoldQuantity = soldQuantity,
                BeforeQuantity=beforeQuantity,
                Time = DateTime.Now,
                Price=price,
                TransactionId=newId,
                Cashier=cashier


            }) ;
        }
    }
}
