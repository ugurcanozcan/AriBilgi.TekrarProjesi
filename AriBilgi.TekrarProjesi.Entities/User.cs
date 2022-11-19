using AriBilgi.TekrarProjesi.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Entities
{
    public class User : EntityBase, IEntity
    {
        public string NameSurname { get; set; }
        public string Code { get; set; }
        public int Age { get; set; }
        public int CompanyId { get; set; }


        public virtual Company Company { get; set; }
    }
}
