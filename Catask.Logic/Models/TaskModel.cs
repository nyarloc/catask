using System;
using System.Collections.Generic;

namespace Catask.Logic.Models
{
    class TaskModel
    {
        #region properties

        public Guid UID { get; private set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; private set; }
        public DateTime CloseDate { get; set; }
        public TaskModel Parent { get; set; }
        public List<TaskModel> Children { get; private set; }
        public PriorityModel Priority { get; set; }
        public short Points { get; set; }

        #endregion

        public TaskModel()
        {
            UID = Guid.NewGuid();
            OpenDate = DateTime.Now;
            Priority = new PriorityModel();
        }
    }
}