using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	 public class Bank
	{
		private int _bankID;
		private string _bankName;

		public int BankID
		{
			get { return _bankID; }
			set { _bankID = value; }
		}

		public string BankName
		{
			get { return _bankName; }
			set { _bankName = value; }
		}

		public Bank(int bankID, string bankName)
		{
			this._bankID = bankID;
			this._bankName = bankName;
		}
	}
}
