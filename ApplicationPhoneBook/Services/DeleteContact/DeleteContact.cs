using ApplicationPhoneBook.DataBase;
using ApplicationPhoneBook.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.DeleteContact
{
	public class DeleteContact : IDeleteContact
	{
		private readonly IDataBaseContext _context;

		public DeleteContact(IDataBaseContext context)
		{
			_context = context;
		}
		public ResultDto Delete(int id)
		{
			var cnt = _context.Contacts.Find(id);
			if (cnt != null)
			{
				_context.Contacts.Remove(cnt);
				_context.SaveChanges();
				return new ResultDto
				{
					IsSuccess = true,
					Message = "حذف با موفقیت انجام شد."
				};
			}
			else
			{
				return new ResultDto
				{
					IsSuccess = false,
					Message="مخاطب یافت نشد"
				};
			}

		}


	}
}
