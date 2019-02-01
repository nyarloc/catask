using Catask.Logic.DTO;
using System;
using System.Collections.Generic;

namespace Catask.Logic.Interfaces
{
    public interface ITaskService
    {
        void Create(TaskDTO task);
        TaskDTO Get(Guid uid);
        IEnumerable<TaskDTO> GetAll();
        void Dispose();
    }
}