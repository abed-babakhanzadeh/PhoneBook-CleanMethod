using ApplicationPhoneBook.DataBase;
using ApplicationPhoneBook.Services.GetContactList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.DetailContact
{
	public class DetailContact : IDetailContact
	{
		private readonly IDataBaseContext _context;

		public DetailContact(IDataBaseContext context)
		{
			_context = context;
		}


		public DetailContactDto Details(int id)
		{
			var contact = _context.Contacts.Find(id);
			DetailContactDto detail = new DetailContactDto(){
				Id= id,
				Company = contact.Company,
				CreateAt= contact.CreateAt,
				Description= contact.Description,
				LastName= contact.LastName,
				Name= contact.Name,
				PhoneNumber = contact.PhoneNumber
			};
			return detail;

		}

	}
}
