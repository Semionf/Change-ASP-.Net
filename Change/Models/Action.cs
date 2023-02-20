using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Change.Models
{
    public abstract class Action
    {
        [Key]
        public int Id { get; set; }
        /* */
        public Currency Currency { get; set; }
        public CashRegister CashRegister { get; set; }

        [NotMapped, Display(Name ="תוספת")]
        public double Rate { get; set; } = 0.01;
        [Display (Name = "תאריך פעולה")]
        public DateTime DateTime { get; set; }
    }
}
