using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
	public class DAL_User : DAL<DAL_User, User, string>
	{
		public void updateUserInfor(User us)
		{
			SqlCommand cmd = new SqlCommand("updateUserInfor");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("UserName", SqlDbType.NVarChar).Value = us.UserName;
			cmd.Parameters.Add("FullName", SqlDbType.NVarChar).Value = us.FullName;
			cmd.Parameters.Add("PhoneNumber", SqlDbType.NVarChar).Value = us.PhoneNumber;
			cmd.Parameters.Add("Email",SqlDbType.NVarChar).Value = us.Email;
			cmd.Parameters.Add("BirthDay",SqlDbType.DateTime).Value = us.BirthDay;
			DataProvider.Instance.ExecuteNonQuery(cmd);
		}
		public void updateUserPassword(User us)
		{
			SqlCommand cmd = new SqlCommand("updateUserPassword");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("UserName",SqlDbType.NVarChar).Value = us.UserName;
			cmd.Parameters.Add("RandomKey",SqlDbType.NVarChar,1000).Value = MySetting.SHA512(us.Password);
			DataProvider.Instance.ExecuteNonQuery(cmd);
		}
		public User getUser(string UserName)
		{
			SqlCommand cmd = new SqlCommand("getUser");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@UserName",SqlDbType.NVarChar).Value = UserName;
			DataTable tb = DataProvider.Instance.ExecuteTable(cmd);
			DataRow dr = tb.Rows[0];
			User user = new User
			{
				UserTypeID = Int32.Parse(dr["UserTypeID"].ToString()),
				UserName = UserName,
				FullName = dr["FullName"].ToString(),
				Email = dr["Email"].ToString(),
				PhoneNumber = dr["PhoneNumber"].ToString(),
				BirthDay = (DateTime)dr["Birthday"]
			};
			return user;
		}
		public bool CheckLogin(User user)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = $"SELECT * FROM [User] WHERE UserName ='{user.UserName}' AND RandomKey = '{(MySetting.SHA512(user.Password))}'";
			DataTable tb = DataProvider.Instance.ExecuteTable(cmd);
			if (tb == null)
			{
				return false;
			}
			else
			{
				foreach (DataRow dr in tb.Rows)
				{
					string name = dr["FullName"].ToString();
					return true;
				}
			}
			return false;

		}
		public override void Create(User newElement)
		{
			SqlCommand cmd = new SqlCommand("InsertUser");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@UserTypeID",SqlDbType.Int).Value = newElement.UserTypeID;
			cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = newElement.UserName;
			cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = "";
			cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = newElement.FullName;
			cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = newElement.Email;
			cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = newElement.PhoneNumber;
			cmd.Parameters.Add("@BirthDay", SqlDbType.Date).Value = newElement.BirthDay;
			cmd.Parameters.Add("@Randomkey", SqlDbType.NVarChar).Value = MySetting.SHA512(newElement.Password);
			DataProvider.Instance.ExecuteNonQuery(cmd);
		}

		public override void Delete(string PKValue)
		{
			throw new NotImplementedException();
		}

		public override DataTable Read()
		{
			SqlCommand cmd = new SqlCommand("SelectAllUser");
			return DataProvider.Instance.ExecuteTable(cmd);
		}

		public override void Update(User updateElement, string PKvalue)
		{
			
		}
	}
}
