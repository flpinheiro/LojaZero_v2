using LojaZero.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaZero.Domain.Interface
{
    public interface IRepositoryAsync<T> where T : BaseEntity
    {
        Task InsertAsync(T obj);

        Task UpdateAsync(T obj);

        Task DeleteAsync(int id);

        Task<T> SelectByIdAsync(int id);

        Task<IList<T>> SelectAsync();
    }
}
