using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBudget.Domain.Models;

namespace SimpleBudget.Domain.Models
{
    public class MoneyTransaction
    {
        public int MoneyTransactionId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }

        public int TransactionTypeId { get; set; }
        public virtual TransactionType TransactionType { get; set; }

        public int? PayeeId { get; set; }
        public virtual Payee Payee { get; set; }

        public int MoneyAccountId { get; set; }
        public virtual MoneyAccount MoneyAccount { get; set; }

        //// A MoneyLedger can only belong to one Budget
        //public int BudgetId { get; set; }
        //public virtual Budget Budget { get; set; }

    }
}
