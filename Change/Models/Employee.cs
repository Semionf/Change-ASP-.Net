using System.ComponentModel.DataAnnotations;

namespace Change.Models
{
    public class Employee: User
    {
        public Employee() { }

        public List<Action> Actions { get; set; }
        [Display (Name = "קופה")]
        public CashRegister CashRegister { get; set; }
    }
}
