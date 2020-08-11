namespace GUI
{
	partial class SetCauHinh
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
			this.cboDatabase = new System.Windows.Forms.ComboBox();
			this.cboServerList = new System.Windows.Forms.ComboBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblDatabase = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.serverName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cboDatabase
			// 
			this.cboDatabase.FormattingEnabled = true;
			this.cboDatabase.Location = new System.Drawing.Point(148, 131);
			this.cboDatabase.Margin = new System.Windows.Forms.Padding(4);
			this.cboDatabase.Name = "cboDatabase";
			this.cboDatabase.Size = new System.Drawing.Size(237, 24);
			this.cboDatabase.TabIndex = 19;
			// 
			// cboServerList
			// 
			this.cboServerList.FormattingEnabled = true;
			this.cboServerList.Location = new System.Drawing.Point(148, 13);
			this.cboServerList.Margin = new System.Windows.Forms.Padding(4);
			this.cboServerList.Name = "cboServerList";
			this.cboServerList.Size = new System.Drawing.Size(237, 24);
			this.cboServerList.TabIndex = 18;
			this.cboServerList.SelectedIndexChanged += new System.EventHandler(this.cboServerList_SelectedIndexChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(148, 91);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(237, 22);
			this.txtPassword.TabIndex = 17;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(148, 52);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(237, 22);
			this.txtUserName.TabIndex = 16;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(289, 168);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 42);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Hủy bỏ";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(148, 168);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 42);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Lưu lại";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// lblDatabase
			// 
			this.lblDatabase.AutoSize = true;
			this.lblDatabase.Location = new System.Drawing.Point(44, 135);
			this.lblDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDatabase.Name = "lblDatabase";
			this.lblDatabase.Size = new System.Drawing.Size(73, 17);
			this.lblDatabase.TabIndex = 13;
			this.lblDatabase.Text = "Database:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(44, 95);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(73, 17);
			this.lblPassword.TabIndex = 12;
			this.lblPassword.Text = "Password:";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(44, 56);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(81, 17);
			this.lblUsername.TabIndex = 11;
			this.lblUsername.Text = "User name:";
			// 
			// serverName
			// 
			this.serverName.AutoSize = true;
			this.serverName.Location = new System.Drawing.Point(44, 16);
			this.serverName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.serverName.Name = "serverName";
			this.serverName.Size = new System.Drawing.Size(95, 17);
			this.serverName.TabIndex = 10;
			this.serverName.Text = "Server Name:";
			// 
			// SetCauHinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 223);
			this.Controls.Add(this.cboDatabase);
			this.Controls.Add(this.cboServerList);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblDatabase);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.serverName);
			this.Name = "SetCauHinh";
			this.Text = "SetCauHinh";
			this.Load += new System.EventHandler(this.SetCauHinh_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboDatabase;
		private System.Windows.Forms.ComboBox cboServerList;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblDatabase;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label serverName;
	}
}