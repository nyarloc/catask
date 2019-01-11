using Catask.DAL.EF;
using Catask.DAL.Entities;
using Catask.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Catask.DAL.Repositories
{
    public class PriorityRepository : IRepository<Priority>
    {
        private CataskContext context;

        public PriorityRepository(CataskContext context)
        {
            this.context = context;
        }

        public void Create(Priority item)
        {
            context.Priorities.Add(item);
        }

        public void Delete(Priority item)
        {
            context.Priorities.Remove(item);
        }

        public IEnumerable<Priority> Find(Func<Priority, bool> predicate)
        {
            return context.Priorities.Where(predicate).ToList();
        }

        public IEnumerable<Priority> GetAll()
        {
            return context.Priorities;
        }

        public void Update(Priority item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}