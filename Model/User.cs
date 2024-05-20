using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class User
	{
		private int _userTypeID;
		private string _userName;
		private string _password;
		private string _fullName;
		private string _email;
		private string _phoneNumber;
		private DateTime _birthDay;
		private string _randomKey;

	
		public int UserTypeID
		{
			get { return _userTypeID; }
			set { _userTypeID = value; }
		}
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		public string FullName
		{
			get { return _fullName; }
			set { _fullName = value; }
		}

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		public string PhoneNumber
		{
			get { return _phoneNumber; }
			set { _phoneNumber = value; }
		}

		public DateTime BirthDay
		{
			get { return _birthDay; }
			set { _birthDay = value; }
		}

		public User()
		{
		}

		public User(string userName, string password, string fullName, string email, string phoneNumber, DateTime birthDay, string randomKey)
		{
			this._userName = userName;
			this._password = password;
			this._fullName = fullName;
			this._email = email;
			this._phoneNumber = phoneNumber;
			this._birthDay = birthDay;
			this._randomKey = randomKey;
		}
	}
}
