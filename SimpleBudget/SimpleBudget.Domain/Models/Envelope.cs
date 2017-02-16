using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SimpleBudget.Domain.Models;

namespace SimpleBudget.Domain.Models
{
    public class Envelope
    {
        public Envelope()
        {
            this.EnvelopeTransactions = new List<EnvelopeTransaction>();
        }
        public int EnvelopeId { get; set; }
        [StringLength(50, ErrorMessage = "Name for your budget must be between 1 and 50 characters", MinimumLength = 1)]
        public string Name { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        public decimal Balance { get; set; }

        //An Envelope can belong to only one Budget
        public int BudgetId { get; set; }
        public virtual Budget Budget { get; set; }

        public virtual ICollection<EnvelopeTransaction> EnvelopeTransactions { get; set; }
    }
}
