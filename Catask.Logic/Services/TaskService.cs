using System;
using System.Collections.Generic;
using Catask.DAL.Entities;
using Catask.DAL.Interfaces;
using Catask.Logic.DTO;
using Catask.Logic.Interfaces;
using System.Linq;

namespace Catask.Logic.Services
{
    public class TaskService : ITaskService
    {
        IUnitOfWork Database { get; set; }

        public TaskService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Create(TaskDTO taskDTO)
        {
            Task task = new Task
            {
                UID = new Guid(),
                Name = taskDTO.Name,
                Description = taskDTO.Description,
                OpenDate = DateTime.Now,
                Points = taskDTO.Points,
                Priority = taskDTO.Priority,
                Parent = null
            };
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public TaskDTO Get(Guid uid)
        {
            Task result = Database.Tasks.Find(task => task.UID == uid).SingleOrDefault();
            Task[] resultChildren = Database.Tasks.Find(task => task.Parent == result.UID).ToArray();
            return result == null ? null : new TaskDTO(result, resultChildren);
        }

        public IEnumerable<TaskDTO> GetAll()
        {
            Task[] tasks = Database.Tasks.GetAll().ToArray();
            return tasks.Select(task => new TaskDTO(task, tasks.Where(child => child.Parent == task.UID).ToArray()));
        }

        public void Close(TaskDTO task)
        {
            throw new NotImplementedException();
        }
    }
}