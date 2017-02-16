using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBudget.Data.Models
{
    public class TransactionType
    {
        public int TransactionTypeId { get; set; }
        [StringLength(25, MinimumLength = 1), Display(Name = "Transaction Type")]
        public string Name { get; set; }
    }
}
