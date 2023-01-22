namespace Ui_WinForm.Forms
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtSearchKey = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDetail = new System.Windows.Forms.Button();
			this.btnAddContact = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnEditContact = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 159);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 100;
			this.dataGridView1.RowTemplate.Height = 31;
			this.dataGridView1.Size = new System.Drawing.Size(741, 570);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// txtSearchKey
			// 
			this.txtSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearchKey.Location = new System.Drawing.Point(295, 23);
			this.txtSearchKey.Name = "txtSearchKey";
			this.txtSearchKey.Size = new System.Drawing.Size(307, 42);
			this.txtSearchKey.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(608, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "جست و جو";
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.BackColor = System.Drawing.Color.LimeGreen;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.Location = new System.Drawing.Point(168, 23);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(121, 42);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "بیاب";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BackColor = System.Drawing.Color.Red;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.Font = new System.Drawing.Font("IRANSansX", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(6, 32);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(125, 44);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "حذف مخاطب";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnDetail
			// 
			this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDetail.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDetail.Location = new System.Drawing.Point(381, 33);
			this.btnDetail.Name = "btnDetail";
			this.btnDetail.Size = new System.Drawing.Size(161, 43);
			this.btnDetail.TabIndex = 5;
			this.btnDetail.Text = "نمایش جزئیات";
			this.btnDetail.UseVisualStyleBackColor = false;
			this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
			// 
			// btnAddContact
			// 
			this.btnAddContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddContact.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnAddContact.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddContact.Location = new System.Drawing.Point(548, 33);
			this.btnAddContact.Name = "btnAddContact";
			this.btnAddContact.Size = new System.Drawing.Size(163, 43);
			this.btnAddContact.TabIndex = 6;
			this.btnAddContact.Text = "افزودن مخاطب";
			this.btnAddContact.UseVisualStyleBackColor = false;
			this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnEditContact);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnAddContact);
			this.groupBox1.Controls.Add(this.btnDetail);
			this.groupBox1.Location = new System.Drawing.Point(12, 71);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(717, 82);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// btnEditContact
			// 
			this.btnEditContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditContact.BackColor = System.Drawing.Color.Moccasin;
			this.btnEditContact.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditContact.Location = new System.Drawing.Point(200, 33);
			this.btnEditContact.Name = "btnEditContact";
			this.btnEditContact.Size = new System.Drawing.Size(175, 43);
			this.btnEditContact.TabIndex = 7;
			this.btnEditContact.Text = "ویرایش مخاطب";
			this.btnEditContact.UseVisualStyleBackColor = false;
			this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 729);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSearchKey);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("IRANSansX", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "دفترچه تلفن";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dataGridView1;
		private TextBox txtSearchKey;
		private Label label1;
		private Button btnSearch;
		private Button btnDelete;
		private Button btnDetail;
		private Button btnAddContact;
		private GroupBox groupBox1;
		private Button btnEditContact;
	}
}