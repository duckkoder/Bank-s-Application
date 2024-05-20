using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_User : BLL<BLL_User, User, String>
	{
		public void updateUserInfor(User us)
		{
			DAL_User.Instance.updateUserInfor(us);
		}
			public void updateUserPassword(User user)
		{
			DAL_User.Instance.updateUserPassword(user);
		}
		public User GetUser(string UserName)
		{
			return DAL_User.Instance.getUser(UserName);
		}
		public bool checkLogin(User user)
		{
			return DAL_User.Instance.CheckLogin(user);
		}
		public override void Create(User user)
		{
			DAL_User.Instance.Create(user);
		}

		public override void Delete(string data)
		{
			throw new NotImplementedException();
		}

		public override void getList(List<User> list)
		{
			list.Clear();
			foreach (DataRow dt in Read().Rows)
			{
				list.Add(new User
				{
					UserName = dt["UserName"].ToString(),
					FullName = dt["FullName"].ToString(),
					Email = dt["email"].ToString(),
					PhoneNumber = dt["PhoneNumber"].ToString(),
					BirthDay = (DateTime) dt["Birthday"]
				});
			}
		}

		public override DataTable Read()
		{
			return DAL_User.Instance.Read();
		}

		public override void Update(User model, string data)
		{
			throw new NotImplementedException();
		}
	}
}
