using AriBilgi.TekrarProjesi.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.TekrarProjesi.Entities
{
    public class Company : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public string Address { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
