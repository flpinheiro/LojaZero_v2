using FluentValidation;
using LojaZero.Domain.Entity;
using System.Collections.Generic;

namespace LojaZero.Domain.Interface
{
    public interface IService<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
