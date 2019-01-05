namespace Catask.Logic.Models
{
    public class PriorityModel
    {
        public byte ID { get; set; }
        public string Name { get; set; }

        public PriorityModel()
        {
            ID = 255;
            Name = "Не задан";
        }

        public bool IsHigher(PriorityModel other)
        {
            return ID < other.ID;
        }

        public override bool Equals(object obj)
        {
            if (!(this is PriorityModel)) return false;
            PriorityModel other = (PriorityModel)obj;
            return ID == other.ID && Name == other.Name;
        }
    }
}