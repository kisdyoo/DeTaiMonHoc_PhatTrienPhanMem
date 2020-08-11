namespace GUI
{
	partial class frmDangNhap
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblDangNhap = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(295, 191);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(151, 47);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "HỦY";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(74, 191);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(145, 47);
			this.btnLogin.TabIndex = 12;
			this.btnLogin.Text = "ĐĂNG NHẬP";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(70, 136);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(83, 20);
			this.lblPassword.TabIndex = 11;
			this.lblPassword.Text = "Password";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.Location = new System.Drawing.Point(70, 91);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(94, 20);
			this.lblUserName.TabIndex = 10;
			this.lblUserName.Text = "User Name";
			// 
			// lblDangNhap
			// 
			this.lblDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDangNhap.AutoSize = true;
			this.lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDangNhap.Location = new System.Drawing.Point(122, 31);
			this.lblDangNhap.Name = "lblDangNhap";
			this.lblDangNhap.Size = new System.Drawing.Size(256, 25);
			this.lblDangNhap.TabIndex = 9;
			this.lblDangNhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(198, 133);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(248, 32);
			this.txtPassword.TabIndex = 8;
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(198, 88);
			this.txtUserName.Multiline = true;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(248, 34);
			this.txtUserName.TabIndex = 7;
			// 
			// frmDangNhap
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 269);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.lblDangNhap);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Name = "frmDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDangNhap";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhap_FormClosed_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblDangNhap;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
	}
}