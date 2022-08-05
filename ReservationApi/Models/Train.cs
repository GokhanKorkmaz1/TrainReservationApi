namespace ReservationApi.Models
{
    public class Train : IEntity
    {
        public Train()
        {
            Waggons = new List<Waggon>();
        }
        public string Name { get; set; }

        public List<Waggon> Waggons { get; set; }
    }
}
