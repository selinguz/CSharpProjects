
namespace Egitimlerim
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgwEgitimlerim = new System.Windows.Forms.DataGridView();
			this.txtDakika = new System.Windows.Forms.TextBox();
			this.txtSaat = new System.Windows.Forms.TextBox();
			this.txtEgitimAltBasligi = new System.Windows.Forms.TextBox();
			this.txtEgitimBasligi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbDurumu = new System.Windows.Forms.ComboBox();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.chkTum = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgwEgitimlerim)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwEgitimlerim
			// 
			this.dgwEgitimlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwEgitimlerim.Location = new System.Drawing.Point(13, 25);
			this.dgwEgitimlerim.MultiSelect = false;
			this.dgwEgitimlerim.Name = "dgwEgitimlerim";
			this.dgwEgitimlerim.ReadOnly = true;
			this.dgwEgitimlerim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwEgitimlerim.Size = new System.Drawing.Size(646, 218);
			this.dgwEgitimlerim.TabIndex = 0;
			this.dgwEgitimlerim.SelectionChanged += new System.EventHandler(this.dgwEgitimlerim_SelectionChanged);
			// 
			// txtDakika
			// 
			this.txtDakika.Location = new System.Drawing.Point(131, 386);
			this.txtDakika.Name = "txtDakika";
			this.txtDakika.Size = new System.Drawing.Size(100, 20);
			this.txtDakika.TabIndex = 15;
			// 
			// txtSaat
			// 
			this.txtSaat.Location = new System.Drawing.Point(131, 346);
			this.txtSaat.Name = "txtSaat";
			this.txtSaat.Size = new System.Drawing.Size(100, 20);
			this.txtSaat.TabIndex = 14;
			// 
			// txtEgitimAltBasligi
			// 
			this.txtEgitimAltBasligi.Location = new System.Drawing.Point(131, 304);
			this.txtEgitimAltBasligi.Name = "txtEgitimAltBasligi";
			this.txtEgitimAltBasligi.Size = new System.Drawing.Size(236, 20);
			this.txtEgitimAltBasligi.TabIndex = 13;
			// 
			// txtEgitimBasligi
			// 
			this.txtEgitimBasligi.Location = new System.Drawing.Point(131, 266);
			this.txtEgitimBasligi.Name = "txtEgitimBasligi";
			this.txtEgitimBasligi.Size = new System.Drawing.Size(236, 20);
			this.txtEgitimBasligi.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 393);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Eğitim Süresi (Dakika):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 354);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Eğitim Süresi (Saat):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 312);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Eğitim Alt Başlığı:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 273);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Eğitim Başlığı:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 433);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Durumu:";
			// 
			// cmbDurumu
			// 
			this.cmbDurumu.FormattingEnabled = true;
			this.cmbDurumu.Items.AddRange(new object[] {
            "Başlamadı",
            "Başladı",
            "Tamamlandı"});
			this.cmbDurumu.Location = new System.Drawing.Point(132, 425);
			this.cmbDurumu.Name = "cmbDurumu";
			this.cmbDurumu.Size = new System.Drawing.Size(99, 21);
			this.cmbDurumu.TabIndex = 17;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(264, 425);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(103, 23);
			this.btnGuncelle.TabIndex = 18;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 473);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Toplam";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 500);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "label7";
			this.label7.Visible = false;
			// 
			// chkTum
			// 
			this.chkTum.AutoSize = true;
			this.chkTum.Location = new System.Drawing.Point(433, 266);
			this.chkTum.Name = "chkTum";
			this.chkTum.Size = new System.Drawing.Size(183, 17);
			this.chkTum.TabIndex = 26;
			this.chkTum.Text = "Tamamlanmış Eğitimleri de Göster";
			this.chkTum.UseVisualStyleBackColor = true;
			this.chkTum.CheckedChanged += new System.EventHandler(this.chkTum_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(63, 473);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 27;
			this.label8.Text = "label8";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 522);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.chkTum);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.cmbDurumu);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDakika);
			this.Controls.Add(this.txtSaat);
			this.Controls.Add(this.txtEgitimAltBasligi);
			this.Controls.Add(this.txtEgitimBasligi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgwEgitimlerim);
			this.Name = "Form3";
			this.Text = "Form3";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwEgitimlerim)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwEgitimlerim;
		private System.Windows.Forms.TextBox txtDakika;
		private System.Windows.Forms.TextBox txtSaat;
		private System.Windows.Forms.TextBox txtEgitimAltBasligi;
		private System.Windows.Forms.TextBox txtEgitimBasligi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbDurumu;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox chkTum;
		private System.Windows.Forms.Label label8;
	}
}