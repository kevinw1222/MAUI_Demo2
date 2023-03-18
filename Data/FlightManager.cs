using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MAUI_Traveless.Data
{
	public class FlightManager
	{
		private const string FLIGHT_FILE = @"/Users/kevin1222/Desktop/SAIT/Winter_2023/CPRG_211_G/CPRG_211_GP2/MAUI_Traveless/Resources/AppData/flights.csv";

		private const string AIRPORT_FILE = @"/Users/kevin1222/Desktop/SAIT/Winter_2023/CPRG_211_G/CPRG_211_GP2/MAUI_Traveless/Resources/AppData/airports.csv";

        public static List<Flight> flights = new List<Flight>();
		public static List<Airport> airports = new List<Airport>();

		public FlightManager()
		{
			populateData();
		}

		private void populateData()
		{
			Flight flight;
			foreach (string line in File.ReadLines(FLIGHT_FILE))
			{
				string[] parts = line.Split(',');
				string flightCode = parts[0];
				string airline = parts[1];
				string fromAirportCode = parts[2];
				string toAirportCode = parts[3];
				string day = parts[4];
				string time = parts[5];
				int seat = int.Parse(parts[6]);
				double price = double.Parse(parts[7]);

				flight = new Flight(flightCode, airline, fromAirportCode, toAirportCode, day, time, seat, price);
				flights.Add(flight);
			}

			Airport airport;
			foreach (string line in File.ReadLines(AIRPORT_FILE))
			{
				string[] parts = line.Split(',');
				string airportCode = parts[0];
				string airportName = parts[1];

				airport = new Airport(airportCode, airportName);
				airports.Add(airport);
			}
		}
		public static List<Flight> GetFlights()
		{ return flights; }

		public static List<Airport> GetAirports()
		{ return airports; }
    }
}