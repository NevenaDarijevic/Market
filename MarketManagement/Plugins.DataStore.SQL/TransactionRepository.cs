using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext db;

        public TransactionRepository(MarketContext db)
        {
            this.db = db;
        }
        public IEnumerable<Transaction> GetAll(string cashier)
        {
            return db.Transactions.Where(x =>x.Cashier.ToLower() == cashier.ToLower()).ToList();
        }

        public IEnumerable<Transaction> GetByDateRange(string cashier, DateTime start, DateTime end)
        {

            if (string.IsNullOrWhiteSpace(cashier))
            {
                return db.Transactions.Where(x => x.Time >= start.Date && x.Time <= end.Date.AddDays(1).Date);
            }
            else
            {
                return db.Transactions.Where(x => x.Time >= start.Date && x.Time <= end.Date.AddDays(1).Date && x.Cashier.ToLower() == cashier.ToLower());
            }
        }

        public IEnumerable<Transaction> GetByDay(string cashier, DateTime dateTime)
        {
            if (string.IsNullOrWhiteSpace(cashier))
            {
                return db.Transactions.Where(x => x.Time.Date == dateTime.Date);
            }
            else
            {
                return db.Transactions.Where(x => x.Time.Date == dateTime.Date && x.Cashier.ToLower()==cashier.ToLower());
            }
        }

        public void SaveTransaction(string cashier, int productId, string productName, double price, int beforeQuantity, int soldQuantity)
        {
            var transaction = new Transaction
            {
                ProductId = productId,
                ProductName = productName,
                SoldQuantity = soldQuantity,
                BeforeQuantity = beforeQuantity,
                Time = DateTime.Now,
                Price = price,
                Cashier = cashier
            };
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }
    }
}
