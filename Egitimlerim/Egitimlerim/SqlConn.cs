using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egitimlerim
{
	class SqlConn
	{
		public static SqlConnection MakeConnection()
		{
			IniFile iniFile = new IniFile(Application.StartupPath + "\\Ayarlar.INI");
			string serverName = iniFile.Read("ServerName","SQL");
			string databaseName = iniFile.Read("DatabaseName", "SQL");
			string userName = iniFile.Read("UserName", "SQL");
			string password = iniFile.Read("Password", "SQL");

			SqlConnection connection = new SqlConnection($"Server={serverName};Database={databaseName};UID={userName};PWD={password};Trusted_Connection=True;Integrated Security=True");

			if (connection.State != ConnectionState.Open)
			{
				connection.Open();
			}

			return connection;
		}
	}
}
