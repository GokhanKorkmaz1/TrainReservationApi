namespace ReservationApi.Models
{
    public class PlacementDetail : IEntity
    {
        public string WaggonName { get; set; }
        public int NumberofPeople { get; set; }

        //public ReservationResponse ReservationResponse { get; set; }
    }
}
