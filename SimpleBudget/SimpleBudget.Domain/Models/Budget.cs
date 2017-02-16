using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SimpleBudget.Domain.Models;

namespace SimpleBudget.Domain.Models
{
    public class Budget
    {
        public Budget()
        {
            this.Envelopes = new List<Envelope>();
            this.MoneyAccounts = new List<MoneyAccount>();
        }
        public int BudgetId { get; set; }
        [Display(Name = "Budget Name", Prompt = "Enter budget name here")]
        [StringLength(50, ErrorMessage = "Name for your budget must be between 1 and 50 characters", MinimumLength = 1)]
        public string Name { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public virtual ICollection<Envelope> Envelopes { get; set; }
        public virtual ICollection<MoneyAccount> MoneyAccounts { get; set; }
    }
}
