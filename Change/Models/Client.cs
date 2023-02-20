using System.ComponentModel.DataAnnotations;

namespace Change.Models
{
    public class Client
    {
        public Client() { }

        [Key]
        public int ID { get; set; }

        [Display(Name = "תעודת זהות")]
        public byte[] Image { get; set; }

    }
}
