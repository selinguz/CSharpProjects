using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitimlerim
{
	public class Egitim
	{
		public string Baslik { get; set; }
		public string AltBaslik { get; set; }
		public int SureSaat { get; set; }
		public int SureDakika { get; set; }
		public string Durum { get; set; }

		SqlConnection connection;
		public void GetList()
		{
			
		}

		
	}
}
