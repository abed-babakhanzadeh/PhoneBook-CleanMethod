using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui_WinForm.Forms
{
	using ApplicationPhoneBook.Services.AddNewContact;

	using PhoneBook.Endpoint;
	using PhoneBook.Endpoint.Forms;

	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

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
			var addService = (IAddNewContactService)Program.ServiceProvider.GetService(typeof(IAddNewContactService));
			new frmAddContact(addService).ShowDialog();
			frmMain_Load(null,null);
		}

		private void btnEditContact_Click(object sender, EventArgs e)
		{

		}
	}
}
