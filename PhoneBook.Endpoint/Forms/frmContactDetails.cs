using ApplicationPhoneBook.Services.DetailContact;

namespace Ui_WinForm.Forms
{
	public partial class frmContactDetails : Form
	{
		private readonly IDetailContact _detail;
		private readonly int id;

		public frmContactDetails(IDetailContact detail, int id)
		{
			InitializeComponent();
			_detail = detail;
			this.id = id;
		}

		private void frmContactDetails_Load(object sender, EventArgs e)
		{
			var res = _detail.Details(id);
			lblCompany.Text = res.Company;
			lblDescription.Text = res.Description;
			lblId.Text = res.Id.ToString();
			lblName.Text = res.Name;
			lblLastName.Text = res.LastName;
			lblTel.Text = res.PhoneNumber;
			lblCreateDate.Text = res.CreateAt.ToString();

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
