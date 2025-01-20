namespace MyFirstWebApi.Controllers.Models.Responses
{
    public class GetEmployeeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
        public int CompanyId { get; set; }
    }
}