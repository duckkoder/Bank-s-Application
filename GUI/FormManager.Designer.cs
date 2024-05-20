namespace GUI
{
	partial class FormManager
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.cb_user = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_bank = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_manager = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lb_mana = new System.Windows.Forms.Label();
			this.btn_submit = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_bankName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgv_account = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.cb_bankbank = new System.Windows.Forms.ComboBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_loadBank = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(325, 643);
			this.panel1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(325, 643);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cb_user);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.cb_bank);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.lb_manager);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(317, 614);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Account";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// cb_user
			// 
			this.cb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_user.FormattingEnabled = true;
			this.cb_user.Location = new System.Drawing.Point(15, 306);
			this.cb_user.Name = "cb_user";
			this.cb_user.Size = new System.Drawing.Size(263, 37);
			this.cb_user.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 274);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 29);
			this.label2.TabIndex = 7;
			this.label2.Text = "Select User:";
			// 
			// cb_bank
			// 
			this.cb_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_bank.FormattingEnabled = true;
			this.cb_bank.Location = new System.Drawing.Point(15, 142);
			this.cb_bank.Name = "cb_bank";
			this.cb_bank.Size = new System.Drawing.Size(263, 37);
			this.cb_bank.TabIndex = 3;
			this.cb_bank.SelectedIndexChanged += new System.EventHandler(this.cb_bank_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 40);
			this.label3.TabIndex = 5;
			this.label3.Text = "Manager: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select Bank:";
			// 
			// lb_manager
			// 
			this.lb_manager.AutoSize = true;
			this.lb_manager.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manager.Location = new System.Drawing.Point(173, 32);
			this.lb_manager.Name = "lb_manager";
			this.lb_manager.Size = new System.Drawing.Size(138, 40);
			this.lb_manager.TabIndex = 6;
			this.lb_manager.Text = "Manager: ";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btn_loadBank);
			this.tabPage2.Controls.Add(this.btn_delete);
			this.tabPage2.Controls.Add(this.cb_bankbank);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.lb_mana);
			this.tabPage2.Controls.Add(this.btn_submit);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.txt_bankName);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(317, 614);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Bank";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lb_mana
			// 
			this.lb_mana.AutoSize = true;
			this.lb_mana.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mana.Location = new System.Drawing.Point(152, 32);
			this.lb_mana.Name = "lb_mana";
			this.lb_mana.Size = new System.Drawing.Size(0, 40);
			this.lb_mana.TabIndex = 8;
			// 
			// btn_submit
			// 
			this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_submit.Location = new System.Drawing.Point(78, 176);
			this.btn_submit.Name = "btn_submit";
			this.btn_submit.Size = new System.Drawing.Size(147, 48);
			this.btn_submit.TabIndex = 7;
			this.btn_submit.Text = "Add Bank";
			this.btn_submit.UseVisualStyleBackColor = true;
			this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 40);
			this.label5.TabIndex = 6;
			this.label5.Text = "Manager: ";
			// 
			// txt_bankName
			// 
			this.txt_bankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_bankName.Location = new System.Drawing.Point(26, 125);
			this.txt_bankName.Name = "txt_bankName";
			this.txt_bankName.Size = new System.Drawing.Size(252, 34);
			this.txt_bankName.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(225, 29);
			this.label4.TabIndex = 0;
			this.label4.Text = "Insert Bank\'s Name:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgv_account);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(325, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(777, 643);
			this.panel2.TabIndex = 1;
			// 
			// dgv_account
			// 
			this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_account.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_account.Location = new System.Drawing.Point(0, 0);
			this.dgv_account.Name = "dgv_account";
			this.dgv_account.RowHeadersWidth = 51;
			this.dgv_account.RowTemplate.Height = 24;
			this.dgv_account.Size = new System.Drawing.Size(777, 643);
			this.dgv_account.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(36, 296);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(147, 29);
			this.label6.TabIndex = 9;
			this.label6.Text = "Select Bank:";
			// 
			// cb_bankbank
			// 
			this.cb_bankbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_bankbank.FormattingEnabled = true;
			this.cb_bankbank.Location = new System.Drawing.Point(26, 328);
			this.cb_bankbank.Name = "cb_bankbank";
			this.cb_bankbank.Size = new System.Drawing.Size(263, 37);
			this.cb_bankbank.TabIndex = 10;
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_delete.Location = new System.Drawing.Point(78, 382);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(147, 48);
			this.btn_delete.TabIndex = 11;
			this.btn_delete.Text = "Delete Bank";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_loadBank
			// 
			this.btn_loadBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_loadBank.Location = new System.Drawing.Point(78, 504);
			this.btn_loadBank.Name = "btn_loadBank";
			this.btn_loadBank.Size = new System.Drawing.Size(147, 36);
			this.btn_loadBank.TabIndex = 12;
			this.btn_loadBank.Text = "Load Bank";
			this.btn_loadBank.UseVisualStyleBackColor = true;
			this.btn_loadBank.Click += new System.EventHandler(this.btn_loadBank_Click);
			// 
			// FormManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 643);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormManager";
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_bank;
		private System.Windows.Forms.Label lb_manager;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_bankName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lb_mana;
		private System.Windows.Forms.Button btn_submit;
		private System.Windows.Forms.ComboBox cb_user;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgv_account;
		private System.Windows.Forms.ComboBox cb_bankbank;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_loadBank;
	}
}