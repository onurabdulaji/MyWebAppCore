using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.ManagerServices.Concretes
{
    public class BaseManager<T> : IManager<T> where T : class, IEntity
    {
        protected IRepository<T> _iRepository;

        public BaseManager(IRepository<T> iRepository)
        {
            _iRepository = iRepository;
        }

        public void TAdd(T entity)
        {
            entity.InsertedDate = DateTime.Now;
            _iRepository.Add(entity);
        }

        public async Task TAddAsync(T entity)
        {
            entity.InsertedDate = DateTime.Now;
            await _iRepository.AddAsync(entity);
        }

        public void TDelete(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            _iRepository.Delete(entity);
        }

        public T TFirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return _iRepository.FirstOrDefault(expression);
        }

        public async Task<T> TFirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await _iRepository.FirstOrDefaultAsync(exp);
        }

        public T TGetById(int id)
        {
            return _iRepository.GetById(id);
        }

        public async Task<T> TGetByIdAsync(int id)
        {
            return await _iRepository.GetByIdAsync(id);
        }

        public List<T> TGetList()
        {
            return _iRepository.GetList();
        }

        public List<T> TGetListFilter(Expression<Func<T, bool>> expression)
        {
            return _iRepository.GetListFilter(expression);
        }

        public IQueryable<T> TGetListQuery()
        {
            return _iRepository.GetListQuery();
        }

        public void TUpdate(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _iRepository.Update(entity);
        }
    }
}
