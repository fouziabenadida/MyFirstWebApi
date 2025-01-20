using ApplicationLayer.Models;
using ApplicationLayer.Services;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApi.Controllers.Models.Requests;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyService _companyService;

        public CompanyController(CompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanies()
        {
            List<CompanyDTO> allCompanies = await _companyService.GetAllCompanies();
            return Ok(allCompanies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody] CreateCompanyRequest request)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] UpdateCompanyRequest request)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            return Ok(new { Message = "Company deleted successfully." });
        }
    }
}