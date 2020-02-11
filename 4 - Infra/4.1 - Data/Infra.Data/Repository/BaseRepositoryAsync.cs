using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaZero.Domain.Entity;
using LojaZero.Domain.Interface;
using LojaZero.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LojaZero.Infra.Data.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : BaseEntity
    {
        private DomainDbContext context = new DomainDbContext();
        public async Task InsertAsync(T obj)
        {
            await context.Set<T>().AddAsync(obj);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            context.Set<T>().Remove(SelectByIdAsync(id).Result);
            await context.SaveChangesAsync();
        }

        public async Task<T> SelectByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<IList<T>> SelectAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}
