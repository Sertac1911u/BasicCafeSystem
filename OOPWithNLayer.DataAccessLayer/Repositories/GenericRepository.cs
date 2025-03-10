﻿using OOPWithNLayer.DataAccessLayer.Abstract;
using OOPWithNLayer.DataAccessLayer.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OOPWithNLayer.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        ApplicationContext context = new ApplicationContext();
        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
