using LojaZero.UserDomain.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using LojaZero.UserDomain.Enum;

namespace LojaZero.UserDomain.Entity
{
    public class Person : AppUser, IAppUser
    {
        public string CPF { get; set; }
        public DateTime BirthDay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        [NotMapped]
        public bool Wholesale => false;
    }
}
