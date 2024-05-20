using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Transaction
	{
		private int _STKTransferred;
		private int _STKReceived;
		private string _transactionType;
		private int _amount;
		private DateTime _time;

		public int STKTransferred
		{
			get { return _STKTransferred; }
			set { _STKTransferred = value; }
		}

		public int STKReceived
		{
			get { return _STKReceived; }
			set { _STKReceived = value; }
		}

		public string TransactionType
		{
			get { return _transactionType; }
			set { _transactionType = value; }
		}

		public int Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

		public DateTime Time
		{
			get { return _time; }
			set { _time = value; }
		}
	}

}
