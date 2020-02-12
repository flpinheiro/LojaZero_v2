using FluentValidation;
using LojaZero.Domain.Entity;
using LojaZero.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaZero.Service.Service
{
    public class BaseService <T> :IServiceAsync<T> where T: BaseEntity
    {
        private readonly IRepositoryAsync<T> _repository;

        public BaseService(IRepositoryAsync<T> repository)
        {
            _repository = repository;
        }
        public T Post<TV>(T obj) where TV : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<TV>());

            _repository.InsertAsync(obj);
            return obj;
        }

        public T Put<TV>(T obj) where TV : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<TV>());

            _repository.UpdateAsync(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            _repository.DeleteAsync(id);
        }

        public Task<T> Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            return _repository.SelectByIdAsync(id);
        }

        public Task<IList<T>> Get()
            => _repository.SelectAsync();

        protected void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
