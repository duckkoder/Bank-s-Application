using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
	public class DAL_Transaction : DAL<DAL_Transaction, Transaction, int>
	{
		public DataTable getTransactionHistoryByAccount(int STK)
		{
			SqlCommand cmd = new SqlCommand("getTransactionHistoryByAccount");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("STK",SqlDbType.Int).Value = STK;
			return DataProvider.Instance.ExecuteTable(cmd);
		}
		public override void Create(Transaction newElement)
		{
			SqlCommand cmd = new SqlCommand("InsertTransaction");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@STKTransferred", SqlDbType.Int).Value = newElement.STKTransferred;
			if (newElement.TransactionType == "Transfer")
				cmd.Parameters.Add("@STKReceived", SqlDbType.Int).Value = newElement.STKReceived;
			else
				cmd.Parameters.Add("@STKReceived", SqlDbType.Int).Value = DBNull.Value;
			cmd.Parameters.Add("@TransactionType", SqlDbType.NVarChar, 20).Value = newElement.TransactionType;
			cmd.Parameters.Add("@Time", SqlDbType.DateTime).Value = newElement.Time;
			cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = newElement.Amount;

			DataProvider.Instance.ExecuteNonQuery(cmd);

		}

		public override void Delete(int PKValue)
		{
			throw new NotImplementedException();
		}

		public override DataTable Read()
		{
			throw new NotImplementedException();
		}

		public override void Update(Transaction updateElement, int PKvalue)
		{
			throw new NotImplementedException();
		}
	}
}
