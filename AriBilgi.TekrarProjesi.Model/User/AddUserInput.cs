using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Model.User
{
    public class AddUserInput
    {
        public string NameSurname { get; set; }
        public string Code { get; set; }
        public int Age { get; set; }
        public int CompanyId { get; set; }
    }
}
