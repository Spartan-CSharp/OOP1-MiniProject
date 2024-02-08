using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GuestBookLibrary.Models;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<GuestModel> guestlist = new List<GuestModel>();

			GetGuestInformation(guestlist);

			PrintOutGuestList(guestlist);

			_ = Console.ReadLine();
		}

		private static void PrintOutGuestList(List<GuestModel> guests)
		{
			foreach ( GuestModel guest in guests )
			{
				Console.WriteLine(guest.GuestMessage);
			}
		}

		private static void GetGuestInformation(List<GuestModel> guests)
		{
			string moreguestcoming;

			do
			{
				bool isagevalid;
				GuestModel guest = new GuestModel
				{
					FirstName = GetInfoFromConsole("What is your first name: "),
					LastName = GetInfoFromConsole("What is your last name: ")
				};

				do
				{
					string agetext = GetInfoFromConsole("How old are you: ");
					isagevalid = int.TryParse(agetext, out int agenumber);
					if ( !isagevalid )
					{
						Console.WriteLine("Please enter your age as a number.");
					}

					guest.Age = agenumber;
				} while ( !isagevalid );

				guest.Hometown = GetInfoFromConsole("What is your hometowm: ");
				guest.MessageToHost = GetInfoFromConsole("What is your message for the host: ");

				guests.Add(guest);

				moreguestcoming = GetInfoFromConsole("Are more guest coming (yes/no): ");

				Console.Clear();

			} while ( moreguestcoming.ToLower() == "yes" );
		}

		private static string GetInfoFromConsole(string message)
		{
			string output;

			Console.Write(message);
			output = Console.ReadLine();

			return output;
		}
	}
}
