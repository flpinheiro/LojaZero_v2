using LojaZero.UserDomain.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaZero.UserDomain.Entity
{
    public class Company :AppIdentityUser, IAppUser
    {
        public string CNPJ { get; set; }
        public string CompanyName { get; set; }
        [NotMapped]
        public bool Wholesale => true;
    }
}
