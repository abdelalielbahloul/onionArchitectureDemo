using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private DbSet<T> _entities;
        public Repository(AppDbContext context)
        {
            this._context = context;
            this._entities = context.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            else
            {
                _entities.Remove(entity);
                _context.SaveChanges();
            }
        }

        public T Get(int id)
        {
            return _entities.SingleOrDefault(entity => entity.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            else 
            {
                _entities.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            else
            {
                _context.Remove(entity);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            else
            {
                _entities.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}
