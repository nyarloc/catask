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
        /// <summary>
        /// Список дочерних элементов. Максимальная длина списка - 256
        /// </summary>
        public Dictionary<byte, TaskModel> OrderedChildren { get; private set; }
        public PriorityModel Priority { get; set; }
        public short Points { get; set; }

        #endregion

        public TaskModel()
        {
            UID = Guid.NewGuid();
            OpenDate = DateTime.Now;
            Priority = new PriorityModel();
        }

        /// <summary>
        /// Добавляет дочерний элемент в конец списка
        /// </summary>
        /// <param name="child"></param>
        public void AddChild(TaskModel child)
        {
            OrderedChildren.Add((byte)(OrderedChildren.Count + 1), child);
        }

        /// <summary>
        /// Добавляет дочерний элемент (подзадачу) на указанную позицию в списке
        /// </summary>
        /// <param name="child"></param>
        /// <param name="position"></param>
        public void AddChild(TaskModel child, byte position)
        {
            if (position > OrderedChildren.Count)
                throw new ArgumentOutOfRangeException("position", "Position should be less or equal to container lenght");
            else if (position == OrderedChildren.Count)
                AddChild(child);
            else
            {
                Dictionary<byte, TaskModel> temp = new Dictionary<byte, TaskModel>();
                for (byte i = 0; i < position; i++)
                    temp.Add(i, OrderedChildren[i]);
                temp.Add(position, child);
                for (byte i = position; i < OrderedChildren.Count; i++)
                    temp.Add((byte)(i + 1), OrderedChildren[i]);
                OrderedChildren = temp;
            }
        }
    }
}
