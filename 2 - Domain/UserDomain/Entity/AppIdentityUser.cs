using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace LojaZero.UserDomain.Entity
{
    public abstract class AppIdentityUser : IdentityUser
    {
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
