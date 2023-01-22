using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.AddNewContact
{
	using ApplicationPhoneBook.Dto;

	public interface IAddNewContactService
	{
		ResultDto Execute(AddNewContactDto addNewContactDto);
	}
}
