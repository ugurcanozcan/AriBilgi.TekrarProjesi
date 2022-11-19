using AriBilgi.TekrarProjesi.Data.UOW;
using AriBilgi.TekrarProjesi.Entities;
using AriBilgi.TekrarProjesi.Model.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Service
{
    public class CompanyManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public CompanyManager()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void Insert(AddCompanyInput addCompanyInput)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                Company company = new()
                {
                    Name=addCompanyInput.Name,
                    Address=addCompanyInput.Address,
                    MailAddress=addCompanyInput.MailAddress,
                    PhoneNumber=addCompanyInput.PhoneNumber,
                    Title=addCompanyInput.Title,
                    CreatedDate=DateTime.Now,
                    CreatedBy=0,
                    IsDeleted=false
                };
                _unitOfWork.Companies.Add(company);
                _unitOfWork.SaveChanges();

                UserManager userManager = new(_unitOfWork);
                addCompanyInput.AddUserInput.CompanyId = company.Id;
                userManager.Insert(addCompanyInput.AddUserInput);

                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }
    }
}
