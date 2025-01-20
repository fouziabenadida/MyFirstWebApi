namespace MyFirstWebApi.Controllers.Models.Requests
{
    public class CreateEmployeeRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
        public int CompanyId { get; set; }
    }
}