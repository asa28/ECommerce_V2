using V2.DAL.Models;
using V2.DAL.Repositories;

namespace V2.BLL.Services
{
    public class CompanyService
    {
        private readonly CompanyRepository _companyRepo;

        public CompanyService(CompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }


        // implement Business Logic


        public Product Add()
        {
            return new Product();
        }

    }
}