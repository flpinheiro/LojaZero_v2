using FluentValidation;
using LojaZero.UserDomain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaZero.Domain.Interface
{
    public interface IServiceUserAsync<T> where T : AppUser
    {
        T Post<TV>(T obj) where TV : AbstractValidator<T>;

        T Put<TV>(T obj) where TV : AbstractValidator<T>;

        void Delete(string id);

        Task<T> Get(string id);

        Task<IList<T>> Get();
    }
}