using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int Emp_Code { get; set; }
        public string Emp_Name { get; set; }
        public string Designation {  get; set; }
        public decimal Salary { get; set; }


    }
}
