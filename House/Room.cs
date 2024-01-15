
namespace CodeAlong_Husbygg.House
{
    internal class Room
    {
        private string? Description { get; set; }

        public Room() { }

        public Room(string description)
        {
            Description = description;
        }

        public string GetDescription() 
        {
            if (Description == null)
            {
                return "Tomt rom";
            }
            else
            {
                return Description;
            }
        }

        public void SetDescription(string NewDesc)
        {
            Description = NewDesc;
        }
    }
}
