namespace GUI
{
	partial class FormMenu
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lb_fullName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btn_manager = new System.Windows.Forms.Button();
			this.btn_SignUpAccount = new System.Windows.Forms.Button();
			this.btn_changeInfo = new System.Windows.Forms.Button();
			this.btn_tranHistory = new System.Windows.Forms.Button();
			this.btn_transaction = new System.Windows.Forms.Button();
			this.btn_logOut = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Location = new System.Drawing.Point(-8, -4);
			this.panel1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(322, 562);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btn_SignUpAccount);
			this.panel3.Controls.Add(this.btn_changeInfo);
			this.panel3.Controls.Add(this.btn_tranHistory);
			this.panel3.Controls.Add(this.btn_transaction);
			this.panel3.Controls.Add(this.btn_logOut);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 116);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(322, 446);
			this.panel3.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(322, 116);
			this.panel2.TabIndex = 6;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.lb_fullName);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 45);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(322, 71);
			this.panel4.TabIndex = 1;
			// 
			// lb_fullName
			// 
			this.lb_fullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_fullName.AutoSize = true;
			this.lb_fullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lb_fullName.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_fullName.Location = new System.Drawing.Point(128, 12);
			this.lb_fullName.Name = "lb_fullName";
			this.lb_fullName.Size = new System.Drawing.Size(0, 34);
			this.lb_fullName.TabIndex = 1;
			this.lb_fullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(74, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome back!";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(62, 1234);
			this.button2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(368, 217);
			this.button2.TabIndex = 1;
			this.button2.Text = "Change Info";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// panel5
			// 
			this.panel5.BackgroundImage = global::GUI.Properties.Resources._595523046_03ec94;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(309, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(731, 644);
			this.panel5.TabIndex = 1;
			// 
			// btn_manager
			// 
			this.btn_manager.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_manager.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_manager.Image = global::GUI.Properties.Resources.icons8_admin_settings_male_321;
			this.btn_manager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_manager.Location = new System.Drawing.Point(-6, 554);
			this.btn_manager.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.btn_manager.Name = "btn_manager";
			this.btn_manager.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btn_manager.Size = new System.Drawing.Size(320, 93);
			this.btn_manager.TabIndex = 6;
			this.btn_manager.Text = "       Manager Only";
			this.btn_manager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_manager.UseVisualStyleBackColor = false;
			this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
			// 
			// btn_SignUpAccount
			// 
			this.btn_SignUpAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_SignUpAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_SignUpAccount.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_SignUpAccount.Image = global::GUI.Properties.Resources.icons8_bank_account_32;
			this.btn_SignUpAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_SignUpAccount.Location = new System.Drawing.Point(6, 175);
			this.btn_SignUpAccount.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.btn_SignUpAccount.Name = "btn_SignUpAccount";
			this.btn_SignUpAccount.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btn_SignUpAccount.Size = new System.Drawing.Size(316, 93);
			this.btn_SignUpAccount.TabIndex = 7;
			this.btn_SignUpAccount.Text = "       Create New Account";
			this.btn_SignUpAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_SignUpAccount.UseVisualStyleBackColor = false;
			this.btn_SignUpAccount.Click += new System.EventHandler(this.btn_SignUpAccount_Click);
			// 
			// btn_changeInfo
			// 
			this.btn_changeInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_changeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_changeInfo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_changeInfo.Image = global::GUI.Properties.Resources.icons8_info_32;
			this.btn_changeInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_changeInfo.Location = new System.Drawing.Point(2, 355);
			this.btn_changeInfo.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.btn_changeInfo.Name = "btn_changeInfo";
			this.btn_changeInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btn_changeInfo.Size = new System.Drawing.Size(320, 89);
			this.btn_changeInfo.TabIndex = 2;
			this.btn_changeInfo.Text = "      Change Info";
			this.btn_changeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_changeInfo.UseVisualStyleBackColor = false;
			this.btn_changeInfo.Click += new System.EventHandler(this.btn_changeInfo_Click);
			// 
			// btn_tranHistory
			// 
			this.btn_tranHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_tranHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_tranHistory.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tranHistory.Image = global::GUI.Properties.Resources.icons8_transaction_history_32;
			this.btn_tranHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_tranHistory.Location = new System.Drawing.Point(6, 88);
			this.btn_tranHistory.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.btn_tranHistory.Name = "btn_tranHistory";
			this.btn_tranHistory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btn_tranHistory.Size = new System.Drawing.Size(316, 89);
			this.btn_tranHistory.TabIndex = 4;
			this.btn_tranHistory.Text = "    Transaction History";
			this.btn_tranHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_tranHistory.UseVisualStyleBackColor = false;
			this.btn_tranHistory.Click += new System.EventHandler(this.btn_tranHistory_Click);
			// 
			// btn_transaction
			// 
			this.btn_transaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_transaction.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_transaction.Image = global::GUI.Properties.Resources.icons8_transaction_24;
			this.btn_transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_transaction.Location = new System.Drawing.Point(0, 0);
			this.btn_transaction.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.btn_transaction.Name = "btn_transaction";
			this.btn_transaction.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btn_transaction.Size = new System.Drawing.Size(322, 89);
			this.btn_transaction.TabIndex = 5;
			this.btn_transaction.Text = "   Transaction";
			this.btn_transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_transaction.UseVisualStyleBackColor = true;
			this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
			// 
			// btn_logOut
			// 
			this.btn_logOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_logOut.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_logOut.Image = global::GUI.Properties.Resources.icons8_logout_32;
			this.btn_logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_logOut.Location = new System.Drawing.Point(2, 267);
			this.btn_logOut.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.btn_logOut.Name = "btn_logOut";
			this.btn_logOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btn_logOut.Size = new System.Drawing.Size(320, 89);
			this.btn_logOut.TabIndex = 3;
			this.btn_logOut.Text = "    Log Out";
			this.btn_logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_logOut.UseVisualStyleBackColor = false;
			this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 34);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mr/Mrs";
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 49F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1040, 644);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.btn_manager);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMenu";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_transaction;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_logOut;
		private System.Windows.Forms.Button btn_changeInfo;
		private System.Windows.Forms.Button btn_tranHistory;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lb_fullName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn_manager;
		private System.Windows.Forms.Button btn_SignUpAccount;
		private System.Windows.Forms.Label label2;
	}
}