using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationApi.Business.Abstract;
using ReservationApi.Models;

namespace ReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]Reservation reservation)
        {
            var reservationResponse = _reservationService.Add(reservation);
            return Ok(reservationResponse);
        }

    }
}
