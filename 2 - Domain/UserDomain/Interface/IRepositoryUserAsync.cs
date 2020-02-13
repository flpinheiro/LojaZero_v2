using LojaZero.UserDomain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaZero.Domain.Interface
{
    public interface IRepositoryUserAsync<T> where T : AppIdentityUser
    {
        Task InsertAsync(T obj);

        Task UpdateAsync(T obj);

        Task DeleteAsync(string id);

        Task<T> SelectByIdAsync(string id);

        Task<IList<T>> SelectAsync();
    }
}
