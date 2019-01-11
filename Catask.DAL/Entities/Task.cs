using System;
using System.Collections.Generic;

namespace Catask.DAL.Entities
{
    public class Task
    {
        public Guid UID { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public Task Parent { get; set; }
        public List<Task> Children { get; private set; }
        public Priority Priority { get; set; }
        public short Points { get; set; }
    }
}
