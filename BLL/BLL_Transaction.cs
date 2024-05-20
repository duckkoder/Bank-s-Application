using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
	public class BLL_Transaction : BLL<BLL_Transaction, Transaction, int>
	{
		public DataTable getTransactionHistoryByAccount(int STK)
		{
			 return DAL_Transaction.Instance.getTransactionHistoryByAccount(STK);
		}
		public override void Create(Transaction model)
		{
			DAL_Transaction.Instance.Create(model);
		}

		public override void Delete(int data)
		{
			throw new NotImplementedException();
		}

		public override void getList(List<Transaction> list)
		{
			throw new NotImplementedException();
		}

		public override DataTable Read()
		{
			throw new NotImplementedException();
		}

		public override void Update(Transaction model, int data)
		{
			throw new NotImplementedException();
		}
	}
}
