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
        public Guid? Parent { get; set; }
        public byte Priority { get; set; }
        public short Points { get; set; }
        public string Name { get; set; }
    }
}
