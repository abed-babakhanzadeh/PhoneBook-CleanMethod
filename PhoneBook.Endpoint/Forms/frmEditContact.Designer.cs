namespace Ui_WinForm.Forms
{
	partial class frmEditContact
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
			this.btnBack = new System.Windows.Forms.Button();
			this.btnEditContact = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtCompany = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(301, 624);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(176, 36);
			this.btnBack.TabIndex = 25;
			this.btnBack.Text = "بازگشت";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnEditContact
			// 
			this.btnEditContact.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditContact.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEditContact.Location = new System.Drawing.Point(76, 624);
			this.btnEditContact.Name = "btnEditContact";
			this.btnEditContact.Size = new System.Drawing.Size(176, 36);
			this.btnEditContact.TabIndex = 24;
			this.btnEditContact.Text = "ثبت تغییرات";
			this.btnEditContact.UseVisualStyleBackColor = true;
			this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtDescription.Location = new System.Drawing.Point(181, 427);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(296, 147);
			this.txtDescription.TabIndex = 23;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPhoneNumber.Location = new System.Drawing.Point(181, 359);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(296, 37);
			this.txtPhoneNumber.TabIndex = 22;
			// 
			// txtCompany
			// 
			this.txtCompany.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtCompany.Location = new System.Drawing.Point(181, 288);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.Size = new System.Drawing.Size(296, 37);
			this.txtCompany.TabIndex = 21;
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtLastName.Location = new System.Drawing.Point(181, 217);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(296, 37);
			this.txtLastName.TabIndex = 20;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtName.Location = new System.Drawing.Point(181, 142);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(296, 37);
			this.txtName.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(34, 362);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 30);
			this.label6.TabIndex = 18;
			this.label6.Text = "شماره تلفن";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(46, 430);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 30);
			this.label5.TabIndex = 17;
			this.label5.Text = "توضیحات";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(76, 291);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 30);
			this.label4.TabIndex = 16;
			this.label4.Text = "شرکت";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(27, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 30);
			this.label3.TabIndex = 15;
			this.label3.Text = "نام خانوادگی";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("IRANSansX", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(102, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 30);
			this.label2.TabIndex = 14;
			this.label2.Text = "نام";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("IRANSansX", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(130, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 40);
			this.label1.TabIndex = 13;
			this.label1.Text = "ویرایش اطلاعات مخاطب";
			// 
			// frmEditContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(537, 683);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnEditContact);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtCompany);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmEditContact";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmEditContact";
			this.Load += new System.EventHandler(this.frmEditContact_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnBack;
		private Button btnEditContact;
		private TextBox txtDescription;
		private TextBox txtPhoneNumber;
		private TextBox txtCompany;
		private TextBox txtLastName;
		private TextBox txtName;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
	}
}