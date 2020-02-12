using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;
using LojaZero.Domain.Entity;

namespace LojaZero.Domain.Interface
{
    public interface IServiceAsync<T> where T : BaseEntity
    {
        T Post<TV>(T obj) where TV : AbstractValidator<T>;

        T Put<TV>(T obj) where TV : AbstractValidator<T>;

        void Delete(int id);

        Task<T> Get(int id);

        Task<IList<T>> Get();
    }
}