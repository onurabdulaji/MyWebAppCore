using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Repositories.Abstracts
{
    public interface IRepository<T> where T : class
    {
        // Modify  Commands
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        // List Commands
        List<T> GetList();
        // Find Commands
        T GetById(int id);
        // Linq  Commands
        List<T> GetListFilter(Expression<Func<T, bool>> expression);
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        // Queryable Commands
        IQueryable<T> GetListQuery();
        // Async Methods
        Task AddAsync(T entity);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);
        Task<T> GetByIdAsync(int id);


        // Cqrs

        Task<List<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);

    }
}
