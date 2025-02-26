﻿namespace DataLayer.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public string JobTitle { get; set; }
        public int DepartmentId { get; set; }
        public int CompanyId { get; set; }
    }
}