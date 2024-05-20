using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class UserType
	{
		private int _userTypeID;
		private string _role;

		public int UserTypeID
		{
			get { return _userTypeID; }
			set { _userTypeID = value; }
		}

		public string Role
		{
			get { return _role; }
			set { _role = value; }
		}

		public UserType(int userTypeID, string role)
		{
			_userTypeID = userTypeID;
			_role = role ?? "Customer";
		}
	}
}
