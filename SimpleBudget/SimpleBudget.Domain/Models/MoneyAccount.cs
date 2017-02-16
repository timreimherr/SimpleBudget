using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SimpleBudget.Domain.Models;

namespace SimpleBudget.Domain.Models
{
    public class MoneyAccount
    {
        public int MoneyAccountId { get; set; }
        [Required(ErrorMessage = "Please enter a name for the account")]
        [Display(Name = "Account Name")]
        [StringLength(50, ErrorMessage = "Must be between 1 and 50 characters", MinimumLength = 1)]
        public string Name { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        public decimal Balance { get; set; }

        // A MoneyAccount can only have one AccountType
        [Required(ErrorMessage = "Please select account type")]
        [Display(Name = "Account Type")]
        public int AccountTypeId { get; set; }
        public virtual AccountType AccountType { get; set; }

        // A MoneyAccount can belong to only one Budget
        public int BudgetId { get; set; }
        public virtual Budget Budget { get; set; }
    }
}
