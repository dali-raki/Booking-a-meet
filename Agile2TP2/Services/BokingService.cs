
namespace Agile2TP2.Services
{
    using System.Collections.Generic;
    using Agile2TP2.Models;
	public class BokingService
    {
		BokingModel BokingModel { get; set; }


		public void addMeeting(List<BokingModel> lsitBooking, BokingModel userinput)
		{
			lsitBooking.Add(userinput);
		}


        public bool IsBookingConflict(List<BokingModel> listBooking, BokingModel newBooking)
        {
            return listBooking.Any(existingBooking =>
                existingBooking.room == newBooking.room &&
                existingBooking.date.Date == newBooking.date.Date &&
                ((newBooking.date >= existingBooking.date && newBooking.date < existingBooking.date.AddHours(existingBooking.hour)) ||
                 (existingBooking.date >= newBooking.date && existingBooking.date < newBooking.date.AddHours(newBooking.hour))));
        }

    }
}
