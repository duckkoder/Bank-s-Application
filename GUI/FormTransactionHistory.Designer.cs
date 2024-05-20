namespace GUI
{
	partial class FormTransactionHistory
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
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lb_balance = new System.Windows.Forms.Label();
			this.lb_bankName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cb_account = new System.Windows.Forms.ComboBox();
			this.cb_bank = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgv_transaction = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.lb_balance);
			this.panel1.Controls.Add(this.lb_bankName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cb_account);
			this.panel1.Controls.Add(this.cb_bank);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(325, 624);
			this.panel1.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(256, 404);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 29);
			this.label6.TabIndex = 9;
			this.label6.Text = "VND";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 404);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 29);
			this.label5.TabIndex = 8;
			this.label5.Text = "Balance:";
			// 
			// lb_balance
			// 
			this.lb_balance.AutoSize = true;
			this.lb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_balance.Location = new System.Drawing.Point(124, 404);
			this.lb_balance.Name = "lb_balance";
			this.lb_balance.Size = new System.Drawing.Size(0, 29);
			this.lb_balance.TabIndex = 7;
			// 
			// lb_bankName
			// 
			this.lb_bankName.AutoSize = true;
			this.lb_bankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_bankName.Location = new System.Drawing.Point(153, 340);
			this.lb_bankName.Name = "lb_bankName";
			this.lb_bankName.Size = new System.Drawing.Size(0, 29);
			this.lb_bankName.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(251, 40);
			this.label3.TabIndex = 4;
			this.label3.Text = "Transaction History";
			// 
			// cb_account
			// 
			this.cb_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_account.FormattingEnabled = true;
			this.cb_account.Location = new System.Drawing.Point(28, 275);
			this.cb_account.Name = "cb_account";
			this.cb_account.Size = new System.Drawing.Size(263, 37);
			this.cb_account.TabIndex = 3;
			this.cb_account.SelectedIndexChanged += new System.EventHandler(this.cb_account_SelectedIndexChanged);
			// 
			// cb_bank
			// 
			this.cb_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_bank.FormattingEnabled = true;
			this.cb_bank.Location = new System.Drawing.Point(28, 140);
			this.cb_bank.Name = "cb_bank";
			this.cb_bank.Size = new System.Drawing.Size(263, 37);
			this.cb_bank.TabIndex = 2;
			this.cb_bank.SelectedIndexChanged += new System.EventHandler(this.cb_bank_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 243);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(235, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Select Your Account:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select Your Bank:";
			// 
			// dgv_transaction
			// 
			this.dgv_transaction.AllowUserToAddRows = false;
			this.dgv_transaction.AllowUserToDeleteRows = false;
			this.dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_transaction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_transaction.Location = new System.Drawing.Point(325, 0);
			this.dgv_transaction.Name = "dgv_transaction";
			this.dgv_transaction.ReadOnly = true;
			this.dgv_transaction.RowHeadersWidth = 51;
			this.dgv_transaction.RowTemplate.Height = 24;
			this.dgv_transaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_transaction.Size = new System.Drawing.Size(731, 624);
			this.dgv_transaction.TabIndex = 1;
			// 
			// FormTransactionHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1056, 624);
			this.Controls.Add(this.dgv_transaction);
			this.Controls.Add(this.panel1);
			this.Name = "FormTransactionHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormTransactionHistory";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_bank;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_account;
		private System.Windows.Forms.DataGridView dgv_transaction;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lb_balance;
		private System.Windows.Forms.Label lb_bankName;
	}
}