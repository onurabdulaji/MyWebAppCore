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
            _db.Add(entity);
            _db.SaveChanges();
        }

        public async Task AddAsync(T entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task CreateAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
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

        public async Task<List<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
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

        public async Task RemoveAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}

