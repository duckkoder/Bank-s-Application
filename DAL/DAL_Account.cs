using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAL
{
	public class DAL_Account : DAL<DAL_Account, Account, int>
	{
		public bool checkSTK(int stk)
		{
			SqlCommand cmd = new SqlCommand("checkSTK");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("STK",SqlDbType.Int).Value = stk;
			return (Int32.Parse(DataProvider.Instance.ExecuteScalar(cmd)) == 0);
		}
		public void deleteAccountByBank(int bankID)
		{
			SqlCommand cmd = new SqlCommand("deleteAccountByBank");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("BankID", SqlDbType.Int).Value = bankID;
			DataProvider.Instance.ExecuteNonQuery(cmd);
		}
		public Account getAccountBySTK(int STK)
		{
			SqlCommand cmd = new SqlCommand("getAccountBySTK");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("STK",SqlDbType.Int).Value = STK;
			DataRow dt = DataProvider.Instance.ExecuteTable(cmd).Rows[0];
			Account ac = new Account(Int32.Parse(dt["STK"]+""), dt["UserName"]+"",Int32.Parse(dt["BankID"]+""),Int32.Parse(dt["Balance"]+""));
			return ac;
		}
		public Boolean increaseBalance(int STK,int amount)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("increaseBalance");
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("STK", SqlDbType.Int).Value = STK;
				cmd.Parameters.Add("amount", SqlDbType.Int).Value = amount;
				DataProvider.Instance.ExecuteNonQuery(cmd);
				return true;
			}
			catch(Exception ex)
			{
				return false;
			}
		}
		public DataTable getAccountByUserAndBank(string userName, string bankName)
		{
			SqlCommand cmd = new SqlCommand("getAccountByUserAndBank");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("UserName",SqlDbType.NVarChar).Value = userName;
			cmd.Parameters.Add("BankName",SqlDbType.NVarChar).Value = bankName;
			return DataProvider.Instance.ExecuteTable(cmd);
		}
		public DataTable getAccountByUser(string userName)
		{
			SqlCommand cmd = new SqlCommand("getAccountByUser");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("UserName", SqlDbType.NVarChar,30).Value = userName;
			return DataProvider.Instance.ExecuteTable(cmd);
		}

		public DataTable getAccountByBank(string bankName)
		{
			SqlCommand cmd = new SqlCommand("getAccountByBank");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("BankName", SqlDbType.NVarChar,30).Value = bankName;
			return DataProvider.Instance.ExecuteTable(cmd);
		}

		public int getBalance(int stk)
		{
			SqlCommand cmd = new SqlCommand("getBalance");
			cmd.CommandType= CommandType.StoredProcedure;
			cmd.Parameters.Add("STK",SqlDbType.Int).Value = stk;
			DataTable tb = DataProvider.Instance.ExecuteTable(cmd);
			return  Int32.Parse(tb.Rows[0]["Balance"]+"");	
		}
		public override void Create(Account model)
		{
			SqlCommand cmd = new SqlCommand("InsertAccount");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("STK", SqlDbType.Int).Value = model.STK;
			cmd.Parameters.Add("BankID", SqlDbType.Int).Value = model.BankID;
			cmd.Parameters.Add("UserName", SqlDbType.NVarChar, 30).Value = model.UserID;
			cmd.Parameters.Add("Balance", SqlDbType.Int).Value = model.Balance;

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

		public override void Update(Account updateElement, int PKvalue)
		{
			throw new NotImplementedException();
		}
	}
}
