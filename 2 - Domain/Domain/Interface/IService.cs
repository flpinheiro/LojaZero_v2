using FluentValidation;
using LojaZero.Domain.Entity;
using System.Collections.Generic;

namespace LojaZero.Domain.Interface
{
    public interface IService<T> where T : BaseEntity
    {
        T Post<TV>(T obj) where TV : AbstractValidator<T>;

        T Put<TV>(T obj) where TV : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
