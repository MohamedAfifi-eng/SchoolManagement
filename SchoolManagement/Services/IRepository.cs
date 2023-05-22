using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Services
{
    public interface  IRepository<T> 
    {
         T Create(T entity);
         T Update(T entity);
         bool Delete(T entity);
         IEnumerable<T> GetAll();
        T Find(int id);
    }
}