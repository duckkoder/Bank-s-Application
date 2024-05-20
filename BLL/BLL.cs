using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
	public abstract class BLL<BLLType, ModelType, PKType> where BLLType : new ()
	{
		protected static BLLType _Instance;
		protected BLL() { }
		public static BLLType Instance
		{
			get
			{
				if (_Instance == null) _Instance = new BLLType();
				return _Instance;
			}
			private set
			{
				_Instance = value;
			}
		}
		public void ShowDGV(DataGridView dgv)
		{
			dgv.DataSource = null;
			dgv.Rows.Clear();
			dgv.DataSource = Read();
		}
		public abstract void getList(List<ModelType> list);
		public abstract DataTable Read();
		public abstract void Create(ModelType model);
		public abstract void Delete(PKType data);
		public abstract void Update(ModelType model, PKType data);
	}
}
