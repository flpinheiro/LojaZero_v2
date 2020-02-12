using LojaZero.UserDomain.Entity;
using System.Collections.Generic;

namespace LojaZero.Domain.Interface
{
    public interface IRepositoryUser<T> where T : AppUser
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(string id);

        T SelectById(string id);

        IList<T> Select();
    }
}
