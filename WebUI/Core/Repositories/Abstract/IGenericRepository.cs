using System.Collections.Generic;

namespace WebUI.Core.Repositories.Abstract
{
    public interface IGenericRepository<T> where T: class,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
