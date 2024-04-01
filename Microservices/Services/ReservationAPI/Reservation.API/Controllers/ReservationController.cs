using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrasturcture;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{Id}")]
        public ReservationDTO Get(int Id)
        {
            return _reservationService.GetReservationByBkgNumber(Id);
        }
    }
}
