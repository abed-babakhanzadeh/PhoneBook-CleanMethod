using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.GetContactList
{
	using ApplicationPhoneBook.DataBase;

	public class GetContactList : IGetContactList
	{
		private readonly IDataBaseContext _context;

		public GetContactList(IDataBaseContext context)
		{
			_context = context;
		}

		public List<ContactListDto> GetContactLists()
		{
			var contacts = _context.Contacts.OrderBy(c => c.LastName).Select(c => new ContactListDto
				{
					Id = c.Id,
					FullName = $"{c.Name} {c.LastName}",
					PhoneNumber = c.PhoneNumber,
				}).ToList();

			return contacts;

		}
	}
}
