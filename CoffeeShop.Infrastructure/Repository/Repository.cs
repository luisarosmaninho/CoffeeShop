using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using CoffeeShop.Application.Common.Interfaces;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Infrastructure.Data;

namespace CoffeeShop.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (!string.IsNullOrEmpty(includeProperties))
                //Produto,Acessorios -- case sensitive
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProp.Trim());

            return query.FirstOrDefault()!;
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (!string.IsNullOrEmpty(includeProperties))
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProp.Trim());

            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
    }
}
