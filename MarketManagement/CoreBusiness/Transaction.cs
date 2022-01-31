﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
   public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Time { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } //if it has been changed
        public int BeforeQuantity { get; set; }
        public int SoldQuantity { get; set; }
        public double Price { get; set; }
        public string Cashier { get; set; }
    }
}
