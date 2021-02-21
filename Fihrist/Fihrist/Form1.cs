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

namespace Fihrist
{
    public partial class Kisiler : Form
    {
        public Kisiler()
        {
            InitializeComponent();
        }
        
       
        private void GetList()
        {
            //SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=Fihrist");

            SqlCommand command = new SqlCommand("SELECT * FROM Kisiler", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgwList.DataSource = dataTable;

        }

        SqlConnection connection;
        private void GetSettings()
        {
            IniFile file = new IniFile(Application.StartupPath + @"\Ayarlar.INI");
            string serverName = file.Read("ServerName", "SQL");
            string databaseName = file.Read("DatabaseName", "SQL");
            string userName = file.Read("UserName", "SQL");
            string password = file.Read("Password", "SQL");
            connection = new SqlConnection(@"Server=" + serverName + "; Database=" + databaseName + "; UID=" + userName + "; password=" + password);
            connection.Open();
        }

        private void UpdateAll()
        {
            //SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=Fihrist");


            SqlCommand command = new SqlCommand("UPDATE Kisiler SET Name=@Name, Surname=@Surname, PhoneNumber=@PhoneNumber, Email=@Email, Adress=@Adress WHERE Id=@Id", connection);
            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@Surname", txtSurname.Text);
            command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
            command.Parameters.AddWithValue("@Email", txtEmail.Text);
            command.Parameters.AddWithValue("@Adress", rtxtAdress.Text);
            command.Parameters.AddWithValue("@Id", txtId.Text);


            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Kayıt güncellenecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Güncellendi", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                command.Cancel();
            }
            GetList();
        }

        private void ClearAll()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rtxtAdress.Text = string.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();
            GetList();
            ClearAll();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=Fihrist");
            //connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Kisiler (Name,Surname,PhoneNumber,Email,Adress) VALUES(@Name,@Surname,@PhoneNumber,@Email,@Adress)", connection);
         
            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@Surname", txtSurname.Text);
            command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
            command.Parameters.AddWithValue("@Email", txtEmail.Text);
            command.Parameters.AddWithValue("@Adress", rtxtAdress.Text);

            if (txtName.Text == "")
            {
                MessageBox.Show("Ad Alanı boş olamaz!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Cancel();
                txtName.Text = string.Empty;
            }
            else if (txtSurname.Text == "")
            {
                MessageBox.Show("Soyad Alanı boş olamaz!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Cancel();
                txtSurname.Text = string.Empty;
            }
            else if (txtEmail.Text == "" || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("E-mail Alanı boş veya hatalı!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Cancel();
                txtEmail.Text = string.Empty;
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Telefon Alanı boş", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Cancel();
                txtPhone.Text = string.Empty;
            }
            else
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Kaydedildi", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                GetList();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=Fihrist");
            //connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Kisiler WHERE Id=@Id", connection);
            command.Parameters.AddWithValue("@Id", txtId.Text);

            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Kayıt silinecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                command.Cancel();
            }
            GetList();
            //connection.Close();

        }

        private void dgwList_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgwList.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgwList.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgwList.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgwList.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgwList.CurrentRow.Cells[4].Value.ToString();
            rtxtAdress.Text = dgwList.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text==""||txtPhone.Text==""||txtSurname.Text==""||txtEmail.Text=="")
            {
                MessageBox.Show("Tüm alanlar doldurulmalı", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateAll();
            } 
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
