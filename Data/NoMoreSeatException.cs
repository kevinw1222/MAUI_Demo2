using System;

namespace MAUI_Traveless.Data
{
	public class NoMoreSeatException : Exception
	{
		public NoMoreSeatException() : base("No more seat: this flihgt has sold out")
		{ }

		public NoMoreSeatException(string seat) : base("No more seat" + seat)
		{ }
	}
}
