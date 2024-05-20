using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Account
	{
		private int _STK;
		private string _userName;
		private int _bankID;
		private int _balance;

		public int STK
		{
			get { return _STK; }
			set { _STK = value; }
		}

		public string UserID
		{
			get { return _userName; }
			set { _userName = value; }
		}

		public int BankID
		{
			get { return _bankID; }
			set { _bankID = value; }
		}

		public int Balance
		{
			get { return _balance; }
			set { _balance = value; }
		}

		public Account(int STK, string userName, int bankID, int balance)
		{
			_STK = STK;
			_userName = userName;
			_bankID = bankID;
			_balance = balance;
		}
	}
}
