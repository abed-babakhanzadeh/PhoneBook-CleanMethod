using ApplicationPhoneBook.Services.DetailContact;
using ApplicationPhoneBook.Services.EditContact;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ui_WinForm.Forms
{
	public partial class frmEditContact : Form
	{
		private readonly int contactId;
		private readonly IEditContactService editService;
		private readonly IDetailContact detail;

		public frmEditContact(int contactId, IEditContactService editService, IDetailContact detail)
		{
			InitializeComponent();
			this.contactId = contactId;
			this.editService = editService;
			this.detail = detail;
		}

		private void frmEditContact_Load(object sender, EventArgs e)
		{
			var res = detail.Details(contactId);
			txtCompany.Text = res.Company;
			txtDescription.Text = res.Description;
			txtName.Text = res.Name;
			txtLastName.Text = res.LastName;
			txtPhoneNumber.Text = res.PhoneNumber;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEditContact_Click(object sender, EventArgs e)
		{
			EditContactDto contact = new EditContactDto
			{
				Company = txtCompany.Text,
				Description = txtDescription.Text,
				LastName = txtLastName.Text,
				Name = txtName.Text,
				PhoneNumber = txtPhoneNumber.Text,
			};
			editService.EditContact(contact, contactId);
			this.Close();
		}
	}
}
