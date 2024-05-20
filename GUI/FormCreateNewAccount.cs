using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI
{
	public partial class FormCreateNewAccount : Form
	{
		private User user;
		private List<Bank> banks = new List<Bank>();  
		public FormCreateNewAccount()
		{
			InitializeComponent();
			loadcombobox();
			loadUser();
		}

		void loadcombobox()
		{
			BLL_Bank.Instance.getList(banks);
			cb_bank.Items.Clear();
			
			foreach (Bank bank in banks)
			{
				cb_bank.Items.Add(bank.BankName);
				
			}
		}
		void loadUser()
		{
			user = FormMenu.user;
			txt_fullName.Text = user.FullName;
			txt_userName.Text = user.UserName;
			txt_phoneNumber.Text = user.PhoneNumber;
			txt_email.Text = user.Email;
			dtp_birthDay.Value = user.BirthDay;
		}

		private void cb_bank_SelectedIndexChanged(object sender, EventArgs e)
		{
			string bankName = cb_bank.Text;
			int bankID =0;
			foreach (Bank b in banks)
			{
				if (b.BankName == bankName)
				{
					bankID = b.BankID;
					break;
				}
			}
			txt_accountNumber.Text = bankID.ToString();

		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			if(txt_accountNumber.Text==""||cb_bank==null)
			{
				MessageBox.Show("Check Information Again!!!(* field cannot be blank)");
				return;
			}
			string bankName = cb_bank.Text;
			int bankID = 0;
			foreach (Bank b in banks)
			{
				if (b.BankName == bankName)
				{
					bankID = b.BankID;
					break;
				}
			}
			if(txt_accountNumber.Text.Length!=10)
			{
				MessageBox.Show("The Account Number Must Contains 10 Digits");
				return;
			}
			if (txt_accountNumber.Text.Substring(0,3)!=bankID.ToString())
			{
				MessageBox.Show($"The Account Number Must Start With {bankID}");
				return;
			}
			

			if(!chb.Checked) {
				MessageBox.Show("Please Agree To Our Request!!!");
				return;
			}

			if(!BLL_Account.Instance.checkSTK(Int32.Parse(txt_accountNumber.Text)))
			{
				MessageBox.Show("This Account Number Already Exists !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult ms = MessageBox.Show($"Are You Sure To Create Account {txt_accountNumber.Text} in bank named {cb_bank.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);

			if(ms == DialogResult.Yes)
			{
				Account ac = new Account(Int32.Parse(txt_accountNumber.Text),user.UserName,bankID,0);
				BLL_Account.Instance.Create(ac);
				MessageBox.Show($"Created Success Account {txt_accountNumber.Text} in bank named {cb_bank.Text}");
				return ;
			}
		}
	}
}
