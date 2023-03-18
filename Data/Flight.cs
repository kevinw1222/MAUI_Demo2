using System;
namespace MAUI_Traveless.Data
{
	public class Flight
	{
		private string flightCode;
		private string airline;
		private string fromAirportCode;
		private string toAirportCode;
		private string day;
		private string time;
		private int seat;
		private double price;

		public string FlightCode { get; set; }
		public string Airline { get; set; }
		public string FromAirportCode { get; set; }
		public string ToAirportCode { get; set; }
		public string Day { get; set; }
		public string Time { get; set; }
		public int Seat { get; set; }
		public double Price { get; set; }

		public Flight(string flightCode, string airline, string fromAirportCode, string toAirportCode, string day, string time, int seat, double price)
		{
			this.FlightCode = flightCode;
			this.Airline = airline;
			this.FromAirportCode = fromAirportCode;
			this.ToAirportCode = toAirportCode;
			this.Day = day;
			this.Time = time;
			this.Seat = seat;
			this.Price = price;
		}
	}
	public class Airport
	{
		private string airportCode;
		private string airportName;

		public string AirportCode { get; set; }
		public string AirportName { get; set; }

		public Airport(string airportCode, string airportName)
		{
			this.AirportCode = airportCode;
			this.AirportName = airportName;
		}
	}
}

