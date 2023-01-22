namespace ApplicationPhoneBook.Services.AddNewContact;

using ApplicationPhoneBook.DataBase;
using ApplicationPhoneBook.Dto;

using DomainPhoneBook.Entities;

public class AddNewContactService : IAddNewContactService
{
	private readonly IDataBaseContext dataBaseContext;

	public AddNewContactService(IDataBaseContext dataBaseContext)
	{
		this.dataBaseContext = dataBaseContext;
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

		dataBaseContext.Contacts.Add(contact);
		dataBaseContext.SaveChanges();
		return new ResultDto()
			       {
				       IsSuccess = true,
				       Message = $"مخاطب {contact.Name} {contact.LastName} با موفقیت ثبت شد."
			       };
	}
}