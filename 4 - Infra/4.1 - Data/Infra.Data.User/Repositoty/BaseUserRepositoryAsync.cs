using LojaZero.Domain.Interface;
using LojaZero.Infra.Data.User.Context;
using LojaZero.UserDomain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaZero.Infra.Data.User.Repositoty
{
    public class BaseUserRepositoryAsync<T> : IRepositoryUserAsync<T> where T : AppIdentityUser
    {
        private readonly AppIdentityDbContext context = new AppIdentityDbContext();
        public async Task InsertAsync(T obj)
        {
            await context.Set<T>().AddAsync(obj);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            context.Set<T>().Remove(SelectByIdAsync(id).Result);
            await context.SaveChangesAsync();
        }

        public async Task<T> SelectByIdAsync(string id)
        => await context.Set<T>()
                .Include(a => a.Addresses)
                .Include(a => a.Phones)
                .FirstOrDefaultAsync(a => a.Id == id);

        public async Task<IList<T>> SelectAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}