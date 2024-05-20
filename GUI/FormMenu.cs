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

namespace GUI
{
	public partial class FormMenu : Form
	{
		public static User user;

		public FormMenu()
		{
			InitializeComponent();
			LoadUser();
		}
		public void LoadUser()
		{
			user = BLL_User.Instance.GetUser(FormLogin.currentUserName);
			lb_fullName.Text = user.FullName;
		}

		private void btn_transaction_Click(object sender, EventArgs e)
		{
			FormTransaction formTransaction = new FormTransaction();
			this.Hide();
			formTransaction.ShowDialog();
			this.Show();
		}

		private void btn_logOut_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_tranHistory_Click(object sender, EventArgs e)
		{
			FormTransactionHistory formTransactionHistory = new FormTransactionHistory();
			this.Hide();
			formTransactionHistory.ShowDialog();
			this.Show();
		}

		private void btn_changeInfo_Click(object sender, EventArgs e)
		{
			FormChangeInformation formChangeInformation = new FormChangeInformation();
			this.Hide();
			formChangeInformation.ShowDialog();
			this.Show();
			lb_fullName.Text = user.FullName;
		}

		private void btn_manager_Click(object sender, EventArgs e)
		{
			if(user.UserTypeID==2)
			{
				MessageBox.Show("Sorry!Manager Only!");
				return;

			}
			FormManager formManager = new FormManager();
			this.Hide();
			formManager.ShowDialog();
			this.Show();
		}

		private void btn_SignUpAccount_Click(object sender, EventArgs e)
		{
			FormCreateNewAccount formCreateNewAccount = new FormCreateNewAccount();
			this.Hide();
			formCreateNewAccount.ShowDialog();
			this.Show();
		}
	}
}
