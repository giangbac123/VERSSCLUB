using Microsoft.EntityFrameworkCore;
using Repository.IRepositories;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class Class1
    {
        public class AllRepository<T> : IAllRepository<T> where T : class
        {
            VerssclubContext _context;
            DbSet<T> _dbSet;
            public AllRepository()
            {
                _context = new VerssclubContext();
            }
            public AllRepository(VerssclubContext context, DbSet<T> dbSet)
            {
                _context = context;
                _dbSet = dbSet;
            }
            public bool CreateObj(T obj)
            {
                try
                {
                    _dbSet.Add(obj);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public bool DeleteObj(T obj)
            {
                try
                {
                    _dbSet.Remove(obj);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public ICollection<T> GetAll()
            {
                return _dbSet.ToList();
            }

            public T GetByID(dynamic id)
            {
                return _dbSet.Find(id);
            }

            public bool UpdateObj(T obj)
            {
                try
                {
                    _dbSet.Update(obj);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
