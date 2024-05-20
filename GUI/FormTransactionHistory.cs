using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class FormTransactionHistory : Form
	{
		private User user = FormMenu.user;
		public FormTransactionHistory()
		{
			InitializeComponent();
			loadBank();
			this.SizeChanged += new EventHandler(Form1_SizeChanged);
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			ResizeDataGridViewColumns(dgv_transaction);
		}
		private void ResizeDataGridViewColumns(DataGridView dataGridView)
		{
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

		public void loadBank()
		{
			cb_bank.Items.Clear();
			DataTable tb = BLL_Bank.Instance.getBankByUser(user.UserName);
			foreach (DataRow dt in tb.Rows)
			{
				cb_bank.Items.Add(dt["BankName"].ToString());
			}
		}

		private void cb_bank_SelectedIndexChanged(object sender, EventArgs e)
		{
			cb_account.Items.Clear();
			DataTable tb = BLL_Account.Instance.getAccountByUserAndBank(user.UserName, cb_bank.Text);
			foreach (DataRow dt in tb.Rows)
			{
				cb_account.Items.Add(dt["STK"].ToString());
			}
		}

		private void cb_account_SelectedIndexChanged(object sender, EventArgs e)
		{
			Account account = BLL_Account.Instance.getAccountBySTK(Int32.Parse(cb_account.Text));
			lb_balance.Text = account.Balance.ToString();

			
			dgv_transaction.DataSource = BLL_Transaction.Instance.getTransactionHistoryByAccount(account.STK);

		
			ResizeDataGridViewColumns(dgv_transaction);

			
			if (!Controls.Contains(dgv_transaction))
			{
				dgv_transaction.Dock = DockStyle.Fill;
				Controls.Add(dgv_transaction);
			}
		}
	}
}
