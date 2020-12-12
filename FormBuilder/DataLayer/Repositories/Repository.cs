using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal FormDataBase context;

        internal DbSet<TEntity> dbSet;

        public Repository(FormDataBase context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        //Delete an entity from data base
        public void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }

            dbSet.Remove(entityToDelete);
        }

        //Delete an entity by given id
        public void Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            Delete(entity);
        }

        //Gets a list of enity
        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            else
            {
                return query.ToList();
            }
        }

        //Gets an entity by given id
        public TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        //Get a list of entity with raw sql query.
        public IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            return dbSet.SqlQuery(query, parameters).ToList();
        }

        //Insert new entity into data base.
        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        //Updates an entity.
        public void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
