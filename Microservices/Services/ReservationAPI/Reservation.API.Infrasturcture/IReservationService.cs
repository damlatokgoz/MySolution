﻿using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Infrasturcture
{
    public interface IReservationService
    {
        public ReservationDTO GetReservationByBkgNumber(int bkgNumber);
    }
}
