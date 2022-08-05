namespace ReservationApi.Models
{
    public class ReservationResponse : IEntity
    {
        public ReservationResponse()
        {
            PlacementDetails = new List<PlacementDetail>();
        }
        public bool IsReservable { get; set; }

        public List<PlacementDetail> PlacementDetails { get; set; }
    }
}
