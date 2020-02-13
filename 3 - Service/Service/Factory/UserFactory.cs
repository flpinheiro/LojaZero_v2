using LojaZero.Service.Exception;
using LojaZero.UserDomain.Entity;
using LojaZero.UserDomain.Enum;

namespace LojaZero.Service.Factory
{
    public class UserFactory
    {
        public string Email { get; set; }
        public AppIdentityUser CreateUser(UserType userType)
        {
            return (int) userType switch
            {
                (int) UserType.Person => (AppIdentityUser) new Person() {Email = this.Email, UserName = this.Email},
                (int) UserType.Company => new Company() {Email = this.Email, UserName = this.Email},
                _ => throw new UserTypeException()
            };
        }
    }
}