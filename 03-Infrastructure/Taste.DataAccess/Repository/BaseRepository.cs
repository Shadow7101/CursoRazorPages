using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Taste.Models.Interfaces;

namespace Taste.DataAccess.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;

        internal DbSet<T> dbSet;

        public BaseRepository(DbContext context)
        {
            Context = context;
            this.dbSet = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await this.dbSet.AddAsync(entity);
        }

        public async Task<T> Get(int id)
        {
            return await this.dbSet.FindAsync(id);
        }
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public async Task Remover(int id)
        {
            T entityToRemove = await dbSet.FindAsync(id);
            Remove(entityToRemove);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
                query = query.Where(filter);

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                var q = orderBy(query);
                return q.ToList();
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
                query = query.Where(filter);

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.FirstOrDefaultAsync();
        }

    }
}
