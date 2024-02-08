using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
	public class GuestModel
	{
		public string FirstName
		{
			get; set;
		}
		public string LastName
		{
			get; set;
		}
		public int Age
		{
			get; set;
		}
		public string Hometown
		{
			get; set;
		}
		public string MessageToHost
		{
			get; set;
		}
		public string GuestMessage
		{
			get
			{
				return $"{FirstName} {LastName}, {Age}, from {Hometown}: {MessageToHost}";
			}
		}
	}
}
