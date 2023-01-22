using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistancePhoneBook.Context
{
	using ApplicationPhoneBook.DataBase;

	using DomainPhoneBook.Entities;

	using Microsoft.EntityFrameworkCore;

	public class DataBaseContext:DbContext, IDataBaseContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=NewDbContact;Integrated Security = SSPI;TrustServerCertificate=True;MultipleActiveResultSets=true;");
		}

		public DbSet<Contact> Contacts { get; set; }
	}
}
