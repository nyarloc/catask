using Catask.DAL.EF;
using Catask.DAL.Entities;
using Catask.DAL.Interfaces;
using System;

namespace Catask.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private CataskContext context;
        private TaskRepository taskRepository;
        private PriorityRepository priorityRepository;
        private bool disposed = false;

        public EFUnitOfWork(string connectionString)
        {
            context = new CataskContext(connectionString);
        }

        public IRepository<Task> Tasks
        {
            get
            {
                if (taskRepository == null)
                    taskRepository = new TaskRepository(context);
                return taskRepository;
            }
        }

        public IRepository<Priority> Priorities
        {
            get
            {
                if (priorityRepository == null)
                    priorityRepository = new PriorityRepository(context);
                return priorityRepository;
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    context.Dispose();
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
