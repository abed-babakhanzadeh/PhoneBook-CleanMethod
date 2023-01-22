using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ApplicationPhoneBook.Services.GetContactList
{
	public class ContactListDto
	{
		[Display(Name = "شناسه")]
		public int Id { get; set; }

		[Display(Name = "نام و نام خانوادگی")]
		public string FullName { get; set; }

		[Display(Name = "شماره تلفن")]
		public string PhoneNumber { get; set; }
	}
}
