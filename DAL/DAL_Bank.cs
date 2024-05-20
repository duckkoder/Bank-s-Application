using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_Bank : DAL<DAL_Bank, Bank, int>
	{
		public bool checkBankName(string bankName)
		{
			SqlCommand cmd = new SqlCommand("checkBankName");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("BankName",SqlDbType.NVarChar,255).Value = bankName;
			if(Int32.Parse(DataProvider.Instance.ExecuteScalar(cmd))==1)
				return false;
			return true;
		}
		public void insertBank(string bankName)
		{
			SqlCommand cmd = new SqlCommand("InsertBank");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("BankName",SqlDbType.NVarChar,30).Value = bankName;
			DataProvider.Instance.ExecuteNonQuery(cmd);
		}
		public DataTable SearchBankTransfer(string name)
		{
			SqlCommand cmd = new SqlCommand("SearchBankTransfer");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@name",SqlDbType.NVarChar).Value = name;
			return DataProvider.Instance.ExecuteTable(cmd);
		}
		public DataTable getBankByUser(string userName)
		{
			SqlCommand cmd = new SqlCommand("getBankByUser");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@UserName",SqlDbType.NVarChar).Value = userName;
			return DataProvider.Instance.ExecuteTable(cmd);	
		}
		public override void Create(Bank newElement)
		{
			
		}

		public override void Delete(int PKValue)
		{
			SqlCommand cmd = new SqlCommand("deleteBank");
			cmd.CommandType =CommandType.StoredProcedure;
			cmd.Parameters.Add("BankID",SqlDbType.Int).Value = PKValue;
			DataProvider.Instance.ExecuteNonQuery(cmd);
		}

		public override DataTable Read()
		{
			SqlCommand cmd = new SqlCommand("SelectAllBank");
			return DataProvider.Instance.ExecuteTable(cmd);
		}

		public override void Update(Bank updateElement, int PKvalue)
		{
			throw new NotImplementedException();
		}
	}
}
