using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SimpleBudget.Domain.Models;

namespace SimpleBudget.Domain.Models
{
    public class EnvelopeTransaction
    {
        public int EnvelopeTransactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        [StringLength(300)]
        public string Description { get; set; }


        public int EnvelopeId { get; set; }
        public virtual Envelope Envelope { get; set; }

        public int PayeeId { get; set; }
        public virtual Payee Payee { get; set; }

        public int TransactionTypeId { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}
