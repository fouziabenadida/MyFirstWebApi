namespace MyFirstWebApi.Controllers.Models.Requests
{
    public class CreateCompanyRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime FoundedDate { get; set; }
        public string Industry { get; set; }
    }
}