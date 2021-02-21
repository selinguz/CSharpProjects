using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egitimlerim
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		SqlConnection connection;
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.OpenForms["Form1"].Show();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			connection = SqlConn.MakeConnection();
			SqlCommand command = new SqlCommand("INSERT INTO Egitimlerim (Baslik,AltBaslik,Saat,Dakika,Durum) VALUES (@Baslik,@AltBaslik,@Saat,@Dakika,@Durum)",connection);
			command.Parameters.AddWithValue("@Baslik",txtEgitimBasligi.Text);
			command.Parameters.AddWithValue("@AltBaslik",txtEgitimAltBasligi.Text);
			command.Parameters.AddWithValue("@Saat",txtSaat.Text);
			command.Parameters.AddWithValue("@Dakika",txtDakika.Text);
			command.Parameters.AddWithValue("@Durum","Başlamadı");
			command.ExecuteNonQuery();
			MessageBox.Show("Kayıt Başarılı");
			if (txtEgitimAltBasligi.Text=="")
			{
				txtEgitimBasligi.Text = string.Empty;
				txtEgitimAltBasligi.Text = string.Empty;
				txtSaat.Text = string.Empty;
				txtDakika.Text = string.Empty;
				txtEgitimBasligi.Focus();
			}
			else
			{
				txtEgitimAltBasligi.Text = string.Empty;
				txtSaat.Text = string.Empty;
				txtDakika.Text = string.Empty;
				txtEgitimAltBasligi.Focus();
			}
			
		}
	}
}
