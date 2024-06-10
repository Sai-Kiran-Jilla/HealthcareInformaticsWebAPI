using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; } // true for Male, false for Female

        [NotMapped]
        public string GenderString
        {
            get => Gender ? "Male" : "Female";
            set => Gender = value.ToLower() == "male";
        }

        public string Department { get; set; }
        public string Designation { get; set; }
        public double BasicSalary { get; set; }
    }
}
