using System.Collections.Generic;
using System.Linq;
using LojaZero.Domain.Interface;
using LojaZero.Infra.Data.User.Context;
using LojaZero.UserDomain.Entity;

namespace LojaZero.Infra.Data.User.Repositoty
{
    public class BaseUserRepository<T> : IRepositoryUser<T> where T : AppIdentityUser
    {
        private readonly AppIdentityDbContext _context = new AppIdentityDbContext();
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

        public void Delete(string id)
        {
            _context.Set<T>().Remove(SelectById(id));
            _context.SaveChanges();
        }

        public T SelectById(string id)
        {
            return _context.Set<T>().Find(id);
        }

        public IList<T> Select()
        {
            return _context.Set<T>().ToList();
        }
    }
}