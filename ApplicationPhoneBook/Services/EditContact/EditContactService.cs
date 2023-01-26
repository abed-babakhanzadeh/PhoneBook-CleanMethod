using ApplicationPhoneBook.DataBase;
using ApplicationPhoneBook.Dto;
using DomainPhoneBook.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Xml.Linq;

namespace ApplicationPhoneBook.Services.EditContact
{
	public class EditContactService : IEditContactService
	{
		private readonly IDataBaseContext _context;

		public EditContactService(IDataBaseContext context)
		{
			_context = context;
        }


        public ResultDto EditContact(EditContactDto editContact, int id)
        {
           


            //    (
            //    editContact.Name,
            //    editContact.LastName,
            //    editContact.Company,
            //    editContact.PhoneNumber,
            //editContact.Description);
            _context.Contacts.Find(id).Update(LastName:editContact.LastName, Name:editContact.Name, PhoneNumber:editContact.PhoneNumber, Description:editContact.Description, Company:editContact.Company);
            //_context.Contacts.Update(editContact);
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"مخاطب {editContact.Name} {editContact.LastName} با موفقیت ثبت شد."
            };

		}

	}
}
