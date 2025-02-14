﻿using System;

namespace HotelManager.DAL.Entities
{
    // факт проживания в гостинице клиента
    public class Residence : Entity
    {
        public int HotelRoomId { get; set; }
        public HotelRoom HotelRoom { get; set; } // номер

        public int ClientId { get; set; }
        public Client Client { get; set; } // клиент

        public DateTime CheckInDate { get; set; }  // дата заселения
        public DateTime? CheckOutDate { get; set; }  // дата выселения
    }
}
