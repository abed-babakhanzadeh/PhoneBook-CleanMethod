using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.GetContactList
{
	using ApplicationPhoneBook.DataBase;

	public class GetContactListService : IGetContactListService
	{
		private readonly IDataBaseContext _context;

		public GetContactListService(IDataBaseContext context)
		{
			_context = context;
		}

		public List<ContactListDto> GetContactLists(string SearchKey = null)
		{
			var contactsQuery = _context.Contacts.AsQueryable();

			if (!string.IsNullOrEmpty(SearchKey))
			{
				contactsQuery = contactsQuery.Where(p =>
					p.Name.Contains(SearchKey)
					||
					p.PhoneNumber.Contains(SearchKey)
					||
					p.LastName.Contains(SearchKey)
					||
					p.Company.Contains(SearchKey)
					);
				var searchList = contactsQuery.Select(p => new ContactListDto
				{
					FullName = $"{p.Name} {p.LastName}",
					PhoneNumber = p.PhoneNumber,
					Id = p.Id,
				}).ToList();
				return searchList;
			}


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
