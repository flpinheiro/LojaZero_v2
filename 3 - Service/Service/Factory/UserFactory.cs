using LojaZero.Service.Exception;
using LojaZero.UserDomain.Entity;
using LojaZero.UserDomain.Enum;

namespace LojaZero.Service.Factory
{
    public class UserFactory
    {
        public string Email { get; set; }
        public AppIdentityUser CreateUser(UserType userType) =>
            (int)userType switch
            {
                (int)UserType.Person =>
                (new Person { Email = this.Email, UserName = this.Email } as AppIdentityUser),
                (int)UserType.Company =>
                (new Company { Email = this.Email, UserName = this.Email } as AppIdentityUser),
                _ => throw new UserTypeException()
            };
    }
}
