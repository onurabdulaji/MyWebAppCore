using Project.EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.ManagerServices.Abstracts
{
    public interface IManager<T> where T : class, IEntity
    {
        // Modify  Commands
        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        // List Commands
        List<T> TGetList();
        // Find Commands
        T TGetById(int id);
        // Linq  Commands
        List<T> TGetListFilter(Expression<Func<T, bool>> expression);
        T TFirstOrDefault(Expression<Func<T, bool>> expression);
        // Queryable Commands
        IQueryable<T> TGetListQuery();
        // Async Methods
        Task TAddAsync(T entity);
        Task<T> TFirstOrDefaultAsync(Expression<Func<T, bool>> exp);
        Task<T> TGetByIdAsync(int id);

        // Cqrs

        Task<List<T>> TGetAllAsync();
        Task TCreateAsync(T entity);
        Task TUpdateAsync(T entity);
        Task TRemoveAsync(T entity);
    }
}
