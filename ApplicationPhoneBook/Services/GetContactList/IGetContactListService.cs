using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.GetContactList
{
	public interface IGetContactListService
	{
		List<ContactListDto> GetContactLists(string SearchKey = null);

	}
}
