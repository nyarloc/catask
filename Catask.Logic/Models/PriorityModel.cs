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
    }
}