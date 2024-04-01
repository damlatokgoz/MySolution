using Reservation.API.Infrasturcture;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService :IReservationService
    {
        public ReservationDTO GetReservationByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO
            {
                Id = (new Random()).Next(100),
                BkgDate = DateTime.Now,
                CheckInDate = DateTime.Now,
                CheckOutDate = DateTime.Now,
                Amount = (new Random()).Next(1000),
                BkgNumber = bkgNumber
            };
        }
    }
}
