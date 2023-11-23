using Microsoft.EntityFrameworkCore;
using Project.DataAccessLayer.Context;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.EntityLayer.Enums;
using Project.EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Repositories.Concretes
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly MyContext _db;

        public BaseRepository(MyContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            entity.Status = DataStatus.Inserted;
            entity.InsertedDate = DateTime.Now;
            _db.Add(entity);
            _db.SaveChanges();
        }

        public async Task AddAsync(T entity)
        {
            entity.Status = DataStatus.Inserted;
            entity.InsertedDate = DateTime.Now;
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            entity.Status = DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().FirstOrDefault(expression);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(exp);
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public List<T> GetList()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetListFilter(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).ToList();
        }

        public IQueryable<T> GetListQuery()
        {
            return _db.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            entity.Status = DataStatus.Updated;
            entity.UpdatedDate = DateTime.Now;
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}

