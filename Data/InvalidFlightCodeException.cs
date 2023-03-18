using System;
namespace MAUI_Traveless.Data
{
	public class InvalidFlightCodeException : Exception
	{
		public InvalidFlightCodeException() : base("Invalid Flight Code: Flight Code can't be empty") { }
    }
}

