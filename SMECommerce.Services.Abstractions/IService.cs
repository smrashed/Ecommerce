using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
    public interface IService<T> where T:class
    {
        T GetById(int id);
        ICollection<T> GetAll();
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Remove(T entity);
    }
}
