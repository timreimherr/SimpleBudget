using System.ComponentModel.DataAnnotations;

namespace SimpleBudget.Domain.Models
{
    public class AccountType
    {
        public int AccountTypeId { get; set; }
        [StringLength(50), Display(Name = "Account Type")]
        public string Name { get; set; }
    }
}
