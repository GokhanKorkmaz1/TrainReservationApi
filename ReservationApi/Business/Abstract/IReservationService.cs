using ReservationApi.Models;

namespace ReservationApi.Business.Abstract
{
    public interface IReservationService
    {
        ReservationResponse Add(Reservation reservation);
    }
}
