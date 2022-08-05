namespace ReservationApi.Models
{
    public class Reservation : IEntity
    {
        public Train Train { get; set; }
        public int NumberofPassenger { get; set; }
        public bool IsAllowDifferentWaggons { get; set; }
    }
}
