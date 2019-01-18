using Catask.DAL.EF;
using Catask.DAL.Entities;
using Catask.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Catask.DAL.Repositories
{
    public class TaskRepository : IRepository<Task>
    {
        private CataskContext context;

        public TaskRepository(CataskContext context)
        {
            this.context = context;
        }

        public void Create(Task item)
        {
            context.Tasks.Add(item);
        }

        public void Delete(Task item)
        {
            context.Tasks.Remove(item);
        }

        public IEnumerable<Task> Find(Func<Task, bool> predicate)
        {
            return context.Tasks.Where(predicate).ToList();
        }

        public IEnumerable<Task> GetAll()
        {
            return context.Tasks;
        }

        public void Update(Task item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}