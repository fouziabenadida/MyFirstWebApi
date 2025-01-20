using ApplicationLayer.Models;
using DataLayer.Data;
using DataLayer.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationLayer.Services;

public class CompanyService
{
    private readonly MyFirstWebApiDbContext _dbContext;

    public CompanyService(MyFirstWebApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateCompany(Company company)
    {
        var countAsync = await _dbContext.Companies.CountAsync(x => x.Name == company.Name);

        if (countAsync > 0)
        {
            throw new Exception("Company already exists");
        }

        _dbContext.Companies.Add(company);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<CompanyDTO>> GetAllCompanies()
    {
        List<Company> companies = await _dbContext.Companies.Where(x => true).ToListAsync();

        List<CompanyDTO> companyDtos = companies.Select(x => new CompanyDTO
        {
            Email = x.Email,
            Name = x.Name,
            Address = x.Address,
            PhoneNumber = x.PhoneNumber,
        }).ToList();

        return companyDtos;
    }
}