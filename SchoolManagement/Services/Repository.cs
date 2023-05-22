using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        public Repository()
        {
            _context = new ApplicationDbContext();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            SaveChanges();
            return entity;
        }

        public bool Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return SaveChanges() > 0;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T Update(T entity)
        {
            
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            SaveChanges();
            return entity;
        }

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }


    }
}