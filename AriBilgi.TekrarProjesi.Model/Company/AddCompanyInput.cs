using AriBilgi.TekrarProjesi.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Model.Company
{
    public class AddCompanyInput
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public string Address { get; set; }
        public AddUserInput AddUserInput { get; set; }
    }
}
