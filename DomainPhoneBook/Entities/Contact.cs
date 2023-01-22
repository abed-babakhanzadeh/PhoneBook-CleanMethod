using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainPhoneBook.Entities
{
	using System.ComponentModel.DataAnnotations;

	public class Contact
	{
		[Display(Name = "شناسه")]
		public int Id { get; set; }

		[Display(Name = "نام")]
		public string Name { get; private set; }

		[Display(Name = "نام خانوادگی")]
		public string LastName { get; private set; }

		[Display(Name = "شرکت")]
		public string Company { get; private set; }

		[Display(Name = "شماره تلفن")]
		public string PhoneNumber { get; private set; }

		[Display(Name = "توضیحات")]
		public string Description { get; private set; }

		[Display(Name = "تاریخ ایجاد")]
		public DateTime CreateAt { get; private set; }

		public Contact()
		{
				
		}

		public Contact(string Name, string LastName, string Company, string PhoneNumber, string Description)
		{
				this.Name = Name;
				this.LastName = LastName;
				this.Company = Company;
				this.PhoneNumber = PhoneNumber;
				this.Description = Description;
				this.CreateAt = DateTime.Now;
		}

		public void Update(string Name, string LastName, string Company, string PhoneNumber, string Description)
		{
			this.Name = Name;
			this.LastName = LastName;
			this.Company = Company;
			this.PhoneNumber = PhoneNumber;
			this.Description = Description;
		}
	}
}
