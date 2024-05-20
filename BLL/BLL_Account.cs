using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_Account : BLL<BLL_Account, Account, int>
	{
		public bool checkSTK(int stk)
		{
			return DAL_Account.Instance.checkSTK(stk);
		}
		public void deleteAccountByBank(int bankID)
		{
			DAL_Account.Instance.deleteAccountByBank(bankID);
		}
		public Account getAccountBySTK(int STK)
		{
			return DAL_Account.Instance.getAccountBySTK(STK);
		}
		public Boolean increaseBalance(int STK, int amount)
		{
			return DAL_Account.Instance.increaseBalance(STK, amount);
		}
		public DataTable getAccountByUserAndBank(string userName,string bankName)
		{
			return DAL_Account.Instance.getAccountByUserAndBank(userName,bankName);
		}
		public DataTable getAccountByUser(string userName)
		{
			return DAL_Account.Instance.getAccountByUser(userName);
		}
		public DataTable getAccountByBank(string bankName)
		{
			return DAL_Account.Instance.getAccountByBank(bankName);
		}

		public int getBalance(int stk)
		{ 
			return DAL_Account.Instance.getBalance(stk);
		}
		public override void Create(Account model)
		{
			DAL_Account.Instance.Create(model);
		}

		public override void Delete(int data)
		{
			throw new NotImplementedException();
		}

		public override void getList(List<Account> list)
		{
			throw new NotImplementedException();
		}

		public override DataTable Read()
		{
			throw new NotImplementedException();
		}

		public override void Update(Account model, int data)
		{
			throw new NotImplementedException();
		}
	}
}
