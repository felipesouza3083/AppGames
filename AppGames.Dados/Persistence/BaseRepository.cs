using AppGames.Dados.Context;
using AppGames.Dados.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGames.Dados.Persistence
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        protected ApplicationDbContext context;

        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public virtual void Insert(T obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges();
        }

        public virtual void Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(T obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public virtual IList<T> FindAll()
        {
            return context.Set<T>().ToList();
        }

        public virtual T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
