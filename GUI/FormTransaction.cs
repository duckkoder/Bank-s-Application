using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
	public partial class FormTransaction : Form
	{
		List<Bank> banks = new List<Bank>();

		private User user; 
		public FormTransaction()
		{
			InitializeComponent();
			user = FormMenu.user;
			loadBank();
		}
		public void loadBank()
		{
			BLL_Bank.Instance.getList(banks);
			//Load bank User
			DataTable tb = BLL_Bank.Instance.getBankByUser(user.UserName);
			foreach (DataRow dt in tb.Rows)
			{
				cb_bank.Items.Add(dt["BankName"].ToString());
				cb_bankDW.Items.Add(dt["BankName"].ToString());
			}
			//Load bank transfer
			foreach(Bank bank in banks)
			{
				cb_bankTranfer.Items.Add(bank.BankName.ToString());
			}
		}
		

		private void cb_bank_SelectedIndexChanged(object sender, EventArgs e)
		{
			cb_account.Items.Clear();
			DataTable tb = BLL_Account.Instance.getAccountByUserAndBank(user.UserName, cb_bank.Text);   
			foreach(DataRow dt in tb.Rows)
			{
				cb_account.Items.Add(dt["STK"].ToString());
			}

		}

		private void cb_account_SelectedIndexChanged(object sender, EventArgs e)
		{
			lb_money.Text =  BLL_Account.Instance.getBalance(Int32.Parse(cb_account.Text)) +"";
		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			if (cb_bank.Text == "" )
			{
				MessageBox.Show("Please Select The Bank!!!");
				return;
			}
			if (cb_account.Text == "")
			{
				MessageBox.Show("Please Select The AccountNumber!!! ");
				return;
			}
			if (cb_bankTranfer.Text == "")
			{
				MessageBox.Show("Please Enter The Bank Tranfer!!!");
				return;
			}
			if (txt_accountTranfer.Text == "")
			{
				MessageBox.Show("Please Enter The AccountNumber!!! ");
				return;
			}
			if(txt_money.Text == "" ) 
			{
				MessageBox.Show("Please Enter The Amount Of Money!!! ");
				return;
			}

            if (Int32.Parse(txt_money.Text) <= 0)
            {
				MessageBox.Show("The Amount Cannot Be Negative!!! ");
				return;
			}
            int amount = Int32.Parse( txt_money.Text);

			if((Int32.Parse(lb_money.Text))-amount<0)
			{
				MessageBox.Show("The balance is not enough to make the transaction!!! ");
				return;
			}

			DialogResult ms = MessageBox.Show("Comfirm Transfer to : " + txt_accountTranfer.Text + "\n\n Amount: " + txt_money.Text + " VND", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);
			if (ms == DialogResult.Yes)
			{
				if (BLL_Account.Instance.increaseBalance(Int32.Parse(txt_accountTranfer.Text), amount))
				{
					BLL_Account.Instance.increaseBalance(Int32.Parse(cb_account.Text), -amount);
					lb_money.Text = (Int32.Parse(lb_money.Text) - amount) + "";
					lb_balance.Text = lb_money.Text;
					BLL_Transaction.Instance.Create(
						new Transaction { 
							STKTransferred = Int32.Parse( cb_account.Text),
							STKReceived = Int32.Parse( txt_accountTranfer.Text),
							Amount = amount,
							Time = DateTime.Now,
							TransactionType = "Transfer"
						}
						);;
					
					MessageBox.Show("Transfer Successed!!!");
				}
			}
		}

		private void cb_bankTranfer_SelectedIndexChanged(object sender, EventArgs e)
		{
			string BankName = cb_bankTranfer.Text;
			foreach(Bank b in banks)
			{
				if(b.BankName.Equals(BankName))
				{
					txt_accountTranfer.Text = b.BankID.ToString();
					return;
				}
			}
		}

		private void btn_doneDW_Click(object sender, EventArgs e)
		{
			if(cb_bankDW.Text == "")
			{
				MessageBox.Show("Please Select The Bank!!!");
				return;
			}
			if (cb_accountDW.Text == "")
			{
				MessageBox.Show("Please Select The AccountNumber!!! ");
				return;
			}
			if (txt_moneyDW.Text == "" || Int64.Parse(txt_moneyDW.Text) <= 0)
			{
				MessageBox.Show("Please Enter The Amount Of Money!!! ");
				return;
			}
			if(!rbtn_deposit.Checked&&!rbtn_withdraw.Checked)
			{
				MessageBox.Show("Please Select Acction!!!");
				return;
			}
			int amount = Int32.Parse(txt_moneyDW.Text);
			if(rbtn_deposit.Checked)
			{
				DialogResult ms = MessageBox.Show("Comfirm Deposit: " + cb_accountDW.Text + "\n\n Amount: " + amount + " VND", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);
				if (ms == DialogResult.Yes)
				{
					BLL_Account.Instance.increaseBalance(Int32.Parse(cb_accountDW.Text),amount);
					Transaction transaction = new Transaction();
					transaction.STKTransferred = Int32.Parse(cb_accountDW.Text);
					transaction.TransactionType = "Deposit";
					transaction.Amount = amount;
					transaction.Time = DateTime.Now;
					lb_balance.Text = (Int32.Parse(lb_balance.Text) + amount) + "";
					lb_money.Text = lb_balance.Text;
					BLL_Transaction.Instance.Create(transaction);
					MessageBox.Show("Deposit Successed!!!");
				}
			}
			else
			{
				if(Int32.Parse(lb_balance.Text) - amount <0)
				{
					MessageBox.Show("The balance is not enough to make the transaction!!! ");
					return;
				}
				DialogResult ms = MessageBox.Show("Comfirm Withdraw: " + cb_accountDW.Text + "\n\n Amount: " + amount + " VND", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);
				if (ms == DialogResult.Yes)
				{
					BLL_Account.Instance.increaseBalance(Int32.Parse(cb_accountDW.Text), -amount);
					BLL_Transaction.Instance.Create(
						new Transaction
						{
							STKTransferred = Int32.Parse(cb_accountDW.Text),
							Amount = amount,
							Time = DateTime.Now,
							TransactionType = "Withdraw"
						}
						); ;
					lb_balance.Text = (Int32.Parse(lb_balance.Text) - amount) + "";
					lb_money.Text = lb_balance.Text;
					MessageBox.Show("Withdraw Successed!!!");
				}
			}

		}

		private void cb_bankDW_SelectedIndexChanged(object sender, EventArgs e)
		{
			cb_accountDW.Items.Clear();
			DataTable tb = BLL_Account.Instance.getAccountByUserAndBank(user.UserName, cb_bankDW.Text);
			foreach (DataRow dt in tb.Rows)
			{
				cb_accountDW.Items.Add(dt["STK"].ToString());
			}
		}

		private void cb_accountDW_SelectedIndexChanged(object sender, EventArgs e)
		{
			lb_balance.Text = BLL_Account.Instance.getBalance(Int32.Parse(cb_accountDW.Text)) + "";
		}

		
	}
}
