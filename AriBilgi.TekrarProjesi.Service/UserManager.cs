using AriBilgi.TekrarProjesi.Data.UOW;
using AriBilgi.TekrarProjesi.Entities;
using AriBilgi.TekrarProjesi.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Service
{
    public class UserManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public UserManager()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void Insert(AddUserInput addUserInput)
        {
            try
            {
                User user = new()
                {
                    Age = addUserInput.Age,
                    Code = addUserInput.Code,
                    CompanyId = addUserInput.CompanyId,
                    CreatedBy = 0,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    NameSurname = addUserInput.NameSurname
                };
                _unitOfWork.Users.Add(user);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
