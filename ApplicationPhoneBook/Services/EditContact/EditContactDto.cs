using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ApplicationPhoneBook.Services.EditContact
{
	public class EditContactDto
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
