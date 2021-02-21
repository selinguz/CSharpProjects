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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		public void GetList()
		{
			connection = SqlConn.MakeConnection();

			SqlCommand command = new SqlCommand("SELECT * FROM Egitimlerim WHERE Durum='Başlamadı' OR Durum='Başladı' OR Durum=NULL", connection);
			SqlDataReader dr = command.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(dr);
			dgwEgitimlerim.DataSource = dt;
			dr.Close();

			SqlCommand comm = new SqlCommand("SELECT COUNT(DISTINCT Baslik) AS Count FROM Egitimlerim WHERE Durum='Başlamadı' OR Durum='Başladı'", connection);
			SqlDataReader dr1 = comm.ExecuteReader();
			if (dr1.Read())
			{
				label8.Visible = true;
				label8.Text = dr1["Count"].ToString() + " adet eğitim";
			}
			dr1.Close();
		}

		//public void GetList(bool tumu)
		//{
		//	connection = SqlConn.MakeConnection();
		//	string command_str = "";
		//	if (tumu)
		//	{
		//		command_str = "SELECT * FROM Egitimlerim";
		//	}
		//	else
		//	{
		//		command_str = "SELECT * FROM Egitimlerim WHERE Durum IN ('Başlamadı','Başladı')";
		//	}

		//	SqlCommand command = new SqlCommand(command_str, connection);
		//	SqlDataReader dr = command.ExecuteReader();
		//	DataTable dt = new DataTable();
		//	dt.Load(dr);
		//	dgwEgitimlerim.DataSource = dt;
		//	dr.Close();
		//}

		public void GetAllList()
		{
			connection = SqlConn.MakeConnection();
			SqlCommand command = new SqlCommand("SELECT * FROM Egitimlerim", connection);
			SqlDataReader dr = command.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(dr);
			dgwEgitimlerim.DataSource = dt;
			dr.Close();

			SqlCommand comm = new SqlCommand("SELECT COUNT(DISTINCT Baslik) AS Count FROM Egitimlerim", connection);
			SqlDataReader dr1 = comm.ExecuteReader();
			if (dr1.Read())
			{
				label8.Visible = true;
				label8.Text = dr1["Count"].ToString() + " adet eğitim";
			}
			dr1.Close();
		}

		public int ToplamSaat()
		{
			int toplamSaat = 0;
			connection = SqlConn.MakeConnection();
			SqlCommand command = new SqlCommand("SELECT SUM(Saat) AS ToplamSaat FROM Egitimlerim WHERE Durum='Başlamadı' OR Durum='Başladı'", connection);
			SqlDataReader dr = command.ExecuteReader();
			if (dr.Read())
			{
				toplamSaat = Convert.ToInt32(dr["ToplamSaat"]);
			}
			return toplamSaat;
		}

		public int ToplamDakika()
		{
			int toplamDakika = 0;
			connection = SqlConn.MakeConnection();
			SqlCommand command = new SqlCommand("SELECT SUM(Dakika) AS ToplamDakika FROM Egitimlerim WHERE Durum='Başlamadı' OR Durum='Başladı'", connection);
			SqlDataReader dr = command.ExecuteReader();
			if (dr.Read())
			{
				toplamDakika = Convert.ToInt32(dr["ToplamDakika"]);
			}
			dr.Close();
			return toplamDakika;
		}

		SqlConnection connection;
		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.OpenForms["Form1"].Show();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			GetList();

		}

		private void dgwEgitimlerim_SelectionChanged(object sender, EventArgs e)
		{
			if (dgwEgitimlerim.SelectedRows.Count > 0)
			{
				var row = dgwEgitimlerim.SelectedRows[0];
				txtEgitimBasligi.Text = row.Cells[1].Value.ToString();
				txtEgitimAltBasligi.Text = row.Cells[2].Value.ToString();
				txtSaat.Text = row.Cells[3].Value.ToString();
				txtDakika.Text = row.Cells[4].Value.ToString();
			}
			string sonuc = "";
			int saatToplami = ToplamSaat();
			int dakika = ToplamDakika();
			int saat = dakika / 60;
			int saatler = saat + saatToplami;

			int gun = saatler / 24;
			if (gun > 0)
			{
				sonuc += gun + " Gün ";
			}
			
			
			if(saat > 0 || saatToplami > 0)
			{
				sonuc += saatler-(gun*24) + " Saat ";
			}
			
			dakika = dakika % 60;
			if(dakika > 0)
			{
				sonuc += dakika + " Dakika";
			}
			sonuc += " kaldı";

			label7.Text = sonuc;
			label7.Visible = true;

			

		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			var row = dgwEgitimlerim.SelectedRows[0];
			connection = SqlConn.MakeConnection();
			SqlCommand command = new SqlCommand("UPDATE Egitimlerim SET Baslik=@Baslik, AltBaslik=@AltBaslik, Saat=@Saat, Dakika=@Dakika, Durum=@Durum WHERE Id=@Id", connection);
			command.Parameters.AddWithValue("@Id", row.Cells[0].Value.ToString());
			command.Parameters.AddWithValue("@Baslik", txtEgitimBasligi.Text);
			command.Parameters.AddWithValue("@AltBaslik", txtEgitimAltBasligi.Text);
			command.Parameters.AddWithValue("@Saat", txtSaat.Text);
			command.Parameters.AddWithValue("@Dakika", txtDakika.Text);
			command.Parameters.AddWithValue("@Durum", cmbDurumu.SelectedItem.ToString());
			command.ExecuteNonQuery();
			MessageBox.Show("Güncelleme Başarılı!");
			if (chkTum.Checked)
			{
				GetAllList();
			}
			else
			{
				GetList();
			}


		}

		private void chkTum_CheckedChanged(object sender, EventArgs e)
		{
			if (chkTum.Checked)
			{
				GetAllList();
			}
			else
			{
				GetList();
			}
			//GetList(chkTum.Checked);
		}
	}
}
