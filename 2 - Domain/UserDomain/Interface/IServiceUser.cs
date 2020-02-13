using FluentValidation;
using LojaZero.UserDomain.Entity;
using System.Collections.Generic;

namespace LojaZero.Domain.Interface
{
    public interface IServiceUser<T> where T : AppIdentityUser
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(string id);

        T Get(string id);

        IList<T> Get();
    }
}
