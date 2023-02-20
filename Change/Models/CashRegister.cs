using System.ComponentModel.DataAnnotations;

namespace Change.Models
{
    public class CashRegister
    {
        public CashRegister() { }

        [Key]
        public int Id { get; set; }
        public Action MorningInsert { get; set; }
        public Dictionary<string, Currency> Cash { get;set; }
    }
}
