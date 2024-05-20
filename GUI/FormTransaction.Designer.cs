namespace GUI
{
	partial class FormTransaction
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
			this.tab_payInto = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btn_submit = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_money = new System.Windows.Forms.TextBox();
			this.txt_accountTranfer = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lb_money = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cb_bankTranfer = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_account = new System.Windows.Forms.ComboBox();
			this.cb_bank = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.rbtn_withdraw = new System.Windows.Forms.RadioButton();
			this.rbtn_deposit = new System.Windows.Forms.RadioButton();
			this.txt_moneyDW = new System.Windows.Forms.TextBox();
			this.btn_doneDW = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.lb_balance = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.cb_accountDW = new System.Windows.Forms.ComboBox();
			this.cb_bankDW = new System.Windows.Forms.ComboBox();
			this.tab_payInto.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 558);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1052, 0);
			this.panel1.TabIndex = 1;
			// 
			// tab_payInto
			// 
			this.tab_payInto.Controls.Add(this.tabPage1);
			this.tab_payInto.Controls.Add(this.tabPage2);
			this.tab_payInto.Dock = System.Windows.Forms.DockStyle.Top;
			this.tab_payInto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tab_payInto.Location = new System.Drawing.Point(0, 0);
			this.tab_payInto.Name = "tab_payInto";
			this.tab_payInto.SelectedIndex = 0;
			this.tab_payInto.Size = new System.Drawing.Size(1052, 558);
			this.tab_payInto.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.BackgroundImage = global::GUI.Properties.Resources.depositphotos_45239057_stock_photo_finance_concept_arrow_with_money1;
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabPage1.Controls.Add(this.btn_submit);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.txt_money);
			this.tabPage1.Controls.Add(this.txt_accountTranfer);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.lb_money);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.cb_bankTranfer);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.cb_account);
			this.tabPage1.Controls.Add(this.cb_bank);
			this.tabPage1.Location = new System.Drawing.Point(4, 38);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1044, 516);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Transfer";
			// 
			// btn_submit
			// 
			this.btn_submit.Location = new System.Drawing.Point(707, 353);
			this.btn_submit.Name = "btn_submit";
			this.btn_submit.Size = new System.Drawing.Size(117, 38);
			this.btn_submit.TabIndex = 16;
			this.btn_submit.Text = "Submit";
			this.btn_submit.UseVisualStyleBackColor = true;
			this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(898, 301);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 22);
			this.label8.TabIndex = 15;
			this.label8.Text = "VND";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(615, 247);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(209, 29);
			this.label7.TabIndex = 14;
			this.label7.Text = "Amount Of Money:";
			// 
			// txt_money
			// 
			this.txt_money.Location = new System.Drawing.Point(630, 293);
			this.txt_money.Name = "txt_money";
			this.txt_money.Size = new System.Drawing.Size(262, 34);
			this.txt_money.TabIndex = 13;
			// 
			// txt_accountTranfer
			// 
			this.txt_accountTranfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_accountTranfer.Location = new System.Drawing.Point(630, 195);
			this.txt_accountTranfer.Name = "txt_accountTranfer";
			this.txt_accountTranfer.Size = new System.Drawing.Size(262, 27);
			this.txt_accountTranfer.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(218, 254);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 22);
			this.label6.TabIndex = 11;
			this.label6.Text = "VND";
			// 
			// lb_money
			// 
			this.lb_money.AutoSize = true;
			this.lb_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_money.Location = new System.Drawing.Point(120, 254);
			this.lb_money.Name = "lb_money";
			this.lb_money.Size = new System.Drawing.Size(0, 22);
			this.lb_money.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 254);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 22);
			this.label5.TabIndex = 9;
			this.label5.Text = "Balance:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_switch_32_2;
			this.pictureBox1.Location = new System.Drawing.Point(443, 132);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(615, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(300, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Enter the Account want to tranfer:";
			// 
			// cb_bankTranfer
			// 
			this.cb_bankTranfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_bankTranfer.FormattingEnabled = true;
			this.cb_bankTranfer.Location = new System.Drawing.Point(630, 99);
			this.cb_bankTranfer.Name = "cb_bankTranfer";
			this.cb_bankTranfer.Size = new System.Drawing.Size(262, 28);
			this.cb_bankTranfer.TabIndex = 5;
			this.cb_bankTranfer.SelectedIndexChanged += new System.EventHandler(this.cb_bankTranfer_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(609, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(283, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Enter the Bank want to transfer:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Select Your Bank:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 166);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select Your Account:";
			// 
			// cb_account
			// 
			this.cb_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_account.FormattingEnabled = true;
			this.cb_account.Location = new System.Drawing.Point(33, 194);
			this.cb_account.Name = "cb_account";
			this.cb_account.Size = new System.Drawing.Size(254, 28);
			this.cb_account.TabIndex = 2;
			this.cb_account.SelectedIndexChanged += new System.EventHandler(this.cb_account_SelectedIndexChanged);
			// 
			// cb_bank
			// 
			this.cb_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_bank.FormattingEnabled = true;
			this.cb_bank.Location = new System.Drawing.Point(33, 99);
			this.cb_bank.Name = "cb_bank";
			this.cb_bank.Size = new System.Drawing.Size(254, 28);
			this.cb_bank.TabIndex = 3;
			this.cb_bank.SelectedIndexChanged += new System.EventHandler(this.cb_bank_SelectedIndexChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.BackgroundImage = global::GUI.Properties.Resources.depositphotos_45239057_stock_photo_finance_concept_arrow_with_money1;
			this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.groupBox);
			this.tabPage2.Controls.Add(this.txt_moneyDW);
			this.tabPage2.Controls.Add(this.btn_doneDW);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.lb_balance);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.cb_accountDW);
			this.tabPage2.Controls.Add(this.cb_bankDW);
			this.tabPage2.Location = new System.Drawing.Point(4, 38);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1044, 516);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Deposit And Withdraw";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(597, 268);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(63, 29);
			this.label14.TabIndex = 27;
			this.label14.Text = "VND";
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.rbtn_withdraw);
			this.groupBox.Controls.Add(this.rbtn_deposit);
			this.groupBox.Location = new System.Drawing.Point(666, 146);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(300, 124);
			this.groupBox.TabIndex = 26;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Deposit Or Withdraw";
			// 
			// rbtn_withdraw
			// 
			this.rbtn_withdraw.AutoSize = true;
			this.rbtn_withdraw.Location = new System.Drawing.Point(166, 46);
			this.rbtn_withdraw.Name = "rbtn_withdraw";
			this.rbtn_withdraw.Size = new System.Drawing.Size(134, 33);
			this.rbtn_withdraw.TabIndex = 26;
			this.rbtn_withdraw.TabStop = true;
			this.rbtn_withdraw.Text = "Withdraw";
			this.rbtn_withdraw.UseVisualStyleBackColor = true;
			// 
			// rbtn_deposit
			// 
			this.rbtn_deposit.AutoSize = true;
			this.rbtn_deposit.Location = new System.Drawing.Point(6, 46);
			this.rbtn_deposit.Name = "rbtn_deposit";
			this.rbtn_deposit.Size = new System.Drawing.Size(117, 33);
			this.rbtn_deposit.TabIndex = 25;
			this.rbtn_deposit.TabStop = true;
			this.rbtn_deposit.Text = "Deposit";
			this.rbtn_deposit.UseVisualStyleBackColor = true;
			// 
			// txt_moneyDW
			// 
			this.txt_moneyDW.Location = new System.Drawing.Point(337, 263);
			this.txt_moneyDW.Name = "txt_moneyDW";
			this.txt_moneyDW.Size = new System.Drawing.Size(254, 34);
			this.txt_moneyDW.TabIndex = 25;
			// 
			// btn_doneDW
			// 
			this.btn_doneDW.Location = new System.Drawing.Point(393, 357);
			this.btn_doneDW.Name = "btn_doneDW";
			this.btn_doneDW.Size = new System.Drawing.Size(161, 45);
			this.btn_doneDW.TabIndex = 22;
			this.btn_doneDW.Text = "Done";
			this.btn_doneDW.UseVisualStyleBackColor = true;
			this.btn_doneDW.Click += new System.EventHandler(this.btn_doneDW_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(71, 268);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(209, 29);
			this.label15.TabIndex = 21;
			this.label15.Text = "Amount Of Money:";
			// 
			// lb_balance
			// 
			this.lb_balance.AutoSize = true;
			this.lb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_balance.Location = new System.Drawing.Point(773, 91);
			this.lb_balance.Name = "lb_balance";
			this.lb_balance.Size = new System.Drawing.Size(0, 29);
			this.lb_balance.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(894, 96);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 22);
			this.label9.TabIndex = 18;
			this.label9.Text = "VND";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(147, 265);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(0, 22);
			this.label10.TabIndex = 17;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(661, 91);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(106, 29);
			this.label11.TabIndex = 16;
			this.label11.Text = "Balance:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(71, 82);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(204, 29);
			this.label12.TabIndex = 13;
			this.label12.Text = "Select Your Bank:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(71, 177);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(235, 29);
			this.label13.TabIndex = 12;
			this.label13.Text = "Select Your Account:";
			// 
			// cb_accountDW
			// 
			this.cb_accountDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_accountDW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_accountDW.FormattingEnabled = true;
			this.cb_accountDW.Location = new System.Drawing.Point(337, 174);
			this.cb_accountDW.Name = "cb_accountDW";
			this.cb_accountDW.Size = new System.Drawing.Size(254, 37);
			this.cb_accountDW.TabIndex = 14;
			this.cb_accountDW.SelectedIndexChanged += new System.EventHandler(this.cb_accountDW_SelectedIndexChanged);
			// 
			// cb_bankDW
			// 
			this.cb_bankDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_bankDW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_bankDW.FormattingEnabled = true;
			this.cb_bankDW.Location = new System.Drawing.Point(337, 83);
			this.cb_bankDW.Name = "cb_bankDW";
			this.cb_bankDW.Size = new System.Drawing.Size(254, 37);
			this.cb_bankDW.TabIndex = 15;
			this.cb_bankDW.SelectedIndexChanged += new System.EventHandler(this.cb_bankDW_SelectedIndexChanged);
			// 
			// FormTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 557);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tab_payInto);
			this.Name = "FormTransaction";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormTransaction";
			this.tab_payInto.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txt_moneyDW;
		private System.Windows.Forms.Button btn_doneDW;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lb_balance;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cb_accountDW;
		private System.Windows.Forms.ComboBox cb_bankDW;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btn_submit;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_money;
		private System.Windows.Forms.TextBox txt_accountTranfer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lb_money;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb_bankTranfer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_account;
		private System.Windows.Forms.ComboBox cb_bank;
		private System.Windows.Forms.TabControl tab_payInto;
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.RadioButton rbtn_deposit;
		private System.Windows.Forms.RadioButton rbtn_withdraw;
		private System.Windows.Forms.Label label14;
	}
}