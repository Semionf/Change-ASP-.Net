using System.ComponentModel.DataAnnotations;

namespace Change.Models
{
    public class Office
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "מנהל")]
        public Manager Manager { get; set; }
        public List<Employee> EmployeeList { get; set; }
        public List<CashRegister> CashRegisterList { get; set; }
        public bool isMain { get; set; }
    }
}
