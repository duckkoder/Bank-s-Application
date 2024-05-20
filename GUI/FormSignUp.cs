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
	public partial class FormSignUp : Form
	{
		public FormSignUp()
		{
			InitializeComponent();
			txt_Password.PasswordChar = '•';
			txt_comfirmPassword.PasswordChar = '•';
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			pictureBox5.Visible = true;
			txt_Password.PasswordChar = '•';
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			pictureBox5.Visible = false;
			txt_Password.PasswordChar = '\0';
		}
		private void pictureBox3_Click_1(object sender, EventArgs e)
		{
			pictureBox4.Visible = true;
			txt_comfirmPassword.PasswordChar = '•';
		}

		private void pictureBox4_Click_1(object sender, EventArgs e)
		{
			pictureBox4.Visible = false;
			txt_comfirmPassword.PasswordChar = '\0';
		}

		

		private void btn_submit_Click(object sender, EventArgs e)
		{
			if(cb.Checked == false)
			{
				MessageBox.Show("Don't Agree to Privacy Policy?");
				return;
			}

			if (txt_UserName.Text == ""||txt_Password.Text == ""|| txt_comfirmPassword.Text == "")
			{
				MessageBox.Show("Check Information again!!!(* field cannot be blank)");
				return;
			}
			else 
			if(txt_Password.Text!=txt_comfirmPassword.Text)
			{
				MessageBox.Show("Password and PasswordComfirmed are Different!!!");
				return;
			}
			else
			{
				User user = new User
				{
					UserTypeID = 2,
					UserName = txt_UserName.Text,
					Password = txt_Password.Text,
					FullName = txt_fullName.Text,
					Email = txt_email.Text,
					PhoneNumber = txt_phoneNumber.Text,
					BirthDay = dateTime_birthday.Value
				};
				BLL_User.Instance.Create(user);
				MessageBox.Show("Account successfully created!!!");
				this.Close(); 
				
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("<333");
		}
	}
}
