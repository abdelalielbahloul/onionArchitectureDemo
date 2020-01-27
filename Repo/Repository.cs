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
        private readonly AppDbContext context;
        private DbSet<T> entities;
        public Repository(AppDbContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            else
            {
                entities.Remove(entity);
                context.SaveChanges();
            }
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(entity => entity.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            else 
            {
                entities.Add(entity);
                context.SaveChanges();
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
                context.Remove(entity);
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            else
            {
                entities.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
