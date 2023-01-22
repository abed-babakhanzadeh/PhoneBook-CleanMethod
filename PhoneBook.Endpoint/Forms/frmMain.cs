using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationPhoneBook.Services.AddNewContact;
using PhoneBook.Endpoint;
using PhoneBook.Endpoint.Forms;
using ApplicationPhoneBook.Services.GetContactList;


namespace Ui_WinForm.Forms
{
	

	public partial class frmMain : Form
	{
		private readonly IGetContactList _contactList;

		public frmMain(IGetContactList contactList)
		{
			_contactList = contactList;
			InitializeComponent();
		}


		private void frmMain_Load(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			var contacts = _contactList.GetContactLists();
			GridSetting(contacts);


			this.Cursor = Cursors.Default;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			this.Cursor = Cursors.Default;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnDetail_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}


		private void btnAddContact_Click(object sender, EventArgs e)
		{
			var addService = (IAddNewContactService)Program.ServiceProvider.GetService(typeof(IAddNewContactService))!;
			new frmAddContact(addService).ShowDialog();
			frmMain_Load(null!, null!);
		}

		private void btnEditContact_Click(object sender, EventArgs e)
		{

		}


		private void GridSetting(List<ContactListDto> contactList)
		{
			dataGridView1.DataSource = contactList;

			dataGridView1.Columns[0].HeaderText = @"شناسه";
			dataGridView1.Columns[1].HeaderText = @"نام و نام خانوادگی";
			dataGridView1.Columns[2].HeaderText = @"شماره تلفن";
		}
	}
}
