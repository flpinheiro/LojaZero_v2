using LojaZero.Domain.Entity;
using System.Collections.Generic;

namespace LojaZero.Domain.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T SelectById(int id);

        IList<T> Select();
    }
}
