using ApplicationPhoneBook.Services.GetContactList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.DetailContact
{
	public interface IDetailContact
	{
		DetailContactDto Details(int id);
	}
}
