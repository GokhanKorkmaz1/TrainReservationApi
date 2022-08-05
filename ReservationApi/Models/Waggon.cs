namespace ReservationApi.Models
{
    public class Waggon : IEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int NumberofReservedSeats { get; set; }

        //public Train Train { get; set; }
    }
}
