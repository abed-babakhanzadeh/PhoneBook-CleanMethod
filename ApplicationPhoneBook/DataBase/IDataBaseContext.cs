using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.DataBase
{
	using DomainPhoneBook.Entities;

	using Microsoft.EntityFrameworkCore;

	public interface IDataBaseContext
	{
		public DbSet<Contact> Contacts { get; set; }

		public int SaveChanges();
	}
}
