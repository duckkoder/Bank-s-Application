using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
	public partial class FormManager : Form
	{
		public User user;
		private List<Bank> banks = new List<Bank>();
		private List<User> users = new List<User>();

		public FormManager()
		{
			InitializeComponent();
			loadLabel();
			loadcombobox();
			this.SizeChanged += new EventHandler(Form1_SizeChanged);

			// Ensure event handlers are assigned
			cb_bank.SelectedIndexChanged += cb_bank_SelectedIndexChanged;
			cb_user.SelectedIndexChanged += cb_user_SelectedIndexChanged;
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			ResizeDataGridViewColumns(dgv_account);
		}

		private void ResizeDataGridViewColumns(DataGridView dataGridView)
		{
			if (dataGridView.Columns.Count == 0) return;

			// Tính toán tổng chiều rộng hiện có của các cột
			int totalColumnWidth = 0;
			foreach (DataGridViewColumn column in dataGridView.Columns)
			{
				if (column.Visible)
					totalColumnWidth += column.Width;
			}

			// Tính toán tỷ lệ để cân chỉnh lại chiều rộng của các cột
			double ratio = (double)dataGridView.ClientSize.Width / totalColumnWidth;

			// Cập nhật chiều rộng của từng cột
			foreach (DataGridViewColumn column in dataGridView.Columns)
			{
				if (column.Visible)
					column.Width = (int)(column.Width * ratio);
			}
		}

		void loadLabel()
		{
			user = FormMenu.user;
			lb_manager.Text = user.UserName;
			lb_mana.Text = user.UserName;
		}
		void loadcombobox()
		{
			BLL_Bank.Instance.getList(banks);
			BLL_User.Instance.getList(users);
			cb_bank.Items.Clear();
			cb_user.Items.Clear();
			cb_bankbank.Items.Clear();
			foreach (Bank bank in banks)
			{
				cb_bank.Items.Add(bank.BankName);
				cb_bankbank.Items.Add(bank.BankName);
			}
			foreach (User user in users)
			{
				cb_user.Items.Add(user.UserName);
			}
		}

		void loadBank()
		{
			dgv_account.DataSource = BLL_Bank.Instance.Read();
			ResizeDataGridViewColumns(dgv_account);
		}
		private void cb_user_SelectedIndexChanged(object sender, EventArgs e)
		{
			string userName = cb_user.Text;
			DataTable userAccounts = BLL_Account.Instance.getAccountByUser(userName);
			dgv_account.DataSource = userAccounts;
			ResizeDataGridViewColumns(dgv_account);
		}

		private void cb_bank_SelectedIndexChanged(object sender, EventArgs e)
		{
			string bankName = cb_bank.Text;
			DataTable bankAccounts = BLL_Account.Instance.getAccountByBank(bankName);
			dgv_account.DataSource = bankAccounts;
			ResizeDataGridViewColumns(dgv_account);
		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			if(txt_bankName.Text!="")
			{
				if(BLL_Bank.Instance.checkBankName(txt_bankName.Text))
				{
					DialogResult ms = MessageBox.Show($"Do you want to add Bank named {txt_bankName.Text}  to the Database?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);
					if (ms == DialogResult.Yes)
					{
						BLL_Bank.Instance.insertBank(txt_bankName.Text);
						MessageBox.Show($"Successfully added Bank named {txt_bankName.Text} to the database!!!");
						txt_bankName.Text = "";
						loadBank();
						loadcombobox();
					}
				}
				else
				{
					MessageBox.Show("Bank's Name Already Exists!!!");
					return;
				}
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			int bankID = 0;
			if(cb_bankbank==null)
			{
				MessageBox.Show($"Please Choice the Bank!!!");
				return;
			}
			DialogResult ms = MessageBox.Show($"Do you want to Delete Bank named {cb_bankbank.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);
			if (ms == DialogResult.Yes)
			{
				
				foreach(Bank b in banks)
				{
					if(b.BankName == cb_bankbank.Text)
					{
						bankID = b.BankID;
						break;
					}
				}

				BLL_Account.Instance.deleteAccountByBank(bankID);
				BLL_Bank.Instance.Delete(bankID);
				cb_bankbank.Text = "";
				MessageBox.Show($"Successfully delete Bank named {cb_bankbank.Text}!!!");
				loadcombobox();
				loadBank();

			}
		}

		private void btn_loadBank_Click(object sender, EventArgs e)
		{
			loadBank();
		}
	}
}
