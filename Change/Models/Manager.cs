using System.ComponentModel.DataAnnotations;

namespace Change.Models
{
    public class Manager:Employee
    {
        public Manager() { }

        [Display(Name = "תאריך תחילת המינוי"), DataType(DataType.Date)]
        public DateTime StartWorkingDate { get; set; }

    }
}
