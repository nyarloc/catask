using Catask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Catask.Logic.DTO
{
    public class TaskDTO
    {
        public Guid UID { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public List<TaskDTO> Children { get; set; }
        public byte Priority { get; set; }
        public short Points { get; set; }

        public TaskDTO(Task task, Task[] children = null)
        {
            UID = task.UID;
            Description = task.Description;
            OpenDate = task.OpenDate;
            CloseDate = task.CloseDate;
            Children = children == null ? null : new List<TaskDTO>(children.Select(child => new TaskDTO(child)));
            Priority = task.Priority;
            Points = task.Points;
        }
    }
}
