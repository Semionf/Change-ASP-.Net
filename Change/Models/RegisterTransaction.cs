using System.ComponentModel.DataAnnotations;


namespace Change.Models
{
    public class RegisterTransaction:Action
    {
        public Transaction Transaction { get; set; }
        //public Client Client { get; set; }
        //[Display(Name = "המרה")]
        //public List<Currency> exchange { get; set; }

    }
}
