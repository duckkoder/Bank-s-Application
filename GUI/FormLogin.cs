using Model;
using BLL;
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
	public partial class FormLogin : Form
	{
		public static string currentUserName;
		public FormLogin()
		{
			InitializeComponent();
			txt_password.PasswordChar = '•';
		}

		private void btn_login_Click(object sender, EventArgs e)
		{ 
			User user = new User();
			user.UserName=txt_userName.Text;
			user.Password=txt_password.Text;
			if(BLL_User.Instance.checkLogin(user))
			{
				currentUserName = txt_userName.Text;
				FormMenu formMenu = new FormMenu();
				this.Hide();
				formMenu.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Check Information Againn !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_password.Text = "";
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			pictureBox4.Visible = false;
			txt_password.PasswordChar = '\0';
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			pictureBox4.Visible = true;
			txt_password.PasswordChar = '•';

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormSignUp formSignUp = new FormSignUp();
			this.Hide();
			formSignUp.ShowDialog();
			this.Show();
		}
	}
}
