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
	public partial class FormChangeInformation : Form
	{
		private User User=FormMenu.user;
		public FormChangeInformation()
		{
			InitializeComponent();
			setPasswordChar();
			loadUserInformation();
		}
		void loadUserInformation()
		{
			txt_UserName.Text = User.UserName;
			txt_fullName.Text = User.FullName;
			txt_phoneNumber.Text = User.PhoneNumber;
			txt_email.Text = User.Email;
			dtp_birthDay.Value =  User.BirthDay;
		}
		public void setPasswordChar()
		{
			txt_newPassword.PasswordChar = '•';
			txt_newPasswordComfirmed.PasswordChar = '•';
			txt_oldPassword.PasswordChar = '•';
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			txt_newPassword.PasswordChar = '\0';
			pictureBox1.Visible = false;
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			txt_newPassword.PasswordChar = '•';
			pictureBox1.Visible = true;
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			txt_oldPassword.PasswordChar = '\0';
			pictureBox7.Visible = false;
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			txt_oldPassword.PasswordChar = '•';
			pictureBox7.Visible = true;
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			txt_newPasswordComfirmed.PasswordChar = '\0';
			pictureBox9.Visible = false;
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			txt_newPasswordComfirmed.PasswordChar = '\0';
			pictureBox9.Visible = true;
		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			User u = new User();
			if (txt_oldPassword.Text == "" || txt_newPassword.Text == "" || txt_newPasswordComfirmed.Text == "")
			{
				MessageBox.Show("Check Information again!!!(* field cannot be blank)");
				return;
			}

			if (txt_newPassword.Text!= txt_newPasswordComfirmed.Text)
			{
				MessageBox.Show("New Password And New Password Comfirmed Are Different!!!");
				return;
			}
			else
			{
				u.UserName = User.UserName;
				u.Password = txt_oldPassword.Text;
				if(BLL_User.Instance.checkLogin(u))
				{
					u.Password= txt_newPassword.Text;
					BLL_User.Instance.updateUserPassword(u);
					MessageBox.Show("Your Password Was Changed!!!");
				}
				else
				{
					MessageBox.Show("Incorrect Password!!!");
				}
			}
			
			u.FullName = txt_fullName.Text;
			u.PhoneNumber = txt_phoneNumber.Text;
			u.BirthDay = dtp_birthDay.Value ;
			u.Email = txt_email.Text;
			BLL_User.Instance.updateUserInfor(u);
			FormMenu.user = u;
			MessageBox.Show("Update Information Successed!!!");
		}
	}
}
