namespace PhoneBook.Endpoint
{
	using ApplicationPhoneBook.DataBase;
	using ApplicationPhoneBook.Services.AddNewContact;
	using ApplicationPhoneBook.Services.DeleteContact;
	using ApplicationPhoneBook.Services.DetailContact;
	using ApplicationPhoneBook.Services.EditContact;
	using ApplicationPhoneBook.Services.GetContactList;

	using Microsoft.Extensions.DependencyInjection;

	using PersistancePhoneBook.Context;

	using Ui_WinForm.Forms;

	internal static class Program
	{
		public static IServiceProvider ServiceProvider { get; private set; }

		/// <summary>
		/// سرویسها
		/// </summary>
		static void ConfigureServices()
		{
			var services = new ServiceCollection();

			services.AddScoped<IDataBaseContext, DataBaseContext>();
			services.AddScoped<IAddNewContactService, AddNewContactService>();
			services.AddScoped<IGetContactListService, GetContactListService>();
			services.AddScoped<IDeleteContact, DeleteContact>();
			services.AddScoped<IDetailContact, DetailContact>();
			services.AddScoped<IEditContactService, EditContactService>();

			services.AddDbContext<DataBaseContext>();

			ServiceProvider = services.BuildServiceProvider();
		}


		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ConfigureServices();
			ApplicationConfiguration.Initialize();

			var contacts = (IGetContactListService)ServiceProvider.GetService(typeof(IGetContactListService))!;
			var delete = (IDeleteContact)ServiceProvider.GetService(typeof(IDeleteContact))!;
			Application.Run(new frmMain(contacts, delete));
		}
	}
}