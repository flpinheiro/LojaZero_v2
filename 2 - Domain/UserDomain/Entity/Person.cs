using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LojaZero.UserDomain.Entity
{
    public class Person : IdentityUser
    {
        public DateTime BirthDay { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
