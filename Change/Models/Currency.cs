using System.ComponentModel.DataAnnotations;

namespace Change.Models
{
    public class Currency
    {
        public Currency() { }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; } = string.Empty;

        [Display (Name ="כמות")]
        public decimal Quantity { get; set; }
        public bool isActive { get; set; }
        public byte[] Image { get; set; }
        public IFormFile SetImage { set { Image = new SetImage(value).Image; } }
    }
}
