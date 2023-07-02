using System.Collections.Generic;
using System.Linq;
using WebUI.Core.Repositories.Abstract;
using WebUI.Entities.Context;

namespace WebUI.Core.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {

        private readonly MiniTransferContext _context;

        public GenericRepository(MiniTransferContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {

            _context.Set<T>().Add(entity);

        }

        public void Delete(T entity)
        {

            _context.Set<T>().Remove(entity);

        }

        public List<T> GetAll()
        {

            return _context.Set<T>().ToList();

        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
