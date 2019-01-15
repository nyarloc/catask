using System;
using System.Collections.Generic;

namespace Catask.Logic.DTO
{
    public class TaskDTO
    {
        public Guid UID { get; private set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; private set; }
        public DateTime CloseDate { get; set; }
        public Guid ParentGuid { get; set; }
        public List<Guid> ChildGuids { get; private set; }
        public byte PriorityID { get; set; }
        public short Points { get; set; }
    }
}
