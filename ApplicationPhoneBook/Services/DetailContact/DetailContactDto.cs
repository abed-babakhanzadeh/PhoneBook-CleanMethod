using System.ComponentModel.DataAnnotations;

namespace ApplicationPhoneBook.Services.DetailContact
{
	public class DetailContactDto
	{
		[Display(Name = "شناسه")]
		public int Id { get; set; }

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

		[Display(Name = "تاریخ ایجاد")]
		public DateTime CreateAt { get; set; }
	}
}
