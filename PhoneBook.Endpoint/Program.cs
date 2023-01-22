namespace PhoneBook.Endpoint
{
	using ApplicationPhoneBook.DataBase;
	using ApplicationPhoneBook.Services.AddNewContact;

	using Microsoft.Extensions.DependencyInjection;

	using PersistancePhoneBook.Context;

	using Ui_WinForm.Forms;

	internal static class Program
	{
		public static IServiceProvider ServiceProvider { get; private set; }

		static void ConfigureServices()
		{
			var services = new ServiceCollection();
			services.AddScoped<IDataBaseContext, DataBaseContext>();
			services.AddScoped<IAddNewContactService, AddNewContactService>();

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
			Application.Run(new frmMain());
		}
	}
}