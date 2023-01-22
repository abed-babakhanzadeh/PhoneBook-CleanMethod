namespace ApplicationPhoneBook.Services.AddNewContact;

using ApplicationPhoneBook.DataBase;
using ApplicationPhoneBook.Dto;

using DomainPhoneBook.Entities;

public class AddNewContactService : IAddNewContactService
{
	private readonly IDataBaseContext _Context;

	public AddNewContactService(IDataBaseContext context)
	{
		_Context = context;
	}

	public ResultDto Execute(AddNewContactDto newContact)
	{
		if (string.IsNullOrEmpty(newContact.PhoneNumber))
		{
			return new ResultDto
				       {
					       IsSuccess = false,
					       Message = "لطفا شماره موبایل را وارد کنید"
				       };
		}

		Contact contact = new Contact(
			newContact.Name,
			newContact.LastName,
			newContact.Company,
			newContact.PhoneNumber,
			newContact.Description);

		_Context.Contacts.Add(contact);
		_Context.SaveChanges();
		return new ResultDto()
			       {
				       IsSuccess = true,
				       Message = $"مخاطب {contact.Name} {contact.LastName} با موفقیت ثبت شد."
			       };
	}
}