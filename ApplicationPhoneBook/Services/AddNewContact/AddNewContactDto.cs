using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.AddNewContact
{
	using System.ComponentModel.DataAnnotations;

	public class AddNewContactDto
	{
		[Display(Name = "نام")]
		public string Name { get; set; }

		[Display(Name = "نام خانوادگی")]
		public string LastName { get; set; }

		[Display(Name = "شرکت")]
		public string Company { get; set; }

		[Display(Name = "شماره تلفن")]
		public string PhoneNumber { get; set; }

		[Display(Name = "توضیحات")]
		public string Description { get; set; }
	}
}
