using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NorthParallelProjectManagmentSoftware.Data
{
    public class CompanyServices
    {
        private readonly ApplicationDbContext _appDBContext;

        public CompanyServices(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        //Get list of all Company
        public async Task<List<Company>> GetAllCompanyAsync()
        {
            return await _appDBContext.Company.ToListAsync();
        }
        //Get list of all Company
        public async Task<List<Company>> GetCompanyByMCompanyAsync(string MainCompany)
        {
            List<Company> companybyMain = new List<Company>();
            List<Company> company = await _appDBContext.Company.ToListAsync();
            foreach (var cmp in company)
            {

                if (cmp.MainCompany == MainCompany)
                {

                    companybyMain.Add(cmp);
                }

            }

            return companybyMain;
        }

        public async Task<Company> GetcompanyByuserId(int Id)
        {
            Company companyByUid = new Company();
            List<User> user = await _appDBContext.User.ToListAsync();
            List<Company> company = await _appDBContext.Company.ToListAsync();
            foreach (var users in user)
            {
                if (users.UserId == Id)
                {

                    foreach (var cmp in company)
                    {

                        if (cmp.CompanyName == users.UserAssignedCompany.CompanyName)
                        {

                            companyByUid = cmp;
                        }
                    }
                }
            }

            return companyByUid;
        }


        //Add new Company
        public async Task<bool> InsertCompanyAsync(Company company)
        {
            await _appDBContext.Company.AddAsync(company);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Get Company by CompanyId
        public async Task<Company> GetCompanyAsync(int Id)
        {
            Company company = await _appDBContext.Company.FirstOrDefaultAsync(c => c.CompanyId.Equals(Id));
            return company;
        }

        //Update Company
        public async Task<bool> UpdateCompanyAsync(Company company)
        {
            _appDBContext.Company.Update(company);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Delete Company
        public async Task<bool> DeleteCompanyAsync(Company company)
        {
            _appDBContext.Company.Remove(company);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}
