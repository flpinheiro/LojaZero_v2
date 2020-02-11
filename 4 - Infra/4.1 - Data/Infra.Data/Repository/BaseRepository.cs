using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaZero.Domain.Entity;
using LojaZero.Domain.Interface;
using LojaZero.Infra.Data.Context;

namespace LojaZero.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private DomainDbContext context = new DomainDbContext();

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Set<T>().Remove(SelectById(id));
            context.SaveChanges();
        }

        public IList<T> Select()
        {
            return context.Set<T>().ToList();
        }

        public T SelectById(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
