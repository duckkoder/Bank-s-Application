using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BLL
{
	public class BLL_Bank : BLL<BLL_Bank, Bank, int>
	{
		public bool checkBankName(string bankName)
		{
			return DAL_Bank.Instance.checkBankName(bankName);
		}
		public void insertBank(string bankName)
		{
			DAL_Bank.Instance.insertBank(bankName);
		}
		public DataTable SearchBankTransfer(string name)
		{
			return DAL_Bank.Instance.SearchBankTransfer(name);
		}
		public DataTable getBankByUser(string userName)
		{
			return DAL_Bank.Instance.getBankByUser(userName);
		}
		public override void Create(Bank model)
		{
			throw new NotImplementedException();
		}

		public override void Delete(int data)
		{
			DAL_Bank.Instance.Delete(data);
		}

		public override void getList(List<Bank> list)
		{
			list.Clear();
			foreach (DataRow dt in Read().Rows)
			{
				Bank b = new Bank(Convert.ToInt32(dt["BankID"]), dt["BankName"].ToString());
				list.Add(b);
			}
		}

		public override DataTable Read()
		{
			return DAL_Bank.Instance.Read();
		}

		public override void Update(Bank model, int data)
		{
			throw new NotImplementedException();
		}
	}
}
