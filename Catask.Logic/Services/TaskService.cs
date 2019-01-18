using System;
using System.Collections.Generic;
using Catask.DAL.Entities;
using Catask.DAL.Interfaces;
using Catask.Logic.DTO;
using Catask.Logic.Interfaces;
using AutoMapper;
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
                Description = taskDTO.Description,
                OpenDate = DateTime.Now,
                Points = taskDTO.Points,
                Priority = taskDTO.Priority,
                Parent = null
            };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TaskDTO Get(Guid? uid)
        {
            Task result = Database.Tasks.Find(task => task.UID == uid).SingleOrDefault();
            Task[] resultChildren = Database.Tasks.Find(task => task.Parent == result.UID).ToArray();
            return result == null ? null : new TaskDTO(result, resultChildren);
        }

        public IEnumerable<TaskDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}