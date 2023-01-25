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
using ApplicationPhoneBook.Services.DeleteContact;
using ApplicationPhoneBook.Services.DetailContact;

namespace Ui_WinForm.Forms
{


	public partial class frmMain : Form
	{
		private readonly IGetContactListService _contactList;
		private readonly IDeleteContact _contacDelete;

		public frmMain(IGetContactListService contactList, IDeleteContact contacDelete)
		{
			_contactList = contactList;
			_contacDelete = contacDelete;
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
			var contactLists = _contactList.GetContactLists(txtSearchKey.Text);
			GridSetting(contactLists);
			this.Cursor = Cursors.Default;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			var result = _contacDelete.Delete(id);
			if (result.IsSuccess)
			{
				MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmMain_Load(null, null);
			}
			else
			{
				MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnDetail_Click(object sender, EventArgs e)
		{
			var id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			var addService = (IDetailContact)Program.ServiceProvider.GetService(typeof(IDetailContact))!;
			new frmContactDetails(addService, id).ShowDialog();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnDetail_Click(null, null);
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

		private void txtSearchKey_TextChanged(object sender, EventArgs e)
		{
			btnSearch_Click(null, null);
		}
	}
}
