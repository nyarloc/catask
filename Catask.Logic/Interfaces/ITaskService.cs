using Catask.Logic.DTO;
using System;
using System.Collections.Generic;

namespace Catask.Logic.Interfaces
{
    public interface ITaskService
    {
        void CreateTask(TaskDTO task);
        TaskDTO GetTask(Guid? uid);
        IEnumerable<TaskDTO> GetTasks();
        void Dispose();
    }
}