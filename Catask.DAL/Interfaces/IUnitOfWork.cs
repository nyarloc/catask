using Catask.DAL.Entities;
using System;

namespace Catask.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Task> Tasks { get; }
        void Save();
    }
}