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
        private readonly DomainDbContext _context = new DomainDbContext();

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Set<T>().Remove(SelectById(id));
            _context.SaveChanges();
        }

        public IList<T> Select()
        {
            return _context.Set<T>().ToList();
        }

        public T SelectById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
