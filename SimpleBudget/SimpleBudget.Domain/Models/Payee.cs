using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SimpleBudget.Domain.Models
{
    public class Payee
    {
        public int PayeeId { get; set; }
        [StringLength(50, MinimumLength = 1), Display(Name = "Payee")]
        public string Name { get; set; }
    }
}
