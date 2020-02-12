using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;
using LojaZero.Domain.Interface;
using LojaZero.UserDomain.Entity;

namespace LojaZero.Service.Service
{
    public class BaseUserService<T> : IServiceUserAsync<T> where T: AppUser
    {
        private readonly IRepositoryUserAsync<T> _repository;

        public BaseUserService(IRepositoryUserAsync<T> repository)
        {
            this._repository = repository;
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

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("The id can't be null or empty.");

            _repository.DeleteAsync(id);
        }

        public Task<T> Get(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("The id can't be null or empty.");

            return _repository.SelectByIdAsync(id);
        }

        public Task<IList<T>> Get() => _repository.SelectAsync();
        protected void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}