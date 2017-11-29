using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.FormFlow;

namespace PlayWith.BotApp.HotelBot.Models
{
    public enum BedSizeOptions
    {
        King,
        Queen,
        Double,
        Single
    }

    [Serializable]
    public class RoomReservation
    {
        public BedSizeOptions? BedSize;
        public int? NumberOfOccupants;
        public static IForm<RoomReservation> BuildForm()
        {
            return new FormBuilder<RoomReservation>()
                .Message("Welcome to the hotel reservation bot.")
                .Build();
        }
    }
}