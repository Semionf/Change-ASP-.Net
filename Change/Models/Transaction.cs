namespace Change.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public CashRegister CashRegister { get; set; }
        public bool IsBuy { get; set; }
        public Client Client { get; set; }
        public List<RegisterTransaction> Actions { get; set; }
    }
}